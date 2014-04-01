namespace IHM
{
    partial class AjoutLigne
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.nomLigneTB = new System.Windows.Forms.TextBox();
            this.ajoutLigneB = new System.Windows.Forms.Button();
            this.arretCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.HeureCB = new System.Windows.Forms.ComboBox();
            this.ajouterHeureB = new System.Windows.Forms.Button();
            this.semaineCB = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.arretTB = new System.Windows.Forms.TextBox();
            this.ajoutArretB = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ajouterCorresB = new System.Windows.Forms.Button();
            this.arretCorrespCB = new System.Windows.Forms.ComboBox();
            this.ligneCorrespCB = new System.Windows.Forms.ComboBox();
            this.heure1NUD = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.heure2NUD = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heure1NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heure2NUD)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom ligne:";
            // 
            // nomLigneTB
            // 
            this.nomLigneTB.Location = new System.Drawing.Point(369, 58);
            this.nomLigneTB.Name = "nomLigneTB";
            this.nomLigneTB.Size = new System.Drawing.Size(75, 20);
            this.nomLigneTB.TabIndex = 1;
            // 
            // ajoutLigneB
            // 
            this.ajoutLigneB.Location = new System.Drawing.Point(325, 469);
            this.ajoutLigneB.Name = "ajoutLigneB";
            this.ajoutLigneB.Size = new System.Drawing.Size(99, 20);
            this.ajoutLigneB.TabIndex = 4;
            this.ajoutLigneB.Text = "Ajouter Ligne";
            this.ajoutLigneB.UseVisualStyleBackColor = true;
            this.ajoutLigneB.Click += new System.EventHandler(this.ajoutLigneB_Click);
            // 
            // arretCB
            // 
            this.arretCB.FormattingEnabled = true;
            this.arretCB.Location = new System.Drawing.Point(346, 19);
            this.arretCB.Name = "arretCB";
            this.arretCB.Size = new System.Drawing.Size(100, 21);
            this.arretCB.TabIndex = 6;
            this.arretCB.TextChanged += new System.EventHandler(this.arretCB_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Heure:";
            // 
            // HeureCB
            // 
            this.HeureCB.FormattingEnabled = true;
            this.HeureCB.Location = new System.Drawing.Point(236, 114);
            this.HeureCB.Name = "HeureCB";
            this.HeureCB.Size = new System.Drawing.Size(144, 21);
            this.HeureCB.TabIndex = 9;
            // 
            // ajouterHeureB
            // 
            this.ajouterHeureB.Location = new System.Drawing.Point(480, 61);
            this.ajouterHeureB.Name = "ajouterHeureB";
            this.ajouterHeureB.Size = new System.Drawing.Size(99, 22);
            this.ajouterHeureB.TabIndex = 10;
            this.ajouterHeureB.Text = "Ajouter heure";
            this.ajouterHeureB.UseVisualStyleBackColor = true;
            this.ajouterHeureB.Click += new System.EventHandler(this.ajouterHeureB_Click);
            // 
            // semaineCB
            // 
            this.semaineCB.DisplayMember = "Lundi au Vendredi";
            this.semaineCB.FormattingEnabled = true;
            this.semaineCB.Items.AddRange(new object[] {
            "Lundi au Vendredi",
            "Lundi au Vendredi (vacances)",
            "Samedi",
            "Dimanche et jour ferie"});
            this.semaineCB.Location = new System.Drawing.Point(318, 63);
            this.semaineCB.Name = "semaineCB";
            this.semaineCB.Size = new System.Drawing.Size(156, 21);
            this.semaineCB.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(12, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 193);
            this.panel1.TabIndex = 12;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.arretTB);
            this.splitContainer1.Panel1.Controls.Add(this.ajoutArretB);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.ajouterCorresB);
            this.splitContainer1.Panel2.Controls.Add(this.arretCorrespCB);
            this.splitContainer1.Panel2.Controls.Add(this.ligneCorrespCB);
            this.splitContainer1.Size = new System.Drawing.Size(710, 193);
            this.splitContainer1.SplitterDistance = 356;
            this.splitContainer1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(131, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Simple Arret";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Arret:";
            // 
            // arretTB
            // 
            this.arretTB.Location = new System.Drawing.Point(108, 94);
            this.arretTB.Name = "arretTB";
            this.arretTB.Size = new System.Drawing.Size(75, 20);
            this.arretTB.TabIndex = 3;
            // 
            // ajoutArretB
            // 
            this.ajoutArretB.Location = new System.Drawing.Point(202, 90);
            this.ajoutArretB.Name = "ajoutArretB";
            this.ajoutArretB.Size = new System.Drawing.Size(101, 26);
            this.ajoutArretB.TabIndex = 5;
            this.ajoutArretB.Text = "Ajouter Arret";
            this.ajoutArretB.UseVisualStyleBackColor = true;
            this.ajoutArretB.Click += new System.EventHandler(this.ajoutArretB_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(192, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Arret:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(101, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Arret avec correspondance";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(59, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Ligne:";
            // 
            // ajouterCorresB
            // 
            this.ajouterCorresB.Location = new System.Drawing.Point(133, 127);
            this.ajouterCorresB.Name = "ajouterCorresB";
            this.ajouterCorresB.Size = new System.Drawing.Size(101, 25);
            this.ajouterCorresB.TabIndex = 1;
            this.ajouterCorresB.Text = "Ajouter arret";
            this.ajouterCorresB.UseVisualStyleBackColor = true;
            this.ajouterCorresB.Click += new System.EventHandler(this.ajouterCorresB_Click);
            // 
            // arretCorrespCB
            // 
            this.arretCorrespCB.FormattingEnabled = true;
            this.arretCorrespCB.Location = new System.Drawing.Point(230, 61);
            this.arretCorrespCB.Name = "arretCorrespCB";
            this.arretCorrespCB.Size = new System.Drawing.Size(70, 21);
            this.arretCorrespCB.TabIndex = 4;
            // 
            // ligneCorrespCB
            // 
            this.ligneCorrespCB.FormattingEnabled = true;
            this.ligneCorrespCB.Location = new System.Drawing.Point(101, 61);
            this.ligneCorrespCB.Name = "ligneCorrespCB";
            this.ligneCorrespCB.Size = new System.Drawing.Size(72, 21);
            this.ligneCorrespCB.TabIndex = 3;
            this.ligneCorrespCB.TextChanged += new System.EventHandler(this.ligneCorrespCB_TextChanged);
            // 
            // heure1NUD
            // 
            this.heure1NUD.Location = new System.Drawing.Point(206, 64);
            this.heure1NUD.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.heure1NUD.Name = "heure1NUD";
            this.heure1NUD.Size = new System.Drawing.Size(34, 20);
            this.heure1NUD.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = ":";
            // 
            // heure2NUD
            // 
            this.heure2NUD.Location = new System.Drawing.Point(267, 64);
            this.heure2NUD.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.heure2NUD.Name = "heure2NUD";
            this.heure2NUD.Size = new System.Drawing.Size(31, 20);
            this.heure2NUD.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(142, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Selectionner Arret auquel ajouter l\'heure:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(142, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Liste des heures:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.heure2NUD);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.heure1NUD);
            this.panel3.Controls.Add(this.semaineCB);
            this.panel3.Controls.Add(this.ajouterHeureB);
            this.panel3.Controls.Add(this.HeureCB);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.arretCB);
            this.panel3.Location = new System.Drawing.Point(12, 296);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(710, 158);
            this.panel3.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(300, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "Nouvelle ligne";
            // 
            // AjoutLigne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 501);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ajoutLigneB);
            this.Controls.Add(this.nomLigneTB);
            this.Controls.Add(this.label1);
            this.Name = "AjoutLigne";
            this.Text = "AjoutLigne";
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.heure1NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heure2NUD)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomLigneTB;
        private System.Windows.Forms.Button ajoutLigneB;
        private System.Windows.Forms.ComboBox arretCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox HeureCB;
        private System.Windows.Forms.Button ajouterHeureB;
        private System.Windows.Forms.ComboBox semaineCB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ajouterCorresB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown heure1NUD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown heure2NUD;
        private System.Windows.Forms.ComboBox ligneCorrespCB;
        private System.Windows.Forms.ComboBox arretCorrespCB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox arretTB;
        private System.Windows.Forms.Button ajoutArretB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.SplitContainer splitContainer1;

    }
}