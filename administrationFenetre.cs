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
    public partial class administrationFenetre : Form
    {
        private OracleConnection con;
        private OracleTransaction trans;

        public administrationFenetre()
        {
            InitializeComponent();
            this.Text = "Gestion des utilisateurs";
            con = new OracleConnection();
            con.ConnectionString = "User Id = aw269193; Password = aw269193; Data Source=//ufrsciencestech.u-bourgogne.fr:25562/L32012";
            //con.ConnectionString = "User Id = aw269193; Password = aw269193; Data Source=//stendhal:1521/L32012";
            con.Open();
            string sQuery = "Select pseudo,mdp from utilisateur where administrateur='N'";
            
            // Instanciation de l'objet OracleCommand et de ses propriétés
            OracleCommand cmd = new OracleCommand(sQuery);
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            OracleDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader.GetString(0), reader.GetString(1), false);
            }
        }

        private void ajoutAdmin_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if ((bool) dataGridView1.Rows[i].Cells[2].Value == true)
                {
                    trans = con.BeginTransaction();
                    string sQuery2 = "UPDATE utilisateur set administrateur='Y' where pseudo='" + dataGridView1.Rows[i].Cells[0].Value + "' and mdp ='" + dataGridView1.Rows[i].Cells[1].Value + "'";
                    
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
                }
            }
            this.Close();
        }
    }
}
