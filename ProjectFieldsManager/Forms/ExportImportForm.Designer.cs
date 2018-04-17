namespace ProjectFieldsManager.Forms
{
    partial class ExportImportForm
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
            this.gvFields = new System.Windows.Forms.DataGridView();
            this.bExport = new System.Windows.Forms.Button();
            this.bImport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gvTables = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.bGenerate = new System.Windows.Forms.Button();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.gvFields)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTables)).BeginInit();
            this.SuspendLayout();
            // 
            // gvFields
            // 
            this.gvFields.AllowUserToAddRows = false;
            this.gvFields.AllowUserToDeleteRows = false;
            this.gvFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvFields.Location = new System.Drawing.Point(12, 83);
            this.gvFields.Name = "gvFields";
            this.gvFields.RowTemplate.Height = 24;
            this.gvFields.Size = new System.Drawing.Size(852, 226);
            this.gvFields.TabIndex = 0;
            this.gvFields.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvFields_ColumnHeaderMouseClick);
            // 
            // bExport
            // 
            this.bExport.Enabled = false;
            this.bExport.Location = new System.Drawing.Point(12, 12);
            this.bExport.Name = "bExport";
            this.bExport.Size = new System.Drawing.Size(93, 38);
            this.bExport.TabIndex = 1;
            this.bExport.Text = "Export";
            this.bExport.UseVisualStyleBackColor = true;
            this.bExport.Click += new System.EventHandler(this.bExport_Click);
            // 
            // bImport
            // 
            this.bImport.Enabled = false;
            this.bImport.Location = new System.Drawing.Point(121, 12);
            this.bImport.Name = "bImport";
            this.bImport.Size = new System.Drawing.Size(93, 38);
            this.bImport.TabIndex = 2;
            this.bImport.Text = "Import";
            this.bImport.UseVisualStyleBackColor = true;
            this.bImport.Click += new System.EventHandler(this.bImport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Custom Enterprise Fields";
            // 
            // gvTables
            // 
            this.gvTables.AllowUserToAddRows = false;
            this.gvTables.AllowUserToDeleteRows = false;
            this.gvTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTables.Location = new System.Drawing.Point(12, 353);
            this.gvTables.Name = "gvTables";
            this.gvTables.ReadOnly = true;
            this.gvTables.RowTemplate.Height = 24;
            this.gvTables.Size = new System.Drawing.Size(852, 230);
            this.gvTables.TabIndex = 4;
            this.gvTables.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvTables_ColumnHeaderMouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Custom Lookup Tables";
            // 
            // bGenerate
            // 
            this.bGenerate.Enabled = false;
            this.bGenerate.Location = new System.Drawing.Point(229, 12);
            this.bGenerate.Name = "bGenerate";
            this.bGenerate.Size = new System.Drawing.Size(147, 38);
            this.bGenerate.TabIndex = 6;
            this.bGenerate.Text = "Generate Classes";
            this.bGenerate.UseVisualStyleBackColor = true;
            this.bGenerate.Click += new System.EventHandler(this.bGenerate_Click);
            // 
            // ExportImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 595);
            this.Controls.Add(this.bGenerate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gvTables);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bImport);
            this.Controls.Add(this.bExport);
            this.Controls.Add(this.gvFields);
            this.Name = "ExportImportForm";
            this.Text = "ExportImportForm";
            ((System.ComponentModel.ISupportInitialize)(this.gvFields)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvFields;
        private System.Windows.Forms.Button bExport;
        private System.Windows.Forms.Button bImport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvTables;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bGenerate;
        private System.Windows.Forms.SaveFileDialog saveDialog;
    }
}