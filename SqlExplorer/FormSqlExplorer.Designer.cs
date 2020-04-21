namespace SqlExplorer
{
    partial class SqlExplorerForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqlExplorerForm));
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxServerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDbName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxUserId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxUserPwd = new System.Windows.Forms.TextBox();
            this.buttonConnection = new System.Windows.Forms.Button();
            this.panelConnection = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonExportTableToExcel = new System.Windows.Forms.Button();
            this.comboBoxSheetName = new System.Windows.Forms.ComboBox();
            this.buttonLoadExcelTable = new System.Windows.Forms.Button();
            this.labelSheetName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSelectedFile = new System.Windows.Forms.TextBox();
            this.buttonSelectExcelFile = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxSelectTable = new System.Windows.Forms.ComboBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonLoadRefresh = new System.Windows.Forms.Button();
            this.panelDataGridView = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panelConnection.SuspendLayout();
            this.panelDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(3, 26);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(254, 20);
            this.textBoxIP.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sql Server IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sql Server Name";
            // 
            // textBoxServerName
            // 
            this.textBoxServerName.Location = new System.Drawing.Point(3, 75);
            this.textBoxServerName.Name = "textBoxServerName";
            this.textBoxServerName.Size = new System.Drawing.Size(254, 20);
            this.textBoxServerName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sql Db Name";
            // 
            // textBoxDbName
            // 
            this.textBoxDbName.Location = new System.Drawing.Point(3, 124);
            this.textBoxDbName.Name = "textBoxDbName";
            this.textBoxDbName.Size = new System.Drawing.Size(254, 20);
            this.textBoxDbName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "User ID";
            // 
            // textBoxUserId
            // 
            this.textBoxUserId.Location = new System.Drawing.Point(3, 174);
            this.textBoxUserId.Name = "textBoxUserId";
            this.textBoxUserId.Size = new System.Drawing.Size(254, 20);
            this.textBoxUserId.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "User PWD";
            // 
            // textBoxUserPwd
            // 
            this.textBoxUserPwd.Location = new System.Drawing.Point(3, 225);
            this.textBoxUserPwd.Name = "textBoxUserPwd";
            this.textBoxUserPwd.Size = new System.Drawing.Size(254, 20);
            this.textBoxUserPwd.TabIndex = 8;
            // 
            // buttonConnection
            // 
            this.buttonConnection.Location = new System.Drawing.Point(3, 258);
            this.buttonConnection.Name = "buttonConnection";
            this.buttonConnection.Size = new System.Drawing.Size(254, 23);
            this.buttonConnection.TabIndex = 10;
            this.buttonConnection.Text = "Connect";
            this.buttonConnection.UseVisualStyleBackColor = true;
            this.buttonConnection.Click += new System.EventHandler(this.buttonConnection_Click);
            // 
            // panelConnection
            // 
            this.panelConnection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelConnection.Controls.Add(this.button1);
            this.panelConnection.Controls.Add(this.buttonExportTableToExcel);
            this.panelConnection.Controls.Add(this.comboBoxSheetName);
            this.panelConnection.Controls.Add(this.buttonLoadExcelTable);
            this.panelConnection.Controls.Add(this.labelSheetName);
            this.panelConnection.Controls.Add(this.label7);
            this.panelConnection.Controls.Add(this.textBoxSelectedFile);
            this.panelConnection.Controls.Add(this.buttonSelectExcelFile);
            this.panelConnection.Controls.Add(this.label6);
            this.panelConnection.Controls.Add(this.comboBoxSelectTable);
            this.panelConnection.Controls.Add(this.buttonSubmit);
            this.panelConnection.Controls.Add(this.buttonLoadRefresh);
            this.panelConnection.Controls.Add(this.textBoxIP);
            this.panelConnection.Controls.Add(this.label1);
            this.panelConnection.Controls.Add(this.textBoxServerName);
            this.panelConnection.Controls.Add(this.label2);
            this.panelConnection.Controls.Add(this.buttonConnection);
            this.panelConnection.Controls.Add(this.textBoxDbName);
            this.panelConnection.Controls.Add(this.label5);
            this.panelConnection.Controls.Add(this.label3);
            this.panelConnection.Controls.Add(this.textBoxUserPwd);
            this.panelConnection.Controls.Add(this.textBoxUserId);
            this.panelConnection.Controls.Add(this.label4);
            this.panelConnection.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelConnection.Location = new System.Drawing.Point(0, 0);
            this.panelConnection.Name = "panelConnection";
            this.panelConnection.Size = new System.Drawing.Size(264, 687);
            this.panelConnection.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 24);
            this.button1.TabIndex = 26;
            this.button1.Text = "Clear Table";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonExportTableToExcel
            // 
            this.buttonExportTableToExcel.Location = new System.Drawing.Point(2, 487);
            this.buttonExportTableToExcel.Name = "buttonExportTableToExcel";
            this.buttonExportTableToExcel.Size = new System.Drawing.Size(255, 24);
            this.buttonExportTableToExcel.TabIndex = 25;
            this.buttonExportTableToExcel.Text = "Export Table To Excel";
            this.buttonExportTableToExcel.UseVisualStyleBackColor = true;
            this.buttonExportTableToExcel.Click += new System.EventHandler(this.buttonExportTableToExcel_Click);
            // 
            // comboBoxSheetName
            // 
            this.comboBoxSheetName.FormattingEnabled = true;
            this.comboBoxSheetName.Location = new System.Drawing.Point(3, 585);
            this.comboBoxSheetName.Name = "comboBoxSheetName";
            this.comboBoxSheetName.Size = new System.Drawing.Size(254, 21);
            this.comboBoxSheetName.TabIndex = 24;
            // 
            // buttonLoadExcelTable
            // 
            this.buttonLoadExcelTable.Location = new System.Drawing.Point(2, 458);
            this.buttonLoadExcelTable.Name = "buttonLoadExcelTable";
            this.buttonLoadExcelTable.Size = new System.Drawing.Size(255, 24);
            this.buttonLoadExcelTable.TabIndex = 23;
            this.buttonLoadExcelTable.Text = "Load Excel Table";
            this.buttonLoadExcelTable.UseVisualStyleBackColor = true;
            this.buttonLoadExcelTable.Click += new System.EventHandler(this.buttonLoadExcelTable_Click);
            // 
            // labelSheetName
            // 
            this.labelSheetName.AutoSize = true;
            this.labelSheetName.Location = new System.Drawing.Point(4, 569);
            this.labelSheetName.Name = "labelSheetName";
            this.labelSheetName.Size = new System.Drawing.Size(63, 13);
            this.labelSheetName.TabIndex = 22;
            this.labelSheetName.Text = "SheetName";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 525);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Selected File";
            // 
            // textBoxSelectedFile
            // 
            this.textBoxSelectedFile.Location = new System.Drawing.Point(3, 541);
            this.textBoxSelectedFile.Name = "textBoxSelectedFile";
            this.textBoxSelectedFile.Size = new System.Drawing.Size(254, 20);
            this.textBoxSelectedFile.TabIndex = 19;
            // 
            // buttonSelectExcelFile
            // 
            this.buttonSelectExcelFile.Location = new System.Drawing.Point(2, 429);
            this.buttonSelectExcelFile.Name = "buttonSelectExcelFile";
            this.buttonSelectExcelFile.Size = new System.Drawing.Size(255, 24);
            this.buttonSelectExcelFile.TabIndex = 18;
            this.buttonSelectExcelFile.Text = "Select Excel File For Table Import";
            this.buttonSelectExcelFile.UseVisualStyleBackColor = true;
            this.buttonSelectExcelFile.Click += new System.EventHandler(this.buttonSelectExcelFile_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Select Table";
            // 
            // comboBoxSelectTable
            // 
            this.comboBoxSelectTable.FormattingEnabled = true;
            this.comboBoxSelectTable.Location = new System.Drawing.Point(3, 307);
            this.comboBoxSelectTable.Name = "comboBoxSelectTable";
            this.comboBoxSelectTable.Size = new System.Drawing.Size(254, 21);
            this.comboBoxSelectTable.TabIndex = 16;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Image = ((System.Drawing.Image)(resources.GetObject("buttonSubmit.Image")));
            this.buttonSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSubmit.Location = new System.Drawing.Point(2, 400);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(255, 24);
            this.buttonSubmit.TabIndex = 14;
            this.buttonSubmit.Text = "Submit Table Modification To SQL";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonLoadRefresh
            // 
            this.buttonLoadRefresh.Location = new System.Drawing.Point(2, 342);
            this.buttonLoadRefresh.Name = "buttonLoadRefresh";
            this.buttonLoadRefresh.Size = new System.Drawing.Size(255, 24);
            this.buttonLoadRefresh.TabIndex = 13;
            this.buttonLoadRefresh.Text = "Load / Refresh Table";
            this.buttonLoadRefresh.UseVisualStyleBackColor = true;
            this.buttonLoadRefresh.Click += new System.EventHandler(this.buttonLoadRefresh_Click);
            // 
            // panelDataGridView
            // 
            this.panelDataGridView.Controls.Add(this.dataGridView);
            this.panelDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataGridView.Location = new System.Drawing.Point(264, 0);
            this.panelDataGridView.Name = "panelDataGridView";
            this.panelDataGridView.Size = new System.Drawing.Size(900, 687);
            this.panelDataGridView.TabIndex = 14;
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(6, 10);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(882, 665);
            this.dataGridView.TabIndex = 2;
            // 
            // SqlExplorerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 687);
            this.Controls.Add(this.panelDataGridView);
            this.Controls.Add(this.panelConnection);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SqlExplorerForm";
            this.Text = "Topcast Sql Explorer";
            this.panelConnection.ResumeLayout(false);
            this.panelConnection.PerformLayout();
            this.panelDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxServerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxUserId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxUserPwd;
        private System.Windows.Forms.Button buttonConnection;
        private System.Windows.Forms.Panel panelConnection;
        private System.Windows.Forms.Button buttonLoadRefresh;
        private System.Windows.Forms.Panel panelDataGridView;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxSelectTable;
        private System.Windows.Forms.Button buttonSelectExcelFile;
        private System.Windows.Forms.Label labelSheetName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxSelectedFile;
        private System.Windows.Forms.Button buttonLoadExcelTable;
        private System.Windows.Forms.ComboBox comboBoxSheetName;
        private System.Windows.Forms.Button buttonExportTableToExcel;
        private System.Windows.Forms.Button button1;
    }
}

