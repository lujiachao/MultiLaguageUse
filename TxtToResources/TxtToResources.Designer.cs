namespace TxtToResources
{
    partial class TxtToResources
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
            this.txtOpenFileTxt = new System.Windows.Forms.TextBox();
            this.btnOpenFileTxt = new System.Windows.Forms.Button();
            this.labelOpenFileTxt = new System.Windows.Forms.Label();
            this.btnCreateResources = new System.Windows.Forms.Button();
            this.labelOpenFileResources = new System.Windows.Forms.Label();
            this.txtBoxeResources = new System.Windows.Forms.TextBox();
            this.labelKeyWrite = new System.Windows.Forms.Label();
            this.labelValueWrite = new System.Windows.Forms.Label();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.btnOpenFileResources = new System.Windows.Forms.Button();
            this.btnWriteInResourse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOpenFileTxt
            // 
            this.txtOpenFileTxt.Location = new System.Drawing.Point(132, 15);
            this.txtOpenFileTxt.Name = "txtOpenFileTxt";
            this.txtOpenFileTxt.Size = new System.Drawing.Size(359, 21);
            this.txtOpenFileTxt.TabIndex = 0;
            // 
            // btnOpenFileTxt
            // 
            this.btnOpenFileTxt.Location = new System.Drawing.Point(519, 15);
            this.btnOpenFileTxt.Name = "btnOpenFileTxt";
            this.btnOpenFileTxt.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFileTxt.TabIndex = 1;
            this.btnOpenFileTxt.Text = "打开文件";
            this.btnOpenFileTxt.UseVisualStyleBackColor = true;
            this.btnOpenFileTxt.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // labelOpenFileTxt
            // 
            this.labelOpenFileTxt.AutoSize = true;
            this.labelOpenFileTxt.Location = new System.Drawing.Point(22, 18);
            this.labelOpenFileTxt.Name = "labelOpenFileTxt";
            this.labelOpenFileTxt.Size = new System.Drawing.Size(77, 12);
            this.labelOpenFileTxt.TabIndex = 2;
            this.labelOpenFileTxt.Text = "获取txt文件:";
            // 
            // btnCreateResources
            // 
            this.btnCreateResources.Location = new System.Drawing.Point(633, 13);
            this.btnCreateResources.Name = "btnCreateResources";
            this.btnCreateResources.Size = new System.Drawing.Size(130, 23);
            this.btnCreateResources.TabIndex = 3;
            this.btnCreateResources.Text = "生成Resources文件";
            this.btnCreateResources.UseVisualStyleBackColor = true;
            this.btnCreateResources.Click += new System.EventHandler(this.btnCreateResources_Click);
            // 
            // labelOpenFileResources
            // 
            this.labelOpenFileResources.AutoSize = true;
            this.labelOpenFileResources.Location = new System.Drawing.Point(22, 104);
            this.labelOpenFileResources.Name = "labelOpenFileResources";
            this.labelOpenFileResources.Size = new System.Drawing.Size(113, 12);
            this.labelOpenFileResources.TabIndex = 2;
            this.labelOpenFileResources.Text = "获取resources文件:";
            // 
            // txtBoxeResources
            // 
            this.txtBoxeResources.Location = new System.Drawing.Point(132, 101);
            this.txtBoxeResources.Name = "txtBoxeResources";
            this.txtBoxeResources.Size = new System.Drawing.Size(359, 21);
            this.txtBoxeResources.TabIndex = 0;
            // 
            // labelKeyWrite
            // 
            this.labelKeyWrite.AutoSize = true;
            this.labelKeyWrite.Location = new System.Drawing.Point(616, 91);
            this.labelKeyWrite.Name = "labelKeyWrite";
            this.labelKeyWrite.Size = new System.Drawing.Size(29, 12);
            this.labelKeyWrite.TabIndex = 2;
            this.labelKeyWrite.Text = "key:";
            // 
            // labelValueWrite
            // 
            this.labelValueWrite.AutoSize = true;
            this.labelValueWrite.Location = new System.Drawing.Point(616, 123);
            this.labelValueWrite.Name = "labelValueWrite";
            this.labelValueWrite.Size = new System.Drawing.Size(41, 12);
            this.labelValueWrite.TabIndex = 2;
            this.labelValueWrite.Text = "value:";
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(663, 82);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(100, 21);
            this.textBoxKey.TabIndex = 4;
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(663, 120);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(100, 21);
            this.textBoxValue.TabIndex = 5;
            // 
            // btnOpenFileResources
            // 
            this.btnOpenFileResources.Location = new System.Drawing.Point(519, 99);
            this.btnOpenFileResources.Name = "btnOpenFileResources";
            this.btnOpenFileResources.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFileResources.TabIndex = 1;
            this.btnOpenFileResources.Text = "打开文件";
            this.btnOpenFileResources.UseVisualStyleBackColor = true;
            this.btnOpenFileResources.Click += new System.EventHandler(this.btnOpenFileResources_Click);
            // 
            // btnWriteInResourse
            // 
            this.btnWriteInResourse.Location = new System.Drawing.Point(794, 99);
            this.btnWriteInResourse.Name = "btnWriteInResourse";
            this.btnWriteInResourse.Size = new System.Drawing.Size(75, 23);
            this.btnWriteInResourse.TabIndex = 1;
            this.btnWriteInResourse.Text = "写入";
            this.btnWriteInResourse.UseVisualStyleBackColor = true;
            this.btnWriteInResourse.Click += new System.EventHandler(this.btnWriteInResourse_Click);
            // 
            // TxtToResources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 450);
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.btnCreateResources);
            this.Controls.Add(this.labelOpenFileResources);
            this.Controls.Add(this.labelValueWrite);
            this.Controls.Add(this.labelKeyWrite);
            this.Controls.Add(this.labelOpenFileTxt);
            this.Controls.Add(this.btnWriteInResourse);
            this.Controls.Add(this.btnOpenFileResources);
            this.Controls.Add(this.btnOpenFileTxt);
            this.Controls.Add(this.txtBoxeResources);
            this.Controls.Add(this.txtOpenFileTxt);
            this.Name = "TxtToResources";
            this.Text = "TxtToResources";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOpenFileTxt;
        private System.Windows.Forms.Button btnOpenFileTxt;
        private System.Windows.Forms.Label labelOpenFileTxt;
        private System.Windows.Forms.Button btnCreateResources;
        private System.Windows.Forms.Label labelOpenFileResources;
        private System.Windows.Forms.TextBox txtBoxeResources;
        private System.Windows.Forms.Label labelKeyWrite;
        private System.Windows.Forms.Label labelValueWrite;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.Button btnOpenFileResources;
        private System.Windows.Forms.Button btnWriteInResourse;
    }
}

