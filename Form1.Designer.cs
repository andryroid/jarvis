namespace jarvis
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
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
            this.recoTextLabel = new System.Windows.Forms.Label();
            this.afficheLabel = new System.Windows.Forms.Label();
            this.devineLabel = new System.Windows.Forms.Label();
            this.recoText = new System.Windows.Forms.Label();
            this.affiche = new System.Windows.Forms.Label();
            this.devine = new System.Windows.Forms.Label();
            this.exemplesLabel = new System.Windows.Forms.Label();
            this.commandLabel = new System.Windows.Forms.Label();
            this.helpLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.commandText = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // recoTextLabel
            // 
            this.recoTextLabel.AutoSize = true;
            this.recoTextLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.recoTextLabel.Location = new System.Drawing.Point(6, 202);
            this.recoTextLabel.Name = "recoTextLabel";
            this.recoTextLabel.Size = new System.Drawing.Size(74, 13);
            this.recoTextLabel.TabIndex = 3;
            this.recoTextLabel.Text = "ny teneninao: ";
            // 
            // afficheLabel
            // 
            this.afficheLabel.AutoSize = true;
            this.afficheLabel.Location = new System.Drawing.Point(12, 78);
            this.afficheLabel.Name = "afficheLabel";
            this.afficheLabel.Size = new System.Drawing.Size(0, 13);
            this.afficheLabel.TabIndex = 5;
            // 
            // devineLabel
            // 
            this.devineLabel.AutoSize = true;
            this.devineLabel.Location = new System.Drawing.Point(12, 101);
            this.devineLabel.Name = "devineLabel";
            this.devineLabel.Size = new System.Drawing.Size(0, 13);
            this.devineLabel.TabIndex = 6;
            // 
            // recoText
            // 
            this.recoText.AutoSize = true;
            this.recoText.ForeColor = System.Drawing.SystemColors.Highlight;
            this.recoText.Location = new System.Drawing.Point(268, 9);
            this.recoText.Name = "recoText";
            this.recoText.Size = new System.Drawing.Size(24, 13);
            this.recoText.TabIndex = 7;
            this.recoText.Text = "test";
            // 
            // affiche
            // 
            this.affiche.AutoSize = true;
            this.affiche.ForeColor = System.Drawing.SystemColors.Highlight;
            this.affiche.Location = new System.Drawing.Point(213, 202);
            this.affiche.Name = "affiche";
            this.affiche.Size = new System.Drawing.Size(24, 13);
            this.affiche.TabIndex = 8;
            this.affiche.Text = "test";
            this.affiche.Click += new System.EventHandler(this.affiche_Click);
            // 
            // devine
            // 
            this.devine.AutoSize = true;
            this.devine.ForeColor = System.Drawing.SystemColors.Highlight;
            this.devine.Location = new System.Drawing.Point(86, 202);
            this.devine.Name = "devine";
            this.devine.Size = new System.Drawing.Size(24, 13);
            this.devine.TabIndex = 9;
            this.devine.Text = "test";
            // 
            // exemplesLabel
            // 
            this.exemplesLabel.AutoSize = true;
            this.exemplesLabel.Location = new System.Drawing.Point(12, 124);
            this.exemplesLabel.Name = "exemplesLabel";
            this.exemplesLabel.Size = new System.Drawing.Size(0, 13);
            this.exemplesLabel.TabIndex = 10;
            // 
            // commandLabel
            // 
            this.commandLabel.AutoSize = true;
            this.commandLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.commandLabel.Location = new System.Drawing.Point(129, 202);
            this.commandLabel.Name = "commandLabel";
            this.commandLabel.Size = new System.Drawing.Size(78, 13);
            this.commandLabel.TabIndex = 12;
            this.commandLabel.Text = "ao anaty code:";
            // 
            // helpLabel
            // 
            this.helpLabel.AutoSize = true;
            this.helpLabel.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpLabel.ForeColor = System.Drawing.Color.Red;
            this.helpLabel.Location = new System.Drawing.Point(3, -1);
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.Size = new System.Drawing.Size(218, 17);
            this.helpLabel.TabIndex = 14;
            this.helpLabel.Text = "RECONNAISSANCE ACTIVE";
            this.helpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.helpLabel.Click += new System.EventHandler(this.helpLabel_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 20);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(325, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel1.Text = "copyright kamikaz 2015";
            // 
            // commandText
            // 
            this.commandText.Location = new System.Drawing.Point(260, 93);
            this.commandText.Name = "commandText";
            this.commandText.Size = new System.Drawing.Size(100, 20);
            this.commandText.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 42);
            this.Controls.Add(this.commandText);
            this.Controls.Add(this.helpLabel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.commandLabel);
            this.Controls.Add(this.exemplesLabel);
            this.Controls.Add(this.devine);
            this.Controls.Add(this.affiche);
            this.Controls.Add(this.recoText);
            this.Controls.Add(this.devineLabel);
            this.Controls.Add(this.afficheLabel);
            this.Controls.Add(this.recoTextLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "JARVIS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label recoTextLabel;
        public System.Windows.Forms.Label afficheLabel;
        public System.Windows.Forms.Label devineLabel;
        public System.Windows.Forms.Label recoText;
        public System.Windows.Forms.Label affiche;
        public System.Windows.Forms.Label devine;
        public System.Windows.Forms.Label exemplesLabel;
        public System.Windows.Forms.Label commandLabel;
        public System.Windows.Forms.Label helpLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TextBox commandText;
    }
}