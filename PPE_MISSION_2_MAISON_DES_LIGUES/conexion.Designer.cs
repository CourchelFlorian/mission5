namespace PPE_MISSION_2_MAISON_DES_LIGUES
{
    partial class conexion
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
            this.labelID = new System.Windows.Forms.Label();
            this.labelMdp = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.textMdp = new System.Windows.Forms.TextBox();
            this.buttConexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(12, 16);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(67, 13);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "Identification";
            // 
            // labelMdp
            // 
            this.labelMdp.AutoSize = true;
            this.labelMdp.Location = new System.Drawing.Point(13, 42);
            this.labelMdp.Name = "labelMdp";
            this.labelMdp.Size = new System.Drawing.Size(71, 13);
            this.labelMdp.TabIndex = 1;
            this.labelMdp.Text = "Mot de passe";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(104, 13);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(100, 20);
            this.textID.TabIndex = 0;
            // 
            // textMdp
            // 
            this.textMdp.Location = new System.Drawing.Point(104, 39);
            this.textMdp.Name = "textMdp";
            this.textMdp.PasswordChar = '*';
            this.textMdp.Size = new System.Drawing.Size(100, 20);
            this.textMdp.TabIndex = 1;
            // 
            // buttConexion
            // 
            this.buttConexion.Location = new System.Drawing.Point(52, 85);
            this.buttConexion.Name = "buttConexion";
            this.buttConexion.Size = new System.Drawing.Size(116, 23);
            this.buttConexion.TabIndex = 2;
            this.buttConexion.Text = "Se connecter";
            this.buttConexion.UseVisualStyleBackColor = true;
            this.buttConexion.Click += new System.EventHandler(this.buttConexion_Click);
            // 
            // conexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 129);
            this.Controls.Add(this.buttConexion);
            this.Controls.Add(this.textMdp);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.labelMdp);
            this.Controls.Add(this.labelID);
            this.Name = "conexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.conexion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelMdp;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textMdp;
        private System.Windows.Forms.Button buttConexion;
    }
}