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
        Form4 login = new Form4();
        public Form1()
        {
            InitializeComponent();

            dbManager = new Manager();
            btnlogout.Enabled = false;
            if (login.logged)
            {
                btn_login.Enabled = false;
                btnlogout.Enabled = true;
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            loadComboBox();
        }

        private void loadComboBox()
        {
            records = dbManager.GetListFocista();
            
            comboBox_contries.BeginUpdate();
            
            comboBox_contries.Items.Clear();
            
            foreach (Focista record in records)
            {
                comboBox_contries.Items.Add(record);
            }

            
            comboBox_contries.EndUpdate();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            
            if (login.logged)
            {
                if (selectedRecord == null)
                {
                    MessageBox.Show("Nincs elem kiválasztva a törléshez!");
                    return;
                }

                 
                Focista recordToDelete = selectedRecord;

                
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
            else
            {
                MessageBox.Show("Először jelentkezz be!");
            }
        }
            

        private static Random rnd = new Random();
        private void button_insert_Click(object sender, EventArgs e)
        {
            
            Focista newRecord = new Focista();
            if (login.logged)
            {
                try
                {
                    newRecord.Id = rnd.Next(10, 100000); 
                    newRecord.Szuletesi_ev = int.Parse(tb1.Text);
                    newRecord.Vezeteknev = tb2.Text;
                    newRecord.Keresztnev = tb3.Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

              
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
            else
            {
                MessageBox.Show("Először jelentkezz be!");
            }
           
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
            if (login.logged)
            {
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
            else
            {
                MessageBox.Show("ELőször jelentkezz be!");
            }
            
        }

        

        private void btnP_Click_1(object sender, EventArgs e)
        {
            
            Form3 poszt = new Form3();
            if (login.logged)
            {
                poszt.Show();
            }
            else
            {
                MessageBox.Show("Először jelentkezz be!");
            }
            
        }

        private void btnC_Click_1(object sender, EventArgs e)
        {
            Form2 csapat = new Form2();
            if (login.logged)
            {
                csapat.Show();
            }
            else
            {
                MessageBox.Show("Először jelentkezz be!");
            }
            
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (login.logged)
            {
                MessageBox.Show("Már be vagy jelentkezve!");

            }
            else
            {
                login.Show();
           
                
            }
        }

        private void groupBox_update_Enter(object sender, EventArgs e)
        {

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            
                Close();
            
        }
    }
}
