
namespace PresentationApiCallFinder
{
    partial class frmAPICallFinder
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtHARFilePath = new System.Windows.Forms.TextBox();
            this.btnProcessHARFile = new System.Windows.Forms.Button();
            this.openHARFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.grdCallLog = new System.Windows.Forms.DataGridView();
            this.method = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdCallLog)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "HAR File";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(993, 62);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(98, 47);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtHARFilePath
            // 
            this.txtHARFilePath.Location = new System.Drawing.Point(182, 62);
            this.txtHARFilePath.Name = "txtHARFilePath";
            this.txtHARFilePath.Size = new System.Drawing.Size(778, 47);
            this.txtHARFilePath.TabIndex = 2;
            // 
            // btnProcessHARFile
            // 
            this.btnProcessHARFile.Location = new System.Drawing.Point(1230, 52);
            this.btnProcessHARFile.Name = "btnProcessHARFile";
            this.btnProcessHARFile.Size = new System.Drawing.Size(188, 58);
            this.btnProcessHARFile.TabIndex = 4;
            this.btnProcessHARFile.Text = "Process";
            this.btnProcessHARFile.UseVisualStyleBackColor = true;
            this.btnProcessHARFile.Click += new System.EventHandler(this.btnProcessHARFile_Click);
            // 
            // grdCallLog
            // 
            this.grdCallLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdCallLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCallLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.method,
            this.url});
            this.grdCallLog.Location = new System.Drawing.Point(0, 183);
            this.grdCallLog.Name = "grdCallLog";
            this.grdCallLog.RowHeadersWidth = 102;
            this.grdCallLog.RowTemplate.Height = 49;
            this.grdCallLog.Size = new System.Drawing.Size(2152, 1119);
            this.grdCallLog.TabIndex = 5;
            // 
            // method
            // 
            this.method.DataPropertyName = "method";
            this.method.HeaderText = "Method";
            this.method.MinimumWidth = 12;
            this.method.Name = "method";
            this.method.Width = 250;
            // 
            // url
            // 
            this.url.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.url.DataPropertyName = "url";
            this.url.HeaderText = "URL";
            this.url.MinimumWidth = 12;
            this.url.Name = "url";
            // 
            // frmAPICallFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2152, 1302);
            this.Controls.Add(this.grdCallLog);
            this.Controls.Add(this.btnProcessHARFile);
            this.Controls.Add(this.txtHARFilePath);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label1);
            this.Name = "frmAPICallFinder";
            this.Text = "Presentation API Call Finder";
            ((System.ComponentModel.ISupportInitialize)(this.grdCallLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtHARFilePath;
        private System.Windows.Forms.Button btnProcessHARFile;
        private System.Windows.Forms.OpenFileDialog openHARFileDialog;
        private System.Windows.Forms.DataGridView grdCallLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn method;
        private System.Windows.Forms.DataGridViewTextBoxColumn url;
    }
}

