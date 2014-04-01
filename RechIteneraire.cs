using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Common;
using Oracle.DataAccess.Client;

namespace IHM
{
    public partial class RechIteneraire : Form
    {
        private OracleConnection con;
        private List<heure> listeheure = new List<heure>();

        public RechIteneraire()
        {
            InitializeComponent();
            //Changement du titre de la fenêtre
            this.Text = "Recherche";
            //Initialisation des comboBox
            semaineCB.SelectedItem = "Lundi au Vendredi";
            semaineCB.DropDownStyle = ComboBoxStyle.DropDownList;

            ligneBusCB.DropDownStyle = ComboBoxStyle.DropDownList;
            ligneBus1CB.DropDownStyle = ComboBoxStyle.DropDownList;
            ligneRechCB.DropDownStyle = ComboBoxStyle.DropDownList;
            ligneTotemCB.DropDownStyle = ComboBoxStyle.DropDownList;

            arretCB.DropDownStyle = ComboBoxStyle.DropDownList;
            arret1CB.DropDownStyle = ComboBoxStyle.DropDownList;
            arretRechCB.DropDownStyle = ComboBoxStyle.DropDownList;
            arretTotemCB.DropDownStyle = ComboBoxStyle.DropDownList;

            //Connexion à la base de données
            con = new OracleConnection();
            con.ConnectionString = "User Id = aw269193; Password = aw269193; Data Source=//ufrsciencestech.u-bourgogne.fr:25562/L32012";
            //con.ConnectionString = "User Id = aw269193; Password = aw269193; Data Source=//stendhal:1521/L32012";
            con.Open();

            //Requete pour initialiser les comboBox
            string sQuery = "Select nomLigne from ligneBus";
            OracleCommand cmd = new OracleCommand(sQuery);
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            OracleDataReader reader = cmd.ExecuteReader();

            
            while (reader.Read())
            {
                //Initialisation des comboBox
                ligneRechCB.Items.Add(reader.GetString(0));
                ligneBusCB.Items.Add(reader.GetString(0));
                ligneBus1CB.Items.Add(reader.GetString(0));
                ligneTotemCB.Items.Add(reader.GetString(0));
            }
        }

        private void rechercherB_Click(object sender, EventArgs e)
        {

            string sQuery = "Select distinct arret.numeroArret, ligneBus.numeroLigne from ligne_Arret,arret,ligneBus where ligne_Arret.numeroLigne=ligneBus.numeroLigne and ligne_Arret.numeroArret = arret.numeroArret and ligneBus.nomLigne ='" + ligneRechCB.SelectedItem + "' and arret.nomGare ='" + arretRechCB.Text + "'";

            OracleCommand cmd = new OracleCommand(sQuery);
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            OracleDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int numeroLigne1 = Int32.Parse(reader.GetOracleValue(1).ToString());
            int numeroArret1 = Int32.Parse(reader.GetOracleValue(0).ToString());
            ficheHoraireFenetre fhf = new ficheHoraireFenetre(numeroLigne1,numeroArret1);
            fhf.Show();
        }

        private void ligneRechCB_TextChanged(object sender, EventArgs e)
        {
            //Initialisation des comboBox des arrets
            arretRechCB.Items.Clear();
            string sQuery = "select distinct nomGare from ligne_Arret,arret,ligneBus where ligneBus.numeroLigne=ligne_Arret.numeroLigne and ligne_Arret.numeroArret = arret.numeroArret and nomLigne ='" + ligneRechCB.SelectedItem + "'";
            OracleCommand cmd = new OracleCommand(sQuery);
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            OracleDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                arretRechCB.Items.Add(reader.GetOracleValue(0));
            }
        }

