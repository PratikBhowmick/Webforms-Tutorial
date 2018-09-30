namespace ConvertXmlToXl
{
    partial class Form1
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
            this.txtCustomeFileName = new System.Windows.Forms.TextBox();
            this.chkCustomeName = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowseFolder = new System.Windows.Forms.Button();
            this.txtXmlFilePath = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // txtCustomeFileName
            // 
            this.txtCustomeFileName.Location = new System.Drawing.Point(114, 67);
            this.txtCustomeFileName.Name = "txtCustomeFileName";
            this.txtCustomeFileName.Size = new System.Drawing.Size(182, 20);
            this.txtCustomeFileName.TabIndex = 22;
            this.txtCustomeFileName.Text = "ConvertedFile.xlsx";
            // 
            // chkCustomeName
            // 
            this.chkCustomeName.AutoSize = true;
            this.chkCustomeName.Checked = true;
            this.chkCustomeName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCustomeName.Location = new System.Drawing.Point(9, 69);
            this.chkCustomeName.Name = "chkCustomeName";
            this.chkCustomeName.Size = new System.Drawing.Size(102, 17);
            this.chkCustomeName.TabIndex = 21;
            this.chkCustomeName.Text = "Excel File Name";
            this.chkCustomeName.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Select XML File to Convert";
            // 
            // btnBrowseFolder
            // 
            this.btnBrowseFolder.Location = new System.Drawing.Point(233, 26);
            this.btnBrowseFolder.Name = "btnBrowseFolder";
            this.btnBrowseFolder.Size = new System.Drawing.Size(63, 23);
            this.btnBrowseFolder.TabIndex = 19;
            this.btnBrowseFolder.Text = "Browse";
            this.btnBrowseFolder.UseVisualStyleBackColor = true;
            this.btnBrowseFolder.Click += new System.EventHandler(this.btnBrowseFolder_Click);
            // 
            // txtXmlFilePath
            // 
            this.txtXmlFilePath.Location = new System.Drawing.Point(9, 29);
            this.txtXmlFilePath.Name = "txtXmlFilePath";
            this.txtXmlFilePath.Size = new System.Drawing.Size(218, 20);
            this.txtXmlFilePath.TabIndex = 18;
            this.txtXmlFilePath.Text = "C:\\Users\\Altaf\\Desktop\\Members\\Samdani\\Erection-Direction-Shear-Plate.xml";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(233, 106);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(63, 23);
            this.btnConvert.TabIndex = 17;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // OFD
            // 
            this.OFD.Filter = "XML File (*.xml)|*.xml|All files (*.*)|*.*";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 106);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(218, 23);
            this.progressBar1.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 141);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtCustomeFileName);
            this.Controls.Add(this.chkCustomeName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrowseFolder);
            this.Controls.Add(this.txtXmlFilePath);
            this.Controls.Add(this.btnConvert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Convert Excel To XML";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomeFileName;
        private System.Windows.Forms.CheckBox chkCustomeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowseFolder;
        private System.Windows.Forms.TextBox txtXmlFilePath;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

