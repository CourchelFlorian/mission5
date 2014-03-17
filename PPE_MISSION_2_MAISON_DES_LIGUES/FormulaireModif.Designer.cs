namespace PPE_MISSION_2_MAISON_DES_LIGUES
{
    partial class FormulaireModif
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
            this.etatBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bddGestServKestCourcDataSet = new PPE_MISSION_2_MAISON_DES_LIGUES.bddGestServKestCourcDataSet();
            this.etatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m2l_Marco_SalimDataSet4 = new PPE_MISSION_2_MAISON_DES_LIGUES.m2l_Marco_SalimDataSet4();
            this.labelChangement = new System.Windows.Forms.Label();
            this.etatTableAdapter = new PPE_MISSION_2_MAISON_DES_LIGUES.m2l_Marco_SalimDataSet4TableAdapters.etatTableAdapter();
            this.buttValiderChangement = new System.Windows.Forms.Button();
            this.etatTableAdapter1 = new PPE_MISSION_2_MAISON_DES_LIGUES.bddGestServKestCourcDataSetTableAdapters.etatTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.etatBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bddGestServKestCourcDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2l_Marco_SalimDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // etatBindingSource1
            // 
            this.etatBindingSource1.DataMember = "etat";
            this.etatBindingSource1.DataSource = this.bddGestServKestCourcDataSet;
            // 
            // bddGestServKestCourcDataSet
            // 
            this.bddGestServKestCourcDataSet.DataSetName = "bddGestServKestCourcDataSet";
            this.bddGestServKestCourcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // etatBindingSource
            // 
            this.etatBindingSource.DataMember = "etat";
            this.etatBindingSource.DataSource = this.m2l_Marco_SalimDataSet4;
            // 
            // m2l_Marco_SalimDataSet4
            // 
            this.m2l_Marco_SalimDataSet4.DataSetName = "m2l_Marco_SalimDataSet4";
            this.m2l_Marco_SalimDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelChangement
            // 
            this.labelChangement.AutoSize = true;
            this.labelChangement.Location = new System.Drawing.Point(82, 31);
            this.labelChangement.Name = "labelChangement";
            this.labelChangement.Size = new System.Drawing.Size(0, 13);
            this.labelChangement.TabIndex = 1;
            // 
            // etatTableAdapter
            // 
            this.etatTableAdapter.ClearBeforeFill = true;
            // 
            // buttValiderChangement
            // 
            this.buttValiderChangement.Location = new System.Drawing.Point(62, 72);
            this.buttValiderChangement.Name = "buttValiderChangement";
            this.buttValiderChangement.Size = new System.Drawing.Size(167, 23);
            this.buttValiderChangement.TabIndex = 2;
            this.buttValiderChangement.Text = "Valider les Changements";
            this.buttValiderChangement.UseVisualStyleBackColor = true;
            this.buttValiderChangement.Click += new System.EventHandler(this.buttValiderChangement_Click_1);
            // 
            // etatTableAdapter1
            // 
            this.etatTableAdapter1.ClearBeforeFill = true;
            // 
            // FormulaireModif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 118);
            this.Controls.Add(this.buttValiderChangement);
            this.Controls.Add(this.labelChangement);
            this.Name = "FormulaireModif";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormulaireModif";
            this.Load += new System.EventHandler(this.FormulaireModif_Load);
            ((System.ComponentModel.ISupportInitialize)(this.etatBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bddGestServKestCourcDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2l_Marco_SalimDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChangement;
        private m2l_Marco_SalimDataSet4 m2l_Marco_SalimDataSet4;
        private System.Windows.Forms.BindingSource etatBindingSource;
        private m2l_Marco_SalimDataSet4TableAdapters.etatTableAdapter etatTableAdapter;
        private System.Windows.Forms.Button buttValiderChangement;
        private bddGestServKestCourcDataSet bddGestServKestCourcDataSet;
        private System.Windows.Forms.BindingSource etatBindingSource1;
        private bddGestServKestCourcDataSetTableAdapters.etatTableAdapter etatTableAdapter1;
    }
}