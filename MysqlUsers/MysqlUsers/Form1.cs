using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MysqlUsers
{
    public partial class Form1 : Form
    {
        private MySqlConnection msqlConn;
        private MySqlDataReader msqlDr;

        private string openSikeres = "kapcsolódás sikeres",
                       openNemSikeres = "kapcsolódás nem sikerült",
                       canToRead = "az olvasás megkezdődött",
                       closedDB = "az adatbázis kapcsolat bezárva";

        private string insBasic = "Beszúrás";
        private string insEdit = "Szerkesztés vége";
        private string updBasic= "Módosítás";
        private string updEdit = "Módosítás vége";

        private enum FormState
        {
            Opened,
            Closed,
            Reading,
            EditInsert,
            EditUpdate
        }
        private FormState formState=FormState.Closed;

        public Form1()
        {
            InitializeComponent();
        }

        private void mysqlconnect()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "iktat";
            
            try
            {
                msqlConn=new MySqlConnection(sb.ToString());
                msqlConn.Open();
                MessageBox.Show(openSikeres);
                
                formState = FormState.Opened;
                /*buttonSwitch(fromState);*/
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{openNemSikeres} \n {ex.Message}");
            }
        }

        private void btnConn_Click(object sender, EventArgs e)
        {
            mysqlconnect();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            msqlConn.Close();
            MessageBox.Show(closedDB);
            formState= FormState.Closed;
            /*ButtonState(fromState);*/
        }
    }
}
