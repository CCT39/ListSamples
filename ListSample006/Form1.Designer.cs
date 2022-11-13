namespace ListSample006
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbxLeft = new System.Windows.Forms.ListBox();
            this.lbxRight = new System.Windows.Forms.ListBox();
            this.btnToRight = new System.Windows.Forms.Button();
            this.btnToLeft = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxLeft
            // 
            this.lbxLeft.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbxLeft.FormattingEnabled = true;
            this.lbxLeft.ItemHeight = 34;
            this.lbxLeft.Location = new System.Drawing.Point(52, 63);
            this.lbxLeft.Name = "lbxLeft";
            this.lbxLeft.Size = new System.Drawing.Size(276, 310);
            this.lbxLeft.TabIndex = 0;
            // 
            // lbxRight
            // 
            this.lbxRight.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbxRight.FormattingEnabled = true;
            this.lbxRight.ItemHeight = 34;
            this.lbxRight.Location = new System.Drawing.Point(459, 63);
            this.lbxRight.Name = "lbxRight";
            this.lbxRight.Size = new System.Drawing.Size(276, 310);
            this.lbxRight.TabIndex = 1;
            // 
            // btnToRight
            // 
            this.btnToRight.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnToRight.Location = new System.Drawing.Point(353, 117);
            this.btnToRight.Name = "btnToRight";
            this.btnToRight.Size = new System.Drawing.Size(75, 75);
            this.btnToRight.TabIndex = 2;
            this.btnToRight.Text = "→";
            this.btnToRight.UseVisualStyleBackColor = true;
            this.btnToRight.Click += new System.EventHandler(this.btnToRight_Click);
            // 
            // btnToLeft
            // 
            this.btnToLeft.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnToLeft.Location = new System.Drawing.Point(353, 278);
            this.btnToLeft.Name = "btnToLeft";
            this.btnToLeft.Size = new System.Drawing.Size(75, 75);
            this.btnToLeft.TabIndex = 3;
            this.btnToLeft.Text = "←";
            this.btnToLeft.UseVisualStyleBackColor = true;
            this.btnToLeft.Click += new System.EventHandler(this.btnToLeft_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnToLeft);
            this.Controls.Add(this.btnToRight);
            this.Controls.Add(this.lbxRight);
            this.Controls.Add(this.lbxLeft);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxLeft;
        private System.Windows.Forms.ListBox lbxRight;
        private System.Windows.Forms.Button btnToRight;
        private System.Windows.Forms.Button btnToLeft;
    }
}

