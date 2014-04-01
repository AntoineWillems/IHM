namespace IHM
{
    partial class RechIteneraire
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
            this.arretCB = new System.Windows.Forms.ComboBox();
            this.ligneBusCB = new System.Windows.Forms.ComboBox();
            this.ligneBus1CB = new System.Windows.Forms.ComboBox();
            this.arret1CB = new System.Windows.Forms.ComboBox();
            this.rechercherB = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.arretRechCB = new System.Windows.Forms.ComboBox();
            this.ligneRechCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rechercher1B = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TotemL = new System.Windows.Forms.Label();
            this.rechercherTotemB = new System.Windows.Forms.Button();
            this.arretTotemCB = new System.Windows.Forms.ComboBox();
            this.ligneTotemCB = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.semaineCB = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // arretCB
            // 
            this.arretCB.FormattingEnabled = true;
            this.arretCB.Location = new System.Drawing.Point(26, 144);
            this.arretCB.Name = "arretCB";
            this.arretCB.Size = new System.Drawing.Size(88, 21);
            this.arretCB.TabIndex = 0;
            // 
            // ligneBusCB
            // 
            this.ligneBusCB.FormattingEnabled = true;
            this.ligneBusCB.Location = new System.Drawing.Point(26, 75);
            this.ligneBusCB.Name = "ligneBusCB";
            this.ligneBusCB.Size = new System.Drawing.Size(86, 21);
            this.ligneBusCB.TabIndex = 1;
            this.ligneBusCB.TextChanged += new System.EventHandler(this.ligneBusCB_TextChanged);
            // 
            // ligneBus1CB
            // 
            this.ligneBus1CB.FormattingEnabled = true;
            this.ligneBus1CB.Location = new System.Drawing.Point(26, 75);
            this.ligneBus1CB.Name = "ligneBus1CB";
            this.ligneBus1CB.Size = new System.Drawing.Size(96, 21);
            this.ligneBus1CB.TabIndex = 2;
            this.ligneBus1CB.TextChanged += new System.EventHandler(this.ligneBus1CB_TextChanged);
            // 
            // arret1CB
            // 
            this.arret1CB.FormattingEnabled = true;
            this.arret1CB.Location = new System.Drawing.Point(24, 144);
            this.arret1CB.Name = "arret1CB";
            this.arret1CB.Size = new System.Drawing.Size(90, 21);
            this.arret1CB.TabIndex = 3;
            // 
            // rechercherB
            // 
            this.rechercherB.Location = new System.Drawing.Point(23, 184);
            this.rechercherB.Name = "rechercherB";
            this.rechercherB.Size = new System.Drawing.Size(99, 22);
            this.rechercherB.TabIndex = 4;
            this.rechercherB.Text = "Rechercher";
            this.rechercherB.UseVisualStyleBackColor = true;
            this.rechercherB.Click += new System.EventHandler(this.rechercherB_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.arretRechCB);
            this.panel1.Controls.Add(this.ligneRechCB);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rechercherB);
            this.panel1.Location = new System.Drawing.Point(48, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 237);
            this.panel1.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(15, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Recherche simple";
            // 
            // arretRechCB
            // 
            this.arretRechCB.FormattingEnabled = true;
            this.arretRechCB.Location = new System.Drawing.Point(35, 135);
            this.arretRechCB.Name = "arretRechCB";
            this.arretRechCB.Size = new System.Drawing.Size(82, 21);
            this.arretRechCB.TabIndex = 8;
            // 
            // ligneRechCB
            // 
            this.ligneRechCB.FormattingEnabled = true;
            this.ligneRechCB.Location = new System.Drawing.Point(35, 75);
            this.ligneRechCB.Name = "ligneRechCB";
            this.ligneRechCB.Size = new System.Drawing.Size(82, 21);
            this.ligneRechCB.TabIndex = 7;
            this.ligneRechCB.TextChanged += new System.EventHandler(this.ligneRechCB_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Arret:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ligne:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Location = new System.Drawing.Point(240, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 236);
            this.panel2.TabIndex = 6;
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
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.ligneBusCB);
            this.splitContainer1.Panel1.Controls.Add(this.arretCB);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.arret1CB);
            this.splitContainer1.Panel2.Controls.Add(this.ligneBus1CB);
            this.splitContainer1.Size = new System.Drawing.Size(300, 236);
            this.splitContainer1.SplitterDistance = 145;
            this.splitContainer1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Arret:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ligne:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(53, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Départ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Arret:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ligne:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(44, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Arrivée";
            // 
            // rechercher1B
            // 
            this.rechercher1B.Location = new System.Drawing.Point(330, 277);
            this.rechercher1B.Name = "rechercher1B";
            this.rechercher1B.Size = new System.Drawing.Size(109, 23);
            this.rechercher1B.TabIndex = 7;
            this.rechercher1B.Text = "Rechercher";
            this.rechercher1B.UseVisualStyleBackColor = true;
            this.rechercher1B.Click += new System.EventHandler(this.rechercher1B_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.semaineCB);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.TotemL);
            this.panel3.Controls.Add(this.rechercherTotemB);
            this.panel3.Controls.Add(this.arretTotemCB);
            this.panel3.Controls.Add(this.ligneTotemCB);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(48, 306);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(492, 166);
            this.panel3.TabIndex = 8;
            // 
            // TotemL
            // 
            this.TotemL.AutoSize = true;
            this.TotemL.Location = new System.Drawing.Point(122, 135);
            this.TotemL.Name = "TotemL";
            this.TotemL.Size = new System.Drawing.Size(0, 13);
            this.TotemL.TabIndex = 14;
            this.TotemL.Visible = false;
            // 
            // rechercherTotemB
            // 
            this.rechercherTotemB.Location = new System.Drawing.Point(412, 71);
            this.rechercherTotemB.Name = "rechercherTotemB";
            this.rechercherTotemB.Size = new System.Drawing.Size(78, 21);
            this.rechercherTotemB.TabIndex = 13;
            this.rechercherTotemB.Text = "Rechercher";
            this.rechercherTotemB.UseVisualStyleBackColor = true;
            this.rechercherTotemB.Click += new System.EventHandler(this.rechercherTotemB_Click);
            // 
            // arretTotemCB
            // 
            this.arretTotemCB.FormattingEnabled = true;
            this.arretTotemCB.Location = new System.Drawing.Point(310, 71);
            this.arretTotemCB.Name = "arretTotemCB";
            this.arretTotemCB.Size = new System.Drawing.Size(91, 21);
            this.arretTotemCB.TabIndex = 12;
            // 
            // ligneTotemCB
            // 
            this.ligneTotemCB.FormattingEnabled = true;
            this.ligneTotemCB.Location = new System.Drawing.Point(79, 71);
            this.ligneTotemCB.Name = "ligneTotemCB";
            this.ligneTotemCB.Size = new System.Drawing.Size(92, 21);
            this.ligneTotemCB.TabIndex = 11;
            this.ligneTotemCB.TextChanged += new System.EventHandler(this.ligneTotemCB_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(262, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Arret:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Ligne:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(96, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(250, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Totem vous informe du temps d\'attente à votre arrêt";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(199, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Totem";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(113, 106);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Selectionner:";
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
            this.semaineCB.Location = new System.Drawing.Point(203, 103);
            this.semaineCB.Name = "semaineCB";
            this.semaineCB.Size = new System.Drawing.Size(156, 21);
            this.semaineCB.TabIndex = 17;
            // 
            // RechIteneraire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 510);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.rechercher1B);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "RechIteneraire";
            this.Text = "RechIteneraire";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox arretCB;
        private System.Windows.Forms.ComboBox ligneBusCB;
        private System.Windows.Forms.ComboBox ligneBus1CB;
        private System.Windows.Forms.ComboBox arret1CB;
        private System.Windows.Forms.Button rechercherB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox arretRechCB;
        private System.Windows.Forms.ComboBox ligneRechCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button rechercher1B;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox arretTotemCB;
        private System.Windows.Forms.ComboBox ligneTotemCB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button rechercherTotemB;
        private System.Windows.Forms.Label TotemL;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox semaineCB;
    }
}