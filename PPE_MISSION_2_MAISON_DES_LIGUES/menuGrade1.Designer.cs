namespace PPE_MISSION_2_MAISON_DES_LIGUES
{
    partial class menuGrade1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateDemande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAdherent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idServiceDemande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idetat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m2l_Marco_SalimDataSet3 = new PPE_MISSION_2_MAISON_DES_LIGUES.m2l_Marco_SalimDataSet3();
            this.etatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.etatTableAdapter = new PPE_MISSION_2_MAISON_DES_LIGUES.m2l_Marco_SalimDataSet3TableAdapters.etatTableAdapter();
            this.btnDeco = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2l_Marco_SalimDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Editer Les Factures";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(99, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Consuluter demande de services";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.Etat,
            this.Service,
            this.Prix,
            this.DateDemande,
            this.idService,
            this.idAdherent,
            this.idServiceDemande,
            this.idetat});
            this.dataGridView1.Location = new System.Drawing.Point(12, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(396, 373);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // Nom
            // 
            this.Nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            this.Nom.Width = 54;
            // 
            // Etat
            // 
            this.Etat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Etat.HeaderText = "Etat";
            this.Etat.Name = "Etat";
            this.Etat.ReadOnly = true;
            this.Etat.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Etat.Width = 51;
            // 
            // Service
            // 
            this.Service.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Service.HeaderText = "Services";
            this.Service.Name = "Service";
            this.Service.ReadOnly = true;
            this.Service.Width = 73;
            // 
            // Prix
            // 
            this.Prix.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Prix.HeaderText = "Prix";
            this.Prix.Name = "Prix";
            this.Prix.ReadOnly = true;
            this.Prix.Width = 49;
            // 
            // DateDemande
            // 
            this.DateDemande.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DateDemande.HeaderText = "Date de la Demande";
            this.DateDemande.Name = "DateDemande";
            this.DateDemande.ReadOnly = true;
            this.DateDemande.Width = 119;
            // 
            // idService
            // 
            this.idService.HeaderText = "idService";
            this.idService.Name = "idService";
            this.idService.ReadOnly = true;
            this.idService.Visible = false;
            // 
            // idAdherent
            // 
            this.idAdherent.HeaderText = "idAdherent";
            this.idAdherent.Name = "idAdherent";
            this.idAdherent.ReadOnly = true;
            this.idAdherent.Visible = false;
            // 
            // idServiceDemande
            // 
            this.idServiceDemande.HeaderText = "idServiceDemande";
            this.idServiceDemande.Name = "idServiceDemande";
            this.idServiceDemande.ReadOnly = true;
            this.idServiceDemande.Visible = false;
            // 
            // idetat
            // 
            this.idetat.HeaderText = "idetat";
            this.idetat.Name = "idetat";
            this.idetat.ReadOnly = true;
            this.idetat.Visible = false;
            // 
            // m2l_Marco_SalimDataSet3
            // 
            this.m2l_Marco_SalimDataSet3.DataSetName = "m2l_Marco_SalimDataSet3";
            this.m2l_Marco_SalimDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // etatBindingSource
            // 
            this.etatBindingSource.DataMember = "etat";
            this.etatBindingSource.DataSource = this.m2l_Marco_SalimDataSet3;
            // 
            // etatTableAdapter
            // 
            this.etatTableAdapter.ClearBeforeFill = true;
            // 
            // btnDeco
            // 
            this.btnDeco.Location = new System.Drawing.Point(326, 13);
            this.btnDeco.Name = "btnDeco";
            this.btnDeco.Size = new System.Drawing.Size(81, 23);
            this.btnDeco.TabIndex = 4;
            this.btnDeco.Text = "Deconnexion";
            this.btnDeco.UseVisualStyleBackColor = true;
            this.btnDeco.Click += new System.EventHandler(this.btnDeco_Click);
            // 
            // menuGrade1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 548);
            this.ControlBox = false;
            this.Controls.Add(this.btnDeco);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "menuGrade1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Responsable";
            this.Load += new System.EventHandler(this.menuGrade1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2l_Marco_SalimDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etatBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private m2l_Marco_SalimDataSet3 m2l_Marco_SalimDataSet3;
        private System.Windows.Forms.BindingSource etatBindingSource;
        private m2l_Marco_SalimDataSet3TableAdapters.etatTableAdapter etatTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Service;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateDemande;
        private System.Windows.Forms.DataGridViewTextBoxColumn idService;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAdherent;
        private System.Windows.Forms.DataGridViewTextBoxColumn idServiceDemande;
        private System.Windows.Forms.DataGridViewTextBoxColumn idetat;
        private System.Windows.Forms.Button btnDeco;
    }
}