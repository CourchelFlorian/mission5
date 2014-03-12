namespace PPE_MISSION_2_MAISON_DES_LIGUES
{
    partial class menuGrade0
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
            this.buttDemanderService = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboService = new System.Windows.Forms.ComboBox();
            this.typeServiceBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.m2l_Marco_SalimDataSet2 = new PPE_MISSION_2_MAISON_DES_LIGUES.m2l_Marco_SalimDataSet2();
            this.labelService = new System.Windows.Forms.Label();
            this.m2l_Marco_SalimDataSet = new PPE_MISSION_2_MAISON_DES_LIGUES.m2l_Marco_SalimDataSet();
            this.typeServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeServiceTableAdapter = new PPE_MISSION_2_MAISON_DES_LIGUES.m2l_Marco_SalimDataSetTableAdapters.typeServiceTableAdapter();
            this.m2l_Marco_SalimDataSet1 = new PPE_MISSION_2_MAISON_DES_LIGUES.m2l_Marco_SalimDataSet1();
            this.typeServiceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.typeServiceTableAdapter1 = new PPE_MISSION_2_MAISON_DES_LIGUES.m2l_Marco_SalimDataSet1TableAdapters.typeServiceTableAdapter();
            this.typeServiceTableAdapter2 = new PPE_MISSION_2_MAISON_DES_LIGUES.m2l_Marco_SalimDataSet2TableAdapters.typeServiceTableAdapter();
            this.calendrierService = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.buttValiderDemande = new System.Windows.Forms.Button();
            this.labelHeure = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.comboHeure = new System.Windows.Forms.ComboBox();
            this.comboMin = new System.Windows.Forms.ComboBox();
            this.btnDeco = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.typeServiceBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2l_Marco_SalimDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2l_Marco_SalimDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeServiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2l_Marco_SalimDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeServiceBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttDemanderService
            // 
            this.buttDemanderService.Location = new System.Drawing.Point(80, 44);
            this.buttDemanderService.Name = "buttDemanderService";
            this.buttDemanderService.Size = new System.Drawing.Size(131, 23);
            this.buttDemanderService.TabIndex = 0;
            this.buttDemanderService.Text = "Demander un Service";
            this.buttDemanderService.UseVisualStyleBackColor = true;
            this.buttDemanderService.Click += new System.EventHandler(this.buttDemanderService_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // comboService
            // 
            this.comboService.DataSource = this.typeServiceBindingSource2;
            this.comboService.DisplayMember = "libelleService";
            this.comboService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboService.FormattingEnabled = true;
            this.comboService.Location = new System.Drawing.Point(80, 212);
            this.comboService.Name = "comboService";
            this.comboService.Size = new System.Drawing.Size(200, 21);
            this.comboService.TabIndex = 2;
            this.comboService.ValueMember = "id";
            this.comboService.Visible = false;
            // 
            // typeServiceBindingSource2
            // 
            this.typeServiceBindingSource2.DataMember = "typeService";
            this.typeServiceBindingSource2.DataSource = this.m2l_Marco_SalimDataSet2;
            // 
            // m2l_Marco_SalimDataSet2
            // 
            this.m2l_Marco_SalimDataSet2.DataSetName = "m2l_Marco_SalimDataSet2";
            this.m2l_Marco_SalimDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelService
            // 
            this.labelService.AutoSize = true;
            this.labelService.Location = new System.Drawing.Point(12, 215);
            this.labelService.Name = "labelService";
            this.labelService.Size = new System.Drawing.Size(43, 13);
            this.labelService.TabIndex = 3;
            this.labelService.Text = "Service";
            this.labelService.Visible = false;
            // 
            // m2l_Marco_SalimDataSet
            // 
            this.m2l_Marco_SalimDataSet.DataSetName = "m2l_Marco_SalimDataSet";
            this.m2l_Marco_SalimDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeServiceBindingSource
            // 
            this.typeServiceBindingSource.DataMember = "typeService";
            this.typeServiceBindingSource.DataSource = this.m2l_Marco_SalimDataSet;
            // 
            // typeServiceTableAdapter
            // 
            this.typeServiceTableAdapter.ClearBeforeFill = true;
            // 
            // m2l_Marco_SalimDataSet1
            // 
            this.m2l_Marco_SalimDataSet1.DataSetName = "m2l_Marco_SalimDataSet1";
            this.m2l_Marco_SalimDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeServiceBindingSource1
            // 
            this.typeServiceBindingSource1.DataMember = "typeService";
            this.typeServiceBindingSource1.DataSource = this.m2l_Marco_SalimDataSet1;
            // 
            // typeServiceTableAdapter1
            // 
            this.typeServiceTableAdapter1.ClearBeforeFill = true;
            // 
            // typeServiceTableAdapter2
            // 
            this.typeServiceTableAdapter2.ClearBeforeFill = true;
            // 
            // calendrierService
            // 
            this.calendrierService.Location = new System.Drawing.Point(80, 133);
            this.calendrierService.Name = "calendrierService";
            this.calendrierService.Size = new System.Drawing.Size(200, 20);
            this.calendrierService.TabIndex = 4;
            this.calendrierService.Visible = false;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(12, 139);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(30, 13);
            this.labelDate.TabIndex = 5;
            this.labelDate.Text = "Date";
            this.labelDate.Visible = false;
            // 
            // buttValiderDemande
            // 
            this.buttValiderDemande.Location = new System.Drawing.Point(80, 265);
            this.buttValiderDemande.Name = "buttValiderDemande";
            this.buttValiderDemande.Size = new System.Drawing.Size(131, 23);
            this.buttValiderDemande.TabIndex = 6;
            this.buttValiderDemande.Text = "Valider la demande";
            this.buttValiderDemande.UseVisualStyleBackColor = true;
            this.buttValiderDemande.Visible = false;
            this.buttValiderDemande.Click += new System.EventHandler(this.buttValiderDemande_Click);
            // 
            // labelHeure
            // 
            this.labelHeure.AutoSize = true;
            this.labelHeure.Location = new System.Drawing.Point(157, 180);
            this.labelHeure.Name = "labelHeure";
            this.labelHeure.Size = new System.Drawing.Size(13, 13);
            this.labelHeure.TabIndex = 7;
            this.labelHeure.Text = "h";
            this.labelHeure.Visible = false;
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Location = new System.Drawing.Point(235, 180);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(23, 13);
            this.labelMin.TabIndex = 8;
            this.labelMin.Text = "min";
            this.labelMin.Visible = false;
            // 
            // comboHeure
            // 
            this.comboHeure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboHeure.FormattingEnabled = true;
            this.comboHeure.Location = new System.Drawing.Point(90, 177);
            this.comboHeure.Name = "comboHeure";
            this.comboHeure.Size = new System.Drawing.Size(62, 21);
            this.comboHeure.TabIndex = 9;
            this.comboHeure.Visible = false;
            // 
            // comboMin
            // 
            this.comboMin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMin.FormattingEnabled = true;
            this.comboMin.Location = new System.Drawing.Point(176, 177);
            this.comboMin.Name = "comboMin";
            this.comboMin.Size = new System.Drawing.Size(53, 21);
            this.comboMin.TabIndex = 9;
            this.comboMin.Visible = false;
            // 
            // btnDeco
            // 
            this.btnDeco.Location = new System.Drawing.Point(198, 13);
            this.btnDeco.Name = "btnDeco";
            this.btnDeco.Size = new System.Drawing.Size(81, 23);
            this.btnDeco.TabIndex = 10;
            this.btnDeco.Text = "Deconnexion";
            this.btnDeco.UseVisualStyleBackColor = true;
            this.btnDeco.Click += new System.EventHandler(this.btnDeco_Click);
            // 
            // menuGrade0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 314);
            this.Controls.Add(this.btnDeco);
            this.Controls.Add(this.comboMin);
            this.Controls.Add(this.comboHeure);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.labelHeure);
            this.Controls.Add(this.buttValiderDemande);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.calendrierService);
            this.Controls.Add(this.labelService);
            this.Controls.Add(this.comboService);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttDemanderService);
            this.Name = "menuGrade0";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Adhérent";
            this.Load += new System.EventHandler(this.menuGrade0_Load);
            ((System.ComponentModel.ISupportInitialize)(this.typeServiceBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2l_Marco_SalimDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2l_Marco_SalimDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeServiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2l_Marco_SalimDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeServiceBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttDemanderService;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboService;
        private System.Windows.Forms.Label labelService;
        private m2l_Marco_SalimDataSet m2l_Marco_SalimDataSet;
        private System.Windows.Forms.BindingSource typeServiceBindingSource;
        private m2l_Marco_SalimDataSetTableAdapters.typeServiceTableAdapter typeServiceTableAdapter;
        private m2l_Marco_SalimDataSet1 m2l_Marco_SalimDataSet1;
        private System.Windows.Forms.BindingSource typeServiceBindingSource1;
        private m2l_Marco_SalimDataSet1TableAdapters.typeServiceTableAdapter typeServiceTableAdapter1;
        private m2l_Marco_SalimDataSet2 m2l_Marco_SalimDataSet2;
        private System.Windows.Forms.BindingSource typeServiceBindingSource2;
        private m2l_Marco_SalimDataSet2TableAdapters.typeServiceTableAdapter typeServiceTableAdapter2;
        private System.Windows.Forms.DateTimePicker calendrierService;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button buttValiderDemande;
        private System.Windows.Forms.Label labelHeure;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.ComboBox comboHeure;
        private System.Windows.Forms.ComboBox comboMin;
        private System.Windows.Forms.Button btnDeco;
    }
}