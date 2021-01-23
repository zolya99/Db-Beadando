using P001_Connection.Model.Manager;
using P001_Connection.Model.Record;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P001_Connection
{
    public partial class Form1 : Form
    {
        private Manager dbManager;
        private List<Focista> records;
        public Form1()
        {
            InitializeComponent();

            dbManager = new Manager();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            loadComboBox();
        }

        private void loadComboBox()
        {
            records = dbManager.GetListFocista();
            // a records elemeit betöltöm a comboBox-ba 
            // 0) jelzem, hogy frissítem az elemeket, így nem kell újrarajzolni
            comboBox_contries.BeginUpdate();
            // 1) ha van elem a cb-ben, akkor törlöm 
            comboBox_contries.Items.Clear();
            // 2) ciklus segítségével feltöltöm a comboBox-ot
            foreach (Focista record in records)
            {
                comboBox_contries.Items.Add(record);
            }

            // 3) jelzem, hogy kész vagyok a frissítéssel 
            comboBox_contries.EndUpdate();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            // 1) van-e egyáltalán kiválasztva elem a listában 
            // ha nincs kiválasztva, akkor a választott érték null 
            if(selectedRecord == null)
            {
                MessageBox.Show("Nincs elem kiválasztva a törléshez!");
                return;
            }

            // 2) kinyerem, hogy mit is kell törölni 
            Focista recordToDelete = selectedRecord;

            // 3) törlöm a rekordot a db-ből 
            bool success = dbManager.DeleteFocista(recordToDelete);

            if (success)
            {
                loadComboBox();
            }
            else
            {
                MessageBox.Show("A törlés sikertelen volt!");
            }
        }

        private static Random rnd = new Random();
        private void button_insert_Click(object sender, EventArgs e)
        {
            // a bevitt adatokból készítek egy rekordot 
            Focista newRecord = new Focista();
            try
            {
                newRecord.Id = rnd.Next(10, 100); // TODO: javítani később, ez csak tesztelésre 
                newRecord.Szuletesi_ev = int.Parse(tb1.Text);
                newRecord.Vezeteknev = tb2.Text;
                newRecord.Keresztnev = tb3.Text;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            // ha ide jutunk, akkor a példányosítás során nem volt 
            // gond, mehet az insert 
            bool success = dbManager.InsertFocista(newRecord);

            if (success)
            {
                MessageBox.Show("Sikeres rögzítés");
                tb1.Text = string.Empty;
                tb2.Text = string.Empty;
                tb3.Text = string.Empty;
                loadComboBox();
            }
            else MessageBox.Show("Hiba az insert során!");
        }

        Focista selectedRecord;
        private void comboBox_contries_SelectedValueChanged(object sender, EventArgs e)
        {
            selectedRecord = (Focista)comboBox_contries.SelectedItem;
            updateFields();
        }

        private void updateFields()
        {
            selectedRecord = dbManager.GetOneFocista(selectedRecord);

            if(selectedRecord != null)
            {
                tb1u.Text = selectedRecord.Szuletesi_ev.ToString();
                tb2u.Text = selectedRecord.Vezeteknev;
                tb3u.Text = selectedRecord.Keresztnev;
            }
            else
            {
                tb1u.Text = string.Empty;
                tb2u.Text = string.Empty;
                tb3u.Text = string.Empty;

                
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            Focista temp = new Focista();
            try
            {
                temp.Id = selectedRecord.Id;
                temp.Szuletesi_ev = int.Parse(tb1u.Text);
                temp.Vezeteknev = tb2u.Text;
                temp.Keresztnev = tb3u.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            if (dbManager.UpdateFocista(temp))
            {
                MessageBox.Show("Sikeres módosítás!");
                tb1u.Text = string.Empty;
                tb2u.Text = string.Empty;
                tb3u.Text = string.Empty;
                
                loadComboBox();
            }
            else
            {
                MessageBox.Show("Hiba");
            }
        }

        

        private void btnP_Click_1(object sender, EventArgs e)
        {
            
            Form3 poszt = new Form3();
            poszt.Show();
        }

        private void btnC_Click_1(object sender, EventArgs e)
        {
            Form2 csapat = new Form2();
            csapat.Show();
        }
    }
}
