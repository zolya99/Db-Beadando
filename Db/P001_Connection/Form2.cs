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
    public partial class Form2 : Form
    {
        private CountryManager dbManager;
        private List<Csapat> records;
        public Form2()
        {
            InitializeComponent();

            dbManager = new CountryManager();
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            loadComboBox();
        }

        private void loadComboBox()
        {
            records = dbManager.GetListCsapat();
            // a records elemeit betöltöm a comboBox-ba 
            // 0) jelzem, hogy frissítem az elemeket, így nem kell újrarajzolni
            comboBox_contries.BeginUpdate();
            // 1) ha van elem a cb-ben, akkor törlöm 
            comboBox_contries.Items.Clear();
            // 2) ciklus segítségével feltöltöm a comboBox-ot
            foreach (Csapat record in records)
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
            Csapat recordToDelete = selectedRecord;

            // 3) törlöm a rekordot a db-ből 
            bool success = dbManager.DeleteCsapat(recordToDelete);

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
            Csapat newRecord = new Csapat();
            try
            {
                newRecord.Id = rnd.Next(10, 100); // TODO: javítani később, ez csak tesztelésre 
                newRecord.Nev = tb1.Text;
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            // ha ide jutunk, akkor a példányosítás során nem volt 
            // gond, mehet az insert 
            bool success = dbManager.InsertCsapat(newRecord);

            if (success)
            {
                MessageBox.Show("Sikeres rögzítés");
                tb1.Text = string.Empty;
                
                loadComboBox();
            }
            else MessageBox.Show("Hiba az insert során!");
        }

        Csapat selectedRecord;
        private void comboBox_contries_SelectedValueChanged(object sender, EventArgs e)
        {
            selectedRecord = (Csapat)comboBox_contries.SelectedItem;
            updateFields();
        }

        private void updateFields()
        {
            selectedRecord = dbManager.GetOneCsapat(selectedRecord);

            if(selectedRecord != null)
            {
                tb1u.Text = selectedRecord.Nev;
                
            }
            else
            {
                tb1u.Text = string.Empty;
                
                
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            Csapat temp = new Csapat();
            try
            {
                temp.Id = selectedRecord.Id;
                temp.Nev = tb1u.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            if (dbManager.UpdateCsapat(temp))
            {
                MessageBox.Show("Sikeres módosítás!");
                tb1u.Text = string.Empty;
                
                
                loadComboBox();
            }
            else
            {
                MessageBox.Show("Hiba");
            }

            
        }
    }
}
