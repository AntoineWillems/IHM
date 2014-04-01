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
    public partial class AjoutLigne : Form
    {
        private OracleConnection con;
        private List<arret> listArret= new List<arret>();
        private List<arret> listArretCorresp = new List<arret>();
        private OracleTransaction trans;
        private int cpt = 1;
        public AjoutLigne()
        {
            InitializeComponent();
            //Changement du titre de la fenêtre
            this.Text = "Ajout d'une ligne";
            //Initialisation des comboBox
            semaineCB.SelectedItem="Lundi au Vendredi";
            semaineCB.DropDownStyle = ComboBoxStyle.DropDownList;
            ligneCorrespCB.DropDownStyle = ComboBoxStyle.DropDownList;
            arretCorrespCB.DropDownStyle = ComboBoxStyle.DropDownList;
            arretCB.DropDownStyle = ComboBoxStyle.DropDownList;

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
                ligneCorrespCB.Items.Add(reader.GetString(0));
            }
        }

        private void ajoutArretB_Click(object sender, EventArgs e)
        {
            
            string sQuery = "Select nomGare,nomLigne from arret,ligneBus,ligne_Arret where ligne_Arret.numeroLigne=ligneBus.numeroLigne and ligne_Arret.numeroArret=arret.numeroArret and nomGare='" + arretTB.Text + "'";
           
            OracleCommand cmd = new OracleCommand(sQuery);
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            OracleDataReader reader = cmd.ExecuteReader();
            
            //Teste si l'arret existe déjà
            if (reader.Read())
            {
               MessageBox.Show("L'arret " + reader.GetString(0) +" existe déjà dans la ligne "+ reader.GetString(1) + " \n Veuillez le saisir dans arret avec correspondance");
            }
            else
            {
                // S'il n'existe pas on l'ajoute à la comboBox et à la liste d'arret
                arretCB.Items.Add(arretTB.Text);
                arret ar = new arret(cpt, arretTB.Text);
                listArret.Add(ar);
                arretTB.Text = "";
                cpt++;
            }
            
            
        }

        private void ajoutLigneB_Click(object sender, EventArgs e)
        {
            trans = con.BeginTransaction();
            string sQuery2 = "INSERT INTO ligneBus(nomLigne) VALUES('" + nomLigneTB.Text + "')";
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
                foreach (arret ar in listArret)
                {
                    string s = "select MaSequence.currval from dual";

                    
                    // Instanciation de l'objet OracleCommand et de ses propriétés
                    OracleCommand cmd4 = new OracleCommand(s);
                    cmd4.Connection = con;
                    cmd4.CommandType = CommandType.Text;
                    OracleDataReader reader = cmd4.ExecuteReader();
                    reader.Read();
                    ar.NumeroLigne = Int32.Parse(reader.GetOracleValue(0).ToString());
                    
                    string sQuery1 = "INSERT INTO arret(nomGare) VALUES ( '" + ar.NomArret + "')";
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


                    // Instanciation de l'objet OracleCommand et de ses propriétés
                    OracleCommand cmd5 = new OracleCommand(s1);
                    cmd5.Connection = con;
                    cmd5.CommandType = CommandType.Text;
                    OracleDataReader reader1 = cmd5.ExecuteReader();
                    reader1.Read();
                    ar.NumeroArret = Int32.Parse(reader1.GetOracleValue(0).ToString());


                    string sQuery6 = "INSERT INTO ligne_Arret VALUES (" + ar.NumeroLigne + "," + ar.NumeroArret + "," + ar.NumeroLigneArret + ")";
                   
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
                     

                  
                        foreach (heure h in ar.ListeHeure)
                        {
                            trans = con.BeginTransaction();
                            string sQuery3 = "INSERT INTO horaire VALUES (" + h.Heure + ", " + h.Minute + ",'" + h.Semaine + "'," + ar.NumeroArret + ","+ ar.NumeroLigne+")";
                            
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
                        }
               }

                foreach (arret ar in listArretCorresp)
                {
                    string s = "select MaSequence.currval from dual";


                    // Instanciation de l'objet OracleCommand et de ses propriétés
                    OracleCommand cmd4 = new OracleCommand(s);
                    cmd4.Connection = con;
                    cmd4.CommandType = CommandType.Text;
                    OracleDataReader reader = cmd4.ExecuteReader();
                    reader.Read();
                    ar.NumeroLigne = Int32.Parse(reader.GetOracleValue(0).ToString());

                    string sQuery6 = "INSERT INTO ligne_Arret VALUES (" + ar.NumeroLigne + "," + ar.NumeroArret + "," + ar.NumeroLigneArret + ")";

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



                    foreach (heure h in ar.ListeHeure)
                    {
                        trans = con.BeginTransaction();
                        string sQuery3 = "INSERT INTO horaire VALUES (" + h.Heure + ", " + h.Minute + ",'" + h.Semaine + "'," + ar.NumeroArret + "," + ar.NumeroLigne + ")";
                        MessageBox.Show(sQuery3);
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
                    }
                  
                }

          
                this.Close();
        }

        private void ajouterHeureB_Click(object sender, EventArgs e)
        {
            //Pour chaque arret simple on ajoute l'heure à la liste d'heure de l'arret
            foreach(arret ar1 in listArret)
            {
                if(ar1.NomArret == arretCB.SelectedItem.ToString())
                {

                    ar1.ListeHeure.Add(new heure(Int32.Parse(heure1NUD.Value.ToString()), Int32.Parse(heure2NUD.Value.ToString()), semaineCB.SelectedItem.ToString()));
                                        
                }
            }
            //Pour chaque arret avec correspondance on ajoute l'heure à la liste d'heure de l'arret
            foreach (arret ar1 in listArretCorresp)
            {
                if (ar1.NomArret == arretCB.SelectedItem.ToString())
                {

                    ar1.ListeHeure.Add(new heure(Int32.Parse(heure1NUD.Value.ToString()), Int32.Parse(heure2NUD.Value.ToString()), semaineCB.SelectedItem.ToString()));

                }
            }
            // On ajoute l'heure à la comboBox
            HeureCB.Items.Add(heure1NUD.Value + ":" + heure2NUD.Value + "   " + semaineCB.SelectedItem);
            heure1NUD.Value = 0;
            heure2NUD.Value = 0;
        }

        private void arretCB_TextChanged(object sender, EventArgs e)
        {
            //Initialisation des comboBox des arrets
            HeureCB.Items.Clear();
            foreach (arret ar1 in listArret)
            {
                if (ar1.NomArret == arretCB.SelectedItem.ToString())
                {                    
                    foreach (heure heure in ar1.ListeHeure)
                    {
                        HeureCB.Items.Add(heure.Heure+":"+heure.Minute+"  " + heure.Semaine);
                    }

                }
            }
        }

        private void ajouterCorresB_Click(object sender, EventArgs e)
        {
            arret ar = new arret(cpt, arretCorrespCB.SelectedItem.ToString());
            
            arretCB.Items.Add(arretCorrespCB.SelectedItem);
            cpt++;
            string sQuery = "select ligneBus.numeroLigne,arret.numeroArret from ligneBus,arret,ligne_Arret where ligneBus.numeroLigne=ligne_Arret.numeroLigne and arret.numeroArret = ligne_Arret.numeroArret and nomLigne ='" + ligneCorrespCB.SelectedItem + "' and nomGare='"+arretCorrespCB.SelectedItem+"'";
            MessageBox.Show(sQuery);
            // Instanciation de l'objet OracleCommand et de ses propriétés
            OracleCommand cmd = new OracleCommand(sQuery);
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            OracleDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                
                ligneCorrespCB.Items.Add(reader.GetOracleValue(0));
                ar.NumeroArret = Int32.Parse(reader.GetOracleValue(1).ToString());
            }
            listArretCorresp.Add(ar);
        }

        
        private void ligneCorrespCB_TextChanged(object sender, EventArgs e)
        {
            //Initialisation des comboBox des arrets
            arretCorrespCB.Items.Clear();
            string sQuery = "select distinct nomGare from ligne_Arret,arret,ligneBus where ligneBus.numeroLigne=ligne_Arret.numeroLigne and arret.numeroArret=ligne_Arret.numeroArret and nomLigne ='" + ligneCorrespCB.SelectedItem + "'";
          
            OracleCommand cmd = new OracleCommand(sQuery);
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            OracleDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                arretCorrespCB.Items.Add(reader.GetOracleValue(0));
            }
        }
    }
}
