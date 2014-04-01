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
    public partial class ficheHoraireFenetre : Form
    {
        private OracleConnection con;
        
        public ficheHoraireFenetre(int numeroLigne,int numeroArret)
        {
            InitializeComponent();
            this.Text = "Consultation d'une ligne";
            con = new OracleConnection();
            con.ConnectionString = "User Id = aw269193; Password = aw269193; Data Source=//ufrsciencestech.u-bourgogne.fr:25562/L32012";
            //con.ConnectionString = "User Id = aw269193; Password = aw269193; Data Source=//stendhal:1521/L32012";
            con.Open();
            string sQuery = "Select arret.numeroArret,ligne_Arret.placement from arret,ligne_Arret where arret.numeroArret = ligne_Arret.numeroArret and ligne_Arret.numeroLigne =" + numeroLigne;

            // Instanciation de l'objet OracleCommand et de ses propriétés
            OracleCommand cmd = new OracleCommand(sQuery);
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            OracleDataReader reader = cmd.ExecuteReader();
            List<arret> listArret = new List<arret>();
            while (reader.Read())
            {

                int numeroArret1 = Int32.Parse(reader.GetOracleValue(0).ToString());
                int numeroArretLigne = Int32.Parse(reader.GetOracleValue(1).ToString());
                arret ar = new arret(numeroLigne, numeroArret1, numeroArretLigne);
                listArret.Add(ar);
            }
            foreach (arret arret1 in listArret)
            {
                ArretUserControl ar = new ArretUserControl(arret1.NumeroArret, numeroLigne);
                ar.Location = new Point(arret1.NumeroLigneArret * 119, 0);
                panel1.Controls.Add(ar);
            }

            FicheHoraire fh = new FicheHoraire(numeroArret, numeroLigne);
            panel2.Controls.Add(fh);



             string sQuery1 = "Select nomLigne from ligneBus where ligneBus.numeroLigne =" + numeroLigne;

            // Instanciation de l'objet OracleCommand et de ses propriétés
            OracleCommand cmd1 = new OracleCommand(sQuery1);
            cmd1.Connection = con;
            cmd1.CommandType = CommandType.Text;
            OracleDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                label1.Text += reader1.GetString(0);
            }

            string sQuery2 = "Select nomGare from arret where numeroArret =" + numeroArret;

            // Instanciation de l'objet OracleCommand et de ses propriétés
            OracleCommand cmd2 = new OracleCommand(sQuery2);
            cmd2.Connection = con;
            cmd2.CommandType = CommandType.Text;
            OracleDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                arretL.Text += reader2.GetString(0);
            }
        }
    }
}
