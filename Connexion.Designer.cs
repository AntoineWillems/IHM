namespace IHM
{
    partial class Connexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.connexionB = new System.Windows.Forms.Button();
            this.identifiantTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mdpTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.creerCompteB = new System.Windows.Forms.Button();
            this.mdp1TB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.identifiant1TB = new System.Windows.Forms.TextBox();
            this.nouvUtiliB = new System.Windows.Forms.Button();
            this.erreurL = new System.Windows.Forms.Label();
            this.deconnexionB = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // connexionB
            // 
            this.connexionB.Location = new System.Drawing.Point(83, 79);
            this.connexionB.Name = "connexionB";
            this.connexionB.Size = new System.Drawing.Size(67, 27);
            this.connexionB.TabIndex = 0;
            this.connexionB.Text = "Connexion";
            this.connexionB.UseVisualStyleBackColor = true;
            this.connexionB.Click += new System.EventHandler(this.connexionB_Click);
            // 
            // identifiantTB
            // 
            this.identifiantTB.Location = new System.Drawing.Point(108, 3);
            this.identifiantTB.Name = "identifiantTB";
            this.identifiantTB.Size = new System.Drawing.Size(82, 20);
            this.identifiantTB.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Identifiant:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mot de passe:";
            // 
            // mdpTB
            // 
            this.mdpTB.Location = new System.Drawing.Point(108, 35);
            this.mdpTB.Name = "mdpTB";
            this.mdpTB.Size = new System.Drawing.Size(80, 20);
            this.mdpTB.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Divia";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.creerCompteB);
            this.panel1.Controls.Add(this.mdp1TB);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.identifiant1TB);
            this.panel1.Location = new System.Drawing.Point(24, 215);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 76);
            this.panel1.TabIndex = 9;
            this.panel1.Visible = false;
            // 
            // creerCompteB
            // 
            this.creerCompteB.Location = new System.Drawing.Point(192, 20);
            this.creerCompteB.Name = "creerCompteB";
            this.creerCompteB.Size = new System.Drawing.Size(52, 44);
            this.creerCompteB.TabIndex = 14;
            this.creerCompteB.Text = "Creer compte";
            this.creerCompteB.UseVisualStyleBackColor = true;
            this.creerCompteB.Click += new System.EventHandler(this.creerCompteB_Click);
            // 
            // mdp1TB
            // 
            this.mdp1TB.Location = new System.Drawing.Point(96, 45);
            this.mdp1TB.Name = "mdp1TB";
            this.mdp1TB.Size = new System.Drawing.Size(80, 20);
            this.mdp1TB.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mot de passe:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Identifiant:";
            // 
            // identifiant1TB
            // 
            this.identifiant1TB.Location = new System.Drawing.Point(96, 13);
            this.identifiant1TB.Name = "identifiant1TB";
            this.identifiant1TB.Size = new System.Drawing.Size(82, 20);
            this.identifiant1TB.TabIndex = 10;
            // 
            // nouvUtiliB
            // 
            this.nouvUtiliB.Location = new System.Drawing.Point(59, 119);
            this.nouvUtiliB.Name = "nouvUtiliB";
            this.nouvUtiliB.Size = new System.Drawing.Size(111, 23);
            this.nouvUtiliB.TabIndex = 0;
            this.nouvUtiliB.Text = "Nouvel utilisateur";
            this.nouvUtiliB.UseVisualStyleBackColor = true;
            this.nouvUtiliB.Click += new System.EventHandler(this.nouvUtiliB_Click);
            // 
            // erreurL
            // 
            this.erreurL.AutoSize = true;
            this.erreurL.Location = new System.Drawing.Point(162, 84);
            this.erreurL.Name = "erreurL";
            this.erreurL.Size = new System.Drawing.Size(0, 13);
            this.erreurL.TabIndex = 10;
            // 
            // deconnexionB
            // 
            this.deconnexionB.Location = new System.Drawing.Point(206, 277);
            this.deconnexionB.Name = "deconnexionB";
            this.deconnexionB.Size = new System.Drawing.Size(86, 22);
            this.deconnexionB.TabIndex = 11;
            this.deconnexionB.Text = "Deconnexion";
            this.deconnexionB.UseVisualStyleBackColor = true;
            this.deconnexionB.Visible = false;
            this.deconnexionB.Click += new System.EventHandler(this.deconnexionB_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.erreurL);
            this.panel2.Controls.Add(this.nouvUtiliB);
            this.panel2.Controls.Add(this.mdpTB);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.identifiantTB);
            this.panel2.Controls.Add(this.connexionB);
            this.panel2.Location = new System.Drawing.Point(31, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 148);
            this.panel2.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 311);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.deconnexionB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connexionB;
        private System.Windows.Forms.TextBox identifiantTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mdpTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox mdp1TB;
        private System.Windows.Forms.Button nouvUtiliB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox identifiant1TB;
        private System.Windows.Forms.Label erreurL;
        private System.Windows.Forms.Button creerCompteB;
        private System.Windows.Forms.Button deconnexionB;
        private System.Windows.Forms.Panel panel2;
    }
}

