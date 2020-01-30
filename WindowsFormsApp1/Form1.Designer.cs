namespace WindowsFormsApp1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_url = new System.Windows.Forms.TextBox();
            this.txtbox_tsname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_tsnamefrom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbox_tsnameto = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richtxtbox_downloadurl = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "请求地址不含ts：";
            // 
            // txtbox_url
            // 
            this.txtbox_url.Location = new System.Drawing.Point(131, 12);
            this.txtbox_url.Name = "txtbox_url";
            this.txtbox_url.Size = new System.Drawing.Size(415, 21);
            this.txtbox_url.TabIndex = 1;
            this.txtbox_url.Text = "https://sohu.com-v-sohu.com/20181106/14111_e559e6fd/1000k/hls/";
            // 
            // txtbox_tsname
            // 
            this.txtbox_tsname.Location = new System.Drawing.Point(131, 39);
            this.txtbox_tsname.Name = "txtbox_tsname";
            this.txtbox_tsname.Size = new System.Drawing.Size(415, 21);
            this.txtbox_tsname.TabIndex = 3;
            this.txtbox_tsname.Text = "a98e05960d4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "ts文件名固定部分：";
            // 
            // txtbox_tsnamefrom
            // 
            this.txtbox_tsnamefrom.Location = new System.Drawing.Point(659, 12);
            this.txtbox_tsnamefrom.Name = "txtbox_tsnamefrom";
            this.txtbox_tsnamefrom.Size = new System.Drawing.Size(44, 21);
            this.txtbox_tsnamefrom.TabIndex = 5;
            this.txtbox_tsnamefrom.Text = "000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(552, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "ts文件名变动从：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(709, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "至：";
            // 
            // txtbox_tsnameto
            // 
            this.txtbox_tsnameto.Location = new System.Drawing.Point(744, 12);
            this.txtbox_tsnameto.Name = "txtbox_tsnameto";
            this.txtbox_tsnameto.Size = new System.Drawing.Size(44, 21);
            this.txtbox_tsnameto.TabIndex = 7;
            this.txtbox_tsnameto.Text = "1895";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(552, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "生成链接";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richtxtbox_downloadurl
            // 
            this.richtxtbox_downloadurl.Location = new System.Drawing.Point(14, 66);
            this.richtxtbox_downloadurl.Name = "richtxtbox_downloadurl";
            this.richtxtbox_downloadurl.Size = new System.Drawing.Size(774, 372);
            this.richtxtbox_downloadurl.TabIndex = 10;
            this.richtxtbox_downloadurl.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richtxtbox_downloadurl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtbox_tsnameto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbox_tsnamefrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbox_tsname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbox_url);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_url;
        private System.Windows.Forms.TextBox txtbox_tsname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox_tsnamefrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbox_tsnameto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richtxtbox_downloadurl;
    }
}

