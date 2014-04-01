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
    public partial class Connexion : Form
    {
        private OracleConnection con;
        private OracleTransaction trans;
        private Button ajouter;
        private Button modifier;
        private Button administration;

        public Connexion()
        {
         
            
            con = new OracleConnection();
            con.ConnectionString = "User Id = aw269193; Password = aw269193; Data Source=//ufrsciencestech.u-bourgogne.fr:25562/L32012";
            //con.ConnectionString = "User Id = aw269193; Password = aw269193; Data Source=//stendhal:1521/L32012";
            con.Open();
           
            InitializeComponent();
            this.Text = "Connexion";
            
        }

        private void connexionB_Click(object sender, EventArgs e)
        {
            
            string sQuery = "Select administrateur from utilisateur where pseudo ='" + identifiantTB.Text + "' and mdp='" + mdpTB.Text+"'";
            
            // Instanciation de l'objet OracleCommand et de ses propriétés
            OracleCommand cmd = new OracleCommand(sQuery);
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            OracleDataReader reader = cmd.ExecuteReader();

            
            while (reader.Read())
            {
                if (reader.HasRows && reader.GetString(0) == "Y")
                {
                    panel1.Visible = false;
                    panel2.Visible = false;
                    deconnexionB.Visible = true;
                    ajouter = new Button();
                    modifier = new Button();
                    administration = new Button();
                    ajouter.Text = "Ajouter";
                    modifier.Text = "Modifier";
                    administration.Text = "Administration";
                    ajouter.Location = new Point(50, 150);
                    administration.Location = new Point(90, 200);
                    ajouter.Click += new EventHandler(ajouter_Click);
                    modifier.Click += new EventHandler(modifier_Click);
                    administration.Click += new EventHandler(administration_Click);
                    modifier.Location = new Point(180, 150);
                    label3.Location = new Point(80, 19);
                    label3.Text = "Administration";
                    this.Controls.Add(ajouter);
                    this.Controls.Add(modifier);
                    this.Controls.Add(administration);
                }
                else if (reader.HasRows && reader.GetString(0) == "N")
                {
                    RechIteneraire ri = new RechIteneraire();
                    ri.Show();
                }
             }
            if (reader.HasRows == false)
            {
                erreurL.ForeColor=Color.Red;
                erreurL.Text = "Erreur Identifiant/mdp";
            }
        }

        void administration_Click(object sender, EventArgs e)
        {
            administrationFenetre aF = new administrationFenetre();
            aF.Show();
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            AjoutLigne al = new AjoutLigne();
            al.Show();
        }
        private void modifier_Click(object sender, EventArgs e)
        {
            ModifLigne ml = new ModifLigne();
            ml.Show();
        }

        private void nouvUtiliB_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void creerCompteB_Click(object sender, EventArgs e)
        {
            trans = con.BeginTransaction();

            string sQuery2 = "INSERT INTO utilisateur VALUES ( '"+identifiant1TB.Text+"', '" + mdp1TB.Text + "','N')";

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
            RechIteneraire ri = new RechIteneraire();
            ri.Show();
        }

        private void deconnexionB_Click(object sender, EventArgs e)
        {
            panel2.Visible=true;
            ajouter.Visible = false;
            modifier.Visible = false;
            administration.Visible = false;
            deconnexionB.Visible = false;
            label3.Location = new Point(124, 19);
            label3.Text = "Divia";
        }

        

      
    }
}
