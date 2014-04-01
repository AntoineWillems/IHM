namespace IHM
{
    partial class administrationFenetre
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Pseudo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mdp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Admin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ajoutAdmin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pseudo,
            this.mdp,
            this.Admin});
            this.dataGridView1.Location = new System.Drawing.Point(31, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(348, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Pseudo
            // 
            this.Pseudo.HeaderText = "Pseudo";
            this.Pseudo.Name = "Pseudo";
            this.Pseudo.ReadOnly = true;
            // 
            // mdp
            // 
            this.mdp.HeaderText = "Mot de passe";
            this.mdp.Name = "mdp";
            this.mdp.ReadOnly = true;
            // 
            // Admin
            // 
            this.Admin.HeaderText = "Administrateur";
            this.Admin.Name = "Admin";
            // 
            // ajoutAdmin
            // 
            this.ajoutAdmin.Location = new System.Drawing.Point(140, 229);
            this.ajoutAdmin.Name = "ajoutAdmin";
            this.ajoutAdmin.Size = new System.Drawing.Size(133, 21);
            this.ajoutAdmin.TabIndex = 1;
            this.ajoutAdmin.Text = "Aouter administrateur";
            this.ajoutAdmin.UseVisualStyleBackColor = true;
            this.ajoutAdmin.Click += new System.EventHandler(this.ajoutAdmin_Click);
            // 
            // administrationFenetre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 262);
            this.Controls.Add(this.ajoutAdmin);
            this.Controls.Add(this.dataGridView1);
            this.Name = "administrationFenetre";
            this.Text = "administrationFenetre";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pseudo;
        private System.Windows.Forms.DataGridViewTextBoxColumn mdp;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Admin;
        private System.Windows.Forms.Button ajoutAdmin;
    }
}