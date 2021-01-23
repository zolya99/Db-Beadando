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
    public partial class Form4 : Form
    {
        private Manager dbManager;
        public bool logged = false;
        private List<User> records;
        public Form4()
        {
            InitializeComponent();
            dbManager = new Manager();

        }

        



        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            records = dbManager.UserReadAll();
            foreach (User user in dbManager.UserReadAll())
            {
                if (Username_tb.Text == user.Felhasznalonev && Password_tb.Text == user.Jelszo)
                {
                    logged = true;
                    MessageBox.Show("Logged In");
                    Close();
                }
                else
                {

                    MessageBox.Show("Ilyen felhasználónév és jelszó kombináció nem létezik! Kérlek próbáld újra!");
                }
            }
        }
    }
}
