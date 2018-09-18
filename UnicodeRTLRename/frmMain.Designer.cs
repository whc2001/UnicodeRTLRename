namespace UnicodeRTLRename
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFileInput = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFakeExtension = new System.Windows.Forms.TextBox();
            this.txtRealExtension = new System.Windows.Forms.TextBox();
            this.btnOutput = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOutputFileName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "所有文件|*.*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "File:";
            // 
            // txtFileInput
            // 
            this.txtFileInput.Location = new System.Drawing.Point(58, 14);
            this.txtFileInput.Name = "txtFileInput";
            this.txtFileInput.ReadOnly = true;
            this.txtFileInput.Size = new System.Drawing.Size(296, 21);
            this.txtFileInput.TabIndex = 1;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(359, 13);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(39, 23);
            this.btnOpenFile.TabIndex = 2;
            this.btnOpenFile.Text = "Open";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fake extension:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Real extension:";
            // 
            // txtFakeExtension
            // 
            this.txtFakeExtension.Location = new System.Drawing.Point(118, 73);
            this.txtFakeExtension.Name = "txtFakeExtension";
            this.txtFakeExtension.Size = new System.Drawing.Size(91, 21);
            this.txtFakeExtension.TabIndex = 5;
            this.txtFakeExtension.TextChanged += new System.EventHandler(this.ContentChanged);
            // 
            // txtRealExtension
            // 
            this.txtRealExtension.Location = new System.Drawing.Point(118, 97);
            this.txtRealExtension.Name = "txtRealExtension";
            this.txtRealExtension.Size = new System.Drawing.Size(91, 21);
            this.txtRealExtension.TabIndex = 6;
            this.txtRealExtension.TextChanged += new System.EventHandler(this.ContentChanged);
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(19, 154);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(379, 23);
            this.btnOutput.TabIndex = 9;
            this.btnOutput.Text = "Output";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(58, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(296, 21);
            this.txtName.TabIndex = 11;
            this.txtName.TextChanged += new System.EventHandler(this.ContentChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "Name: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "Output file name will look like:";
            // 
            // txtOutputFileName
            // 
            this.txtOutputFileName.Location = new System.Drawing.Point(211, 127);
            this.txtOutputFileName.Name = "txtOutputFileName";
            this.txtOutputFileName.ReadOnly = true;
            this.txtOutputFileName.Size = new System.Drawing.Size(187, 21);
            this.txtOutputFileName.TabIndex = 13;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 186);
            this.Controls.Add(this.txtOutputFileName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.txtRealExtension);
            this.Controls.Add(this.txtFakeExtension);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.txtFileInput);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "UnnicodeRTLRename";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFileInput;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFakeExtension;
        private System.Windows.Forms.TextBox txtRealExtension;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOutputFileName;
    }
}

