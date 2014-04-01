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
    public partial class ModifLigne : Form
    {
        private OracleConnection con;
        private OracleTransaction trans;
        private int ligneBus;
        private int arret;
        private int maxPlacement;

        public ModifLigne()
        {
            InitializeComponent();
            this.Text = "Modification d'une ligne";
            semaineCB.SelectedItem = "Lundi au Vendredi";
            semaineCB.DropDownStyle = ComboBoxStyle.DropDownList;
            ligneCorrespCB.DropDownStyle = ComboBoxStyle.DropDownList;
            arretCorrespCB.DropDownStyle = ComboBoxStyle.DropDownList;
            arretHeureCB.DropDownStyle = ComboBoxStyle.DropDownList;
            ligneHeureCB.DropDownStyle = ComboBoxStyle.DropDownList;

            con = new OracleConnection();
            con.ConnectionString = "User Id = aw269193; Password = aw269193; Data Source=//ufrsciencestech.u-bourgogne.fr:25562/L32012";
            //con.ConnectionString = "User Id = aw269193; Password = aw269193; Data Source=//stendhal:1521/L32012";
            con.Open();

            string sQuery = "Select nomLigne from ligneBus";

            OracleCommand cmd = new OracleCommand(sQuery);
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            OracleDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                ligneBusCB.Items.Add(reader.GetString(0));
                ligneHeureCB.Items.Add(reader.GetString(0));
            }

        }

        private void modifLigneB_Click(object sender, EventArgs e)
        {
            trans = con.BeginTransaction();
            string sQuery2 = "UPDATE ligneBus set nomLigne ='" + ligneTB.Text +"' where nomLigne='" + ligneBusCB.SelectedItem+"'";
            OracleCommand cmd2 = new OracleCommand(sQuery2, con);
            cmd2.CommandType = CommandType.Text;
            cmd2.Transaction = trans;

            try
            {
                cmd2.ExecuteNonQuery();
                trans.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.ToString());
                trans.Rollback();
            }
            finally
            {
                cmd2.Dispose();
            }

            ligneBusCB.Items.Clear();
            string sQuery = "Select nomLigne from ligneBus";

            OracleCommand cmd = new OracleCommand(sQuery);
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            OracleDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                ligneBusCB.Items.Add(reader.GetString(0));

            }
        }

        private void supprLigneBus_Click(object sender, EventArgs e)
        {
            string sQuery = "Select numeroLigne from ligneBus where nomLigne='"+ligneBusCB.SelectedItem+"'";

            OracleCommand cmd = new OracleCommand(sQuery);
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            OracleDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                ligneBus = Int32.Parse(reader.GetOracleValue(0).ToString());

            }


            trans = con.BeginTransaction();
            string sQuery1 = "DELETE FROM horaire where numeroLigne=" + ligneBus;
            OracleCommand cmd1 = new OracleCommand(sQuery1, con);
            cmd1.CommandType = CommandType.Text;
            cmd1.Transaction = trans;

            try
            {
                cmd1.ExecuteNonQuery();
                trans.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.ToString());
                trans.Rollback();
            }
            finally
            {
                cmd1.Dispose();
            }

            trans = con.BeginTransaction();
            string sQuery2 = "DELETE FROM ligne_Arret where numeroLigne=" + ligneBus;
            OracleCommand cmd2 = new OracleCommand(sQuery2, con);
            cmd2.CommandType = CommandType.Text;
            cmd2.Transaction = trans;

            try
            {
                cmd2.ExecuteNonQuery();
                trans.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.ToString());
                trans.Rollback();
            }
            finally
            {
                cmd2.Dispose();
            }

            trans = con.BeginTransaction();
            string sQuery3 = "DELETE FROM ligneBus where nomLigne='" + ligneBusCB.SelectedItem + "'";
            OracleCommand cmd3 = new OracleCommand(sQuery3, con);
            cmd3.CommandType = CommandType.Text;
            cmd3.Transaction = trans;

            try
            {
                cmd3.ExecuteNonQuery();
                trans.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.ToString());
                trans.Rollback();
            }
            finally
            {
                cmd3.Dispose();
            }


            ligneBusCB.Items.Clear();
            string sQuery4 = "Select nomLigne from ligneBus";

            OracleCommand cmd4 = new OracleCommand(sQuery4);
            cmd4.Connection = con;
            cmd4.CommandType = CommandType.Text;
            OracleDataReader reader4 = cmd4.ExecuteReader();


            while (reader4.Read())
            {
                ligneBusCB.Items.Add(reader4.GetString(0));

            }
        }

        private void ajouterCorresB_Click(object sender, EventArgs e)
        {
            string sQuery4 = "Select numeroLigne from ligneBus where nomLigne='" + ligneCorrespCB.SelectedItem + "'";

            OracleCommand cmd4 = new OracleCommand(sQuery4);
            cmd4.Connection = con;
            cmd4.CommandType = CommandType.Text;
            OracleDataReader reader4 = cmd4.ExecuteReader();


            while (reader4.Read())
            {
                ligneBus = Int32.Parse(reader4.GetOracleValue(0).ToString());
            }

            string sQuery1 = "Select numeroArret from arret where nomGare='" + arretCorrespCB.SelectedItem + "'";

            OracleCommand cmd1 = new OracleCommand(sQuery1);
            cmd1.Connection = con;
            cmd1.CommandType = CommandType.Text;
            OracleDataReader reader1 = cmd1.ExecuteReader();


            while (reader1.Read())
            {
                arret = Int32.Parse(reader1.GetOracleValue(0).ToString());
            }

            string sQuery2 = "Select max(Placement) from ligne_Arret where numeroLigne=" + ligneBus;

            OracleCommand cmd2 = new OracleCommand(sQuery2);
            cmd2.Connection = con;
            cmd2.CommandType = CommandType.Text;
            OracleDataReader reader2 = cmd2.ExecuteReader();


            while (reader2.Read())
            {
                maxPlacement = Int32.Parse(reader2.GetOracleValue(0).ToString()) + 1;
            }

            string sQuery6 = "INSERT INTO ligne_Arret VALUES (" + ligneBus + "," + arret + "," + maxPlacement + ")";

            trans = con.BeginTransaction();
            OracleCommand cmd6 = new OracleCommand(sQuery6, con);
            cmd6.CommandType = CommandType.Text;
            cmd6.Transaction = trans;

            try
            {
                cmd6.ExecuteNonQuery();
                trans.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.ToString());
                trans.Rollback();
            }
            finally
            {
                cmd6.Dispose();
            }
        }

        private void ajoutArretB_Click(object sender, EventArgs e)
        {

            string sQuery4 = "Select numeroLigne from ligneBus where nomLigne='"+ligneBusCB.SelectedItem+"'";

            OracleCommand cmd4 = new OracleCommand(sQuery4);
            cmd4.Connection = con;
            cmd4.CommandType = CommandType.Text;
            OracleDataReader reader4 = cmd4.ExecuteReader();


            while (reader4.Read())
            {
                ligneBus = Int32.Parse(reader4.GetOracleValue(0).ToString());
            }

            string sQuery1 = "INSERT INTO arret(nomGare) VALUES ( '" + ajoutArretTB.Text+ "')";
            trans = con.BeginTransaction();
            OracleCommand cmd1 = new OracleCommand(sQuery1, con);
            cmd1.CommandType = CommandType.Text;
            cmd1.Transaction = trans;

            try
            {
                cmd1.ExecuteNonQuery();
                trans.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.ToString());
                trans.Rollback();
            }
            finally
            {
                cmd1.Dispose();
            }



            string s1 = "select MaSequence1.currval from dual";

            OracleCommand cmd5 = new OracleCommand(s1);
            cmd5.Connection = con;
            cmd5.CommandType = CommandType.Text;
            OracleDataReader reader5 = cmd5.ExecuteReader();
            reader5.Read();
            arret = Int32.Parse(reader5.GetOracleValue(0).ToString());

            string sQuery2 = "Select max(Placement) from ligne_Arret where numeroLigne=" + ligneBus;

            OracleCommand cmd2 = new OracleCommand(sQuery2);
            cmd2.Connection = con;
            cmd2.CommandType = CommandType.Text;
            OracleDataReader reader2 = cmd2.ExecuteReader();


            while (reader2.Read())
            {
                maxPlacement = Int32.Parse(reader2.GetOracleValue(0).ToString()) +1 ;
            }



            string sQuery6 = "INSERT INTO ligne_Arret VALUES (" + ligneBus + "," + arret+ "," + maxPlacement + ")";

            trans = con.BeginTransaction();
            OracleCommand cmd6 = new OracleCommand(sQuery6, con);
            cmd6.CommandType = CommandType.Text;
            cmd6.Transaction = trans;

            try
            {
                cmd6.ExecuteNonQuery();
                trans.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.ToString());
                trans.Rollback();
            }
            finally
            {
                cmd6.Dispose();
            }
        }

        private void ajouterHeureB_Click(object sender, EventArgs e)
        {
            string sQuery = "select numeroLigne from ligneBus where nomLigne='"+ligneHeureCB.SelectedItem+"'";

            OracleCommand cmd = new OracleCommand(sQuery);
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            OracleDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                ligneBus = Int32.Parse(reader.GetOracleValue(0).ToString());
            }

            string sQuery1 = "select numeroArret from arret where nomGare='" + arretHeureCB.SelectedItem + "'";

            OracleCommand cmd1 = new OracleCommand(sQuery1);
            cmd1.Connection = con;
            cmd1.CommandType = CommandType.Text;
            OracleDataReader reader1 = cmd1.ExecuteReader();


            while (reader1.Read())
            {
                arret = Int32.Parse(reader1.GetOracleValue(0).ToString());
            }


            string sQuery6 = "INSERT INTO horaire VALUES (" + heure1NUD.Value + "," + heure2NUD.Value+ ",'" + semaineCB.SelectedItem+ "',"+arret+","+ligneBus+")";

            trans = con.BeginTransaction();
            OracleCommand cmd6 = new OracleCommand(sQuery6, con);
            cmd6.CommandType = CommandType.Text;
            cmd6.Transaction = trans;

            try
            {
                cmd6.ExecuteNonQuery();
                trans.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.ToString());
                trans.Rollback();
            }
            finally
            {
                cmd6.Dispose();
            }
        }


        private void ligneBusCB_TextChanged(object sender, EventArgs e)
        {
            arretCB.Items.Clear();
            arretHeureCB.Items.Clear();
            string sQuery = "select distinct nomGare from ligne_Arret,arret,ligneBus where ligneBus.numeroLigne=ligne_Arret.numeroLigne and ligne_Arret.numeroArret = arret.numeroArret and nomLigne ='" + ligneBusCB.SelectedItem + "'";

            OracleCommand cmd = new OracleCommand(sQuery);
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            OracleDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                arretCB.Items.Add(reader.GetOracleValue(0));
                arretHeureCB.Items.Add(reader.GetString(0));
            }
        }

    

        private void modifArretB_Click(object sender, EventArgs e)
        {
            trans = con.BeginTransaction();
            string sQuery2 = "UPDATE arret set nomGare ='" + arretTB.Text +"' where nomGare='" + arretCB.SelectedItem+"'";
            OracleCommand cmd2 = new OracleCommand(sQuery2, con);
            cmd2.CommandType = CommandType.Text;
            cmd2.Transaction = trans;

            try
            {
                cmd2.ExecuteNonQuery();
                trans.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.ToString());
                trans.Rollback();
            }
            finally
            {
                cmd2.Dispose();
            }

            arretCB.Items.Clear();
            arretHeureCB.Items.Clear();
            string sQuery = "Select nomGare from arret,ligneBus,ligne_Arret where arret.numeroArret=ligne_Arret.numeroArret and ligneBus.numeroLigne=ligne_Arret.numeroLigne and nomLigne='"+ligneBusCB.SelectedItem+"'";

            OracleCommand cmd = new OracleCommand(sQuery);
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            OracleDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                arretCB.Items.Add(reader.GetString(0));
                arretHeureCB.Items.Add(reader.GetString(0));
            }

        }

        private void ligneHeureCB_TextChanged(object sender, EventArgs e)
        {
            arretHeureCB.Items.Clear();
            string sQuery = "select  nomGare from ligne_Arret,arret,ligneBus where ligneBus.numeroLigne=ligne_Arret.numeroLigne and ligne_Arret.numeroArret = arret.numeroArret and nomLigne ='" + ligneHeureCB.SelectedItem + "'";

            OracleCommand cmd = new OracleCommand(sQuery);
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            OracleDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                arretHeureCB.Items.Add(reader.GetOracleValue(0));
            }
        }

       
    }
}
