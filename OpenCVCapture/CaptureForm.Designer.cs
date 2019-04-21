namespace OpenCVCapture
{
    partial class CaptureForm
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
            this.btnExit = new System.Windows.Forms.Button();
            this.ptbSource = new System.Windows.Forms.PictureBox();
            this.tx_SavePath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(584, 369);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(161, 49);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ptbSource
            // 
            this.ptbSource.Location = new System.Drawing.Point(31, 37);
            this.ptbSource.Name = "ptbSource";
            this.ptbSource.Size = new System.Drawing.Size(232, 279);
            this.ptbSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbSource.TabIndex = 1;
            this.ptbSource.TabStop = false;
            this.ptbSource.Click += new System.EventHandler(this.ptbSource_Click);
            // 
            // tx_SavePath
            // 
            this.tx_SavePath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_SavePath.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tx_SavePath.Location = new System.Drawing.Point(451, 37);
            this.tx_SavePath.Multiline = true;
            this.tx_SavePath.Name = "tx_SavePath";
            this.tx_SavePath.ReadOnly = true;
            this.tx_SavePath.Size = new System.Drawing.Size(294, 94);
            this.tx_SavePath.TabIndex = 2;
            this.tx_SavePath.Text = "SavePath";
            // 
            // CaptureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tx_SavePath);
            this.Controls.Add(this.ptbSource);
            this.Controls.Add(this.btnExit);
            this.Name = "CaptureForm";
            this.Text = "CaptureForm";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.ptbSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox ptbSource;
        private System.Windows.Forms.TextBox tx_SavePath;
    }
}

