using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Common;
using Oracle.DataAccess.Client;
namespace IHM
{
    public partial class ArretUserControl : UserControl
    {
        private OracleConnection con;
        private List<heure> listheure = new List<heure>();
        private int numeroLigneArret;
        private int maxValue;

        public ArretUserControl(int numeroArret, int numeroLigne)
        {
            InitializeComponent();
            
            con = new OracleConnection();
            con.ConnectionString = "User Id = aw269193; Password = aw269193; Data Source=//ufrsciencestech.u-bourgogne.fr:25562/L32012";
            //con.ConnectionString = "User Id = aw269193; Password = aw269193; Data Source=//stendhal:1521/L32012";
            con.Open();
            
            string sQuery = "Select nomGare,placement  from arret,ligne_Arret where arret.numeroArret=ligne_Arret.numeroArret and ligne_Arret.numeroArret=" + numeroArret + " and ligne_Arret.numeroligne=" + numeroLigne;
            string sQuery1 = "Select nomLigne,ligneBus.numeroLigne from ligneBus,arret,ligne_Arret where arret.numeroArret=ligne_Arret.numeroArret and ligneBus.numeroLigne=ligne_Arret.numeroLigne and arret.nomGare =(Select distinct nomGare from arret where numeroArret="+ numeroArret+")" ;
            
            string sQuery2 = "Select max(placement) from ligne_Arret where numeroLigne="+numeroLigne;
            // Instanciation de l'objet OracleCommand et de ses propriétés
            OracleCommand cmd = new OracleCommand(sQuery);
            OracleCommand cmd1 = new OracleCommand(sQuery1);
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                nomArretL.Text = reader.GetString(0);
                numeroLigneArret = Int32.Parse(reader.GetOracleValue(1).ToString());
            }

            cmd1.Connection = con;
            cmd1.CommandType = CommandType.Text;
            OracleDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                if (Int32.Parse(reader1.GetOracleValue(1).ToString()) != numeroLigne)
                {
                    corresp.Text += reader1.GetString(0) + "\n";
                }
            }
            OracleCommand cmd2 = new OracleCommand(sQuery2);
            cmd2.Connection = con;
            cmd2.CommandType = CommandType.Text;
            OracleDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                maxValue = Int32.Parse(reader2.GetOracleValue(0).ToString());
            }

        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (numeroLigneArret != 1)
            {
                g.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, 8), new Point(50, 8));
            }
            
            g.DrawEllipse(new Pen(new SolidBrush(Color.Black)), new Rectangle(50, 6, 6, 6));
            if (numeroLigneArret != maxValue)
            {
                g.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(56, 8), new Point(121, 8));
            }
        }
    }
}
