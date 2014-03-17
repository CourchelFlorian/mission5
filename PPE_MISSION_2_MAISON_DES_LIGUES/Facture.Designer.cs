namespace PPE_MISSION_2_MAISON_DES_LIGUES
{
    partial class Facture
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
            this.components = new System.ComponentModel.Container();
            this.comboMois = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nomLigue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomAdherent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleEtat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ligueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m2l_Marco_SalimDataSet5 = new PPE_MISSION_2_MAISON_DES_LIGUES.m2l_Marco_SalimDataSet5();
            this.ligueTableAdapter = new PPE_MISSION_2_MAISON_DES_LIGUES.m2l_Marco_SalimDataSet5TableAdapters.ligueTableAdapter();
            this.labelFacture = new System.Windows.Forms.Label();
            this.comboAnnee = new System.Windows.Forms.ComboBox();
            this.m2l_Marco_SalimDataSet6 = new PPE_MISSION_2_MAISON_DES_LIGUES.m2l_Marco_SalimDataSet6();
            this.m2lMarcoSalimDataSet6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDeco = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2l_Marco_SalimDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2l_Marco_SalimDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2lMarcoSalimDataSet6BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboMois
            // 
            this.comboMois.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMois.FormattingEnabled = true;
            this.comboMois.Location = new System.Drawing.Point(288, 38);
            this.comboMois.Name = "comboMois";
            this.comboMois.Size = new System.Drawing.Size(85, 21);
            this.comboMois.TabIndex = 0;
            this.comboMois.SelectedIndexChanged += new System.EventHandler(this.comboMois_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pour le mois";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomLigue,
            this.nomAdherent,
            this.libelleEtat,
            this.libelleService,
            this.prix});
            this.dataGridView1.Location = new System.Drawing.Point(12, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(499, 394);
            this.dataGridView1.TabIndex = 2;
            // 
            // nomLigue
            // 
            this.nomLigue.HeaderText = "nomLigue";
            this.nomLigue.Name = "nomLigue";
            this.nomLigue.ReadOnly = true;
            // 
            // nomAdherent
            // 
            this.nomAdherent.HeaderText = "nomAdherent";
            this.nomAdherent.Name = "nomAdherent";
            this.nomAdherent.ReadOnly = true;
            // 
            // libelleEtat
            // 
            this.libelleEtat.HeaderText = "Etat";
            this.libelleEtat.Name = "libelleEtat";
            this.libelleEtat.ReadOnly = true;
            // 
            // libelleService
            // 
            this.libelleService.HeaderText = "Service";
            this.libelleService.Name = "libelleService";
            this.libelleService.ReadOnly = true;
            // 
            // prix
            // 
            this.prix.HeaderText = "Prix";
            this.prix.Name = "prix";
            this.prix.ReadOnly = true;
            // 
            // ligueBindingSource
            // 
            this.ligueBindingSource.DataMember = "ligue";
            this.ligueBindingSource.DataSource = this.m2l_Marco_SalimDataSet5;
            // 
            // m2l_Marco_SalimDataSet5
            // 
            this.m2l_Marco_SalimDataSet5.DataSetName = "m2l_Marco_SalimDataSet5";
            this.m2l_Marco_SalimDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ligueTableAdapter
            // 
            this.ligueTableAdapter.ClearBeforeFill = true;
            // 
            // labelFacture
            // 
            this.labelFacture.AutoSize = true;
            this.labelFacture.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFacture.Location = new System.Drawing.Point(13, 13);
            this.labelFacture.Name = "labelFacture";
            this.labelFacture.Size = new System.Drawing.Size(50, 13);
            this.labelFacture.TabIndex = 4;
            this.labelFacture.Text = "Facture";
            // 
            // comboAnnee
            // 
            this.comboAnnee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAnnee.FormattingEnabled = true;
            this.comboAnnee.Location = new System.Drawing.Point(380, 38);
            this.comboAnnee.Name = "comboAnnee";
            this.comboAnnee.Size = new System.Drawing.Size(85, 21);
            this.comboAnnee.TabIndex = 6;
            this.comboAnnee.SelectedIndexChanged += new System.EventHandler(this.comboAnnee_SelectedIndexChanged);
            // 
            // m2l_Marco_SalimDataSet6
            // 
            this.m2l_Marco_SalimDataSet6.DataSetName = "m2l_Marco_SalimDataSet6";
            this.m2l_Marco_SalimDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // m2lMarcoSalimDataSet6BindingSource
            // 
            this.m2lMarcoSalimDataSet6BindingSource.DataSource = this.m2l_Marco_SalimDataSet6;
            this.m2lMarcoSalimDataSet6BindingSource.Position = 0;
            // 
            // btnDeco
            // 
            this.btnDeco.Location = new System.Drawing.Point(16, 35);
            this.btnDeco.Name = "btnDeco";
            this.btnDeco.Size = new System.Drawing.Size(80, 24);
            this.btnDeco.TabIndex = 7;
            this.btnDeco.Text = "Deconnexion";
            this.btnDeco.UseVisualStyleBackColor = true;
            this.btnDeco.Click += new System.EventHandler(this.btnDeco_Click);
            // 
            // Facture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 503);
            this.Controls.Add(this.btnDeco);
            this.Controls.Add(this.comboAnnee);
            this.Controls.Add(this.labelFacture);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboMois);
            this.Name = "Facture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facture";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Facture_FormClosed);
            this.Load += new System.EventHandler(this.Facture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2l_Marco_SalimDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2l_Marco_SalimDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2lMarcoSalimDataSet6BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboMois;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private m2l_Marco_SalimDataSet5 m2l_Marco_SalimDataSet5;
        private System.Windows.Forms.BindingSource ligueBindingSource;
        private m2l_Marco_SalimDataSet5TableAdapters.ligueTableAdapter ligueTableAdapter;
        private System.Windows.Forms.Label labelFacture;
        private System.Windows.Forms.ComboBox comboAnnee;
        private m2l_Marco_SalimDataSet6 m2l_Marco_SalimDataSet6;
        private System.Windows.Forms.BindingSource m2lMarcoSalimDataSet6BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomLigue;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomAdherent;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleEtat;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleService;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix;
        private System.Windows.Forms.Button btnDeco;
    }
}