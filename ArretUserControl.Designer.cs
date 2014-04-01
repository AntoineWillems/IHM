namespace IHM
{
    partial class ArretUserControl
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.nomArretL = new System.Windows.Forms.Label();
            this.corresp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-1, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 16);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // nomArretL
            // 
            this.nomArretL.AutoSize = true;
            this.nomArretL.Location = new System.Drawing.Point(32, 11);
            this.nomArretL.Name = "nomArretL";
            this.nomArretL.Size = new System.Drawing.Size(55, 13);
            this.nomArretL.TabIndex = 3;
            this.nomArretL.Text = "nomArretL";
            // 
            // corresp
            // 
            this.corresp.AutoSize = true;
            this.corresp.Location = new System.Drawing.Point(42, 67);
            this.corresp.Name = "corresp";
            this.corresp.Size = new System.Drawing.Size(0, 13);
            this.corresp.TabIndex = 4;
            // 
            // ArretUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.corresp);
            this.Controls.Add(this.nomArretL);
            this.Controls.Add(this.panel1);
            this.Name = "ArretUserControl";
            this.Size = new System.Drawing.Size(119, 139);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label nomArretL;
        private System.Windows.Forms.Label corresp;
    }
}
