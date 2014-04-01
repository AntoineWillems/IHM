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
    public partial class FicheHoraire1 : UserControl
    {
        
        private OracleConnection con;
        private List<heure> listheure ;

        public FicheHoraire1(int numeroArret,string semaine,int numeroLigne)
        {
            InitializeComponent();
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
            label18.Text = "";
            label19.Text = "";
            label20.Text = "";
            label21.Text = "";
            label22.Text = "";
            label23.Text = "";
            label24.Text = "";
            listheure = new List<heure>();
            con = new OracleConnection();
            con.ConnectionString = "User Id = aw269193; Password = aw269193; Data Source=//ufrsciencestech.u-bourgogne.fr:25562/L32012";
            //con.ConnectionString = "User Id = aw269193; Password = aw269193; Data Source=//stendhal:1521/L32012";
            con.Open();
            string sQuery = "Select heure,min, semaine from horaire where numeroArret=" + numeroArret + " and numeroLigne=" + numeroLigne + " order by semaine,heure,min";
            
            // Instanciation de l'objet OracleCommand et de ses propriétés
            OracleCommand cmd = new OracleCommand(sQuery);
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                listheure.Add(new heure(Int32.Parse(reader.GetOracleValue(0).ToString()),Int32.Parse(reader.GetOracleValue(1).ToString()),reader.GetString(2)));
                
            }
            foreach (heure h in listheure)
            {
                
                if (h.Semaine == semaine)
                {
                    switch (h.Heure)
                    {
                        case 1:
                            label1.Text += h.Minute.ToString() + "\n";
                            break;
                        case 2:
                            label2.Text += h.Minute.ToString() + "\n";
                            break;
                        case 3:
                            label3.Text += h.Minute.ToString() + "\n";
                            break;
                        case 4:
                            label4.Text += h.Minute.ToString() + "\n";
                            break;
                        case 5:
                            label5.Text += h.Minute.ToString() + "\n";
                            break;
                        case 6:
                            label6.Text += h.Minute.ToString() + "\n";
                            break;
                        case 7:
                            label7.Text += h.Minute.ToString() + "\n";
                            break;
                        case 8:
                            label8.Text += h.Minute.ToString() + "\n";
                            break;
                        case 9:
                            label9.Text += h.Minute.ToString() + "\n";
                            break;
                        case 10:
                            label10.Text += h.Minute.ToString() + "\n";
                            break;
                        case 11:
                            label11.Text += h.Minute.ToString() + "\n";
                            break;
                        case 12:
                            label12.Text += h.Minute.ToString() + "\n";
                            break;
                        case 13:
                            label13.Text += h.Minute.ToString() + "\n";
                            break;
                        case 14:
                            label14.Text += h.Minute.ToString() + "\n";
                            break;
                        case 15:
                            label15.Text += h.Minute.ToString() + "\n";
                            break;
                        case 16:
                            label16.Text += h.Minute.ToString() + "\n";
                            break;
                        case 17:
                            label17.Text += h.Minute.ToString() + "\n";
                            break;
                        case 18:
                            label18.Text += h.Minute.ToString() + "\n";
                            break;
                        case 19:
                            label19.Text += h.Minute.ToString() + "\n";
                            break;
                        case 20:
                            label20.Text += h.Minute.ToString() + "\n";
                            break;
                        case 21:
                            label20.Text += h.Minute.ToString() + "\n";
                            break;
                        case 22:
                            label22.Text += h.Minute.ToString() + "\n";
                            break;
                        case 23:
                            label23.Text += h.Minute.ToString() + "\n";
                            break;
                        case 24:
                            label24.Text += h.Minute.ToString() + "\n";
                            break;
                    }
                }
            }
            
        }
    }
}
