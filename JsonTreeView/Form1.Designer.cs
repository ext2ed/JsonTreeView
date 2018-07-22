namespace JsonTreeview
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
            this.textBox_json = new System.Windows.Forms.TextBox();
            this.treeView_json = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_json
            // 
            this.textBox_json.Location = new System.Drawing.Point(13, 13);
            this.textBox_json.Multiline = true;
            this.textBox_json.Name = "textBox_json";
            this.textBox_json.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_json.Size = new System.Drawing.Size(775, 169);
            this.textBox_json.TabIndex = 0;
            this.textBox_json.Text = "{\r\n\t\"animals\":{\r\n\t\"dog\":[\r\n\t\t{\"name\":\"Rufus\",\"breed\":\"labrador\",\"count\":1,\"twoFee" +
    "t\":false},\r\n\t\t{\"name\":\"Marty\",\"breed\":\"whippet\",\"count\":1,\"twoFeet\":false}\r\n\t],\r" +
    "\n\t\"cat\":{\"name\":\"Matilda\"}\r\n}\r\n}";
            // 
            // treeView_json
            // 
            this.treeView_json.Location = new System.Drawing.Point(13, 234);
            this.treeView_json.Name = "treeView_json";
            this.treeView_json.Size = new System.Drawing.Size(775, 204);
            this.treeView_json.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Parse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView_json);
            this.Controls.Add(this.textBox_json);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_json;
        private System.Windows.Forms.TreeView treeView_json;
        private System.Windows.Forms.Button button1;
    }
}