        private void ligneBusCB_TextChanged(object sender, EventArgs e)
        {
            //Initialisation des comboBox des arrets
            arretCB.Items.Clear();
            string sQuery = "select distinct nomGare from ligne_Arret,arret,ligneBus where ligneBus.numeroLigne=ligne_Arret.numeroLigne and ligne_Arret.numeroArret = arret.numeroArret and nomLigne ='" + ligneBusCB.SelectedItem + "'";
            OracleCommand cmd = new OracleCommand(sQuery);
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            OracleDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                arretCB.Items.Add(reader.GetOracleValue(0));
            }
        }

        private void ligneBus1CB_TextChanged(object sender, EventArgs e)
        {
            //Initialisation des comboBox des arrets
            arret1CB.Items.Clear();
            string sQuery = "select distinct nomGare from ligne_Arret,arret,ligneBus where ligneBus.numeroLigne=ligne_Arret.numeroLigne and ligne_Arret.numeroArret = arret.numeroArret and nomLigne ='" + ligneBus1CB.SelectedItem + "'";
            OracleCommand cmd = new OracleCommand(sQuery);
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                arret1CB.Items.Add(reader.GetOracleValue(0));
            }
        }
        


        private bool rechCorresp(int ligne1, int ligne2)
        {

            /*
             * 
             * Ne fonctionne pas
             * 
             * */
            bool b = false;
            string sQuery = "select numeroArret from ligne_Arret where numeroLigne ="+ ligne1;
            MessageBox.Show(sQuery);
            OracleCommand cmd = new OracleCommand(sQuery);
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            OracleDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                while (reader.Read())
                {
                    string sQuery1 = "select numeroLigne from ligne_Arret where numeroArret =" + Int32.Parse(reader.GetOracleValue(0).ToString());
                    OracleCommand cmd1 = new OracleCommand(sQuery1);
                    cmd1.Connection = con;
                    cmd1.CommandType = CommandType.Text;
                    OracleDataReader reader1 = cmd1.ExecuteReader();

                    while (reader1.Read())
                    {
                        if (Int32.Parse(reader1.GetOracleValue(0).ToString()) != ligne1)
                        {
                            if (Int32.Parse(reader1.GetOracleValue(0).ToString()) == ligne2)
                            {
                                b = true;
                            }
                            else
                            {
                                rechCorresp(Int32.Parse(reader1.GetOracleValue(0).ToString()), ligne2);
                            }
                        }
                    }
                }
            }
            else
            {
                b = false;
            }
            MessageBox.Show(b.ToString());
            
            return b;
        }

        private void rechercher1B_Click(object sender, EventArgs e)
        {
            int ligne1;
            int ligne2;

            string sQuery = "select numeroLigne from ligneBus where nomLigne='"+ ligneBusCB.SelectedItem + "'";

            // Instanciation de l'objet OracleCommand et de ses propriétés
            OracleCommand cmd = new OracleCommand(sQuery);
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            OracleDataReader reader = cmd.ExecuteReader();
            reader.Read();
            ligne1=Int32.Parse(reader.GetOracleValue(0).ToString());

            string sQuery1 = "select numeroLigne from ligneBus where nomLigne='" + ligneBus1CB.SelectedItem + "'";

            // Instanciation de l'objet OracleCommand et de ses propriétés
            OracleCommand cmd1 = new OracleCommand(sQuery1);
            cmd1.Connection = con;
            cmd1.CommandType = CommandType.Text;
            OracleDataReader reader1 = cmd1.ExecuteReader();


            reader1.Read();
            ligne2 = Int32.Parse(reader1.GetOracleValue(0).ToString());
            rechCorresp(ligne1, ligne2);
        }

        private void ligneTotemCB_TextChanged(object sender, EventArgs e)
        {
            //Initialisation des comboBox des arrets
            arretTotemCB.Items.Clear();
            string sQuery = "select distinct nomGare from ligne_Arret,arret,ligneBus where ligneBus.numeroLigne=ligne_Arret.numeroLigne and ligne_Arret.numeroArret = arret.numeroArret and nomLigne ='" + ligneTotemCB.SelectedItem + "'";
            OracleCommand cmd = new OracleCommand(sQuery);
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            OracleDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                arretTotemCB.Items.Add(reader.GetOracleValue(0));
            }
        }

        private void rechercherTotemB_Click(object sender, EventArgs e)
        {

            int heure=0;
            int minute1=0;
            int minuteMtn;
            int minute;
            int minuteMin=1000;
            string sQuery = "select heure,min from horaire,arret,ligneBus where arret.numeroArret=horaire.numeroArret and ligneBus.numeroLigne=horaire.numeroLigne and nomGare='"+ arretTotemCB.SelectedItem+"' and nomLigne='"+ligneTotemCB.SelectedItem+"'";

            OracleCommand cmd = new OracleCommand(sQuery);
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            OracleDataReader reader = cmd.ExecuteReader();

            MessageBox.Show(DateTime.Now.Hour + ":" + DateTime.Now.Minute);
            while (reader.Read())
            {
                minute =Int32.Parse(reader.GetOracleValue(0).ToString()) * 60 +Int32.Parse(reader.GetOracleValue(1).ToString());
                minuteMtn = DateTime.Now.Hour * 60 + DateTime.Now.Minute;

                if ((minute - minuteMtn) < minuteMin && (minute - minuteMtn) > 0)
                {
                    minuteMin = (minute - minuteMtn);
                    heure = Int32.Parse(reader.GetOracleValue(0).ToString());
                    minute1 = Int32.Parse(reader.GetOracleValue(1).ToString());
                }
            }
            if (minuteMin > 1)
            {
                TotemL.Text = "Le prochain passage est à " + heure + ":" + minute1 + " soit dans " + minuteMin + " minutes";
            }
            else
            {
                TotemL.Text = "Le prochain passage est à " + heure + ":" + minute1 + " soit dans " + minuteMin + " minute";
            }
            
            TotemL.Visible = true;
        }
    }
}
