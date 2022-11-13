namespace ListSample005
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
            this.tbxInput = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnFindIndex = new System.Windows.Forms.Button();
            this.btnFindAll = new System.Windows.Forms.Button();
            this.btnFindLast = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxInput
            // 
            this.tbxInput.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxInput.Location = new System.Drawing.Point(91, 69);
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(398, 43);
            this.tbxInput.TabIndex = 0;
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFind.Location = new System.Drawing.Point(91, 149);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(213, 50);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnFindIndex
            // 
            this.btnFindIndex.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFindIndex.Location = new System.Drawing.Point(91, 226);
            this.btnFindIndex.Name = "btnFindIndex";
            this.btnFindIndex.Size = new System.Drawing.Size(213, 50);
            this.btnFindIndex.TabIndex = 2;
            this.btnFindIndex.Text = "Find Index";
            this.btnFindIndex.UseVisualStyleBackColor = true;
            this.btnFindIndex.Click += new System.EventHandler(this.btnFindIndex_Click);
            // 
            // btnFindAll
            // 
            this.btnFindAll.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFindAll.Location = new System.Drawing.Point(91, 302);
            this.btnFindAll.Name = "btnFindAll";
            this.btnFindAll.Size = new System.Drawing.Size(213, 50);
            this.btnFindAll.TabIndex = 3;
            this.btnFindAll.Text = "Find All";
            this.btnFindAll.UseVisualStyleBackColor = true;
            this.btnFindAll.Click += new System.EventHandler(this.btnFindAll_Click);
            // 
            // btnFindLast
            // 
            this.btnFindLast.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFindLast.Location = new System.Drawing.Point(91, 376);
            this.btnFindLast.Name = "btnFindLast";
            this.btnFindLast.Size = new System.Drawing.Size(213, 50);
            this.btnFindLast.TabIndex = 4;
            this.btnFindLast.Text = "Find Last";
            this.btnFindLast.UseVisualStyleBackColor = true;
            this.btnFindLast.Click += new System.EventHandler(this.btnFindLast_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 476);
            this.Controls.Add(this.btnFindLast);
            this.Controls.Add(this.btnFindAll);
            this.Controls.Add(this.btnFindIndex);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.tbxInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxInput;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnFindIndex;
        private System.Windows.Forms.Button btnFindAll;
        private System.Windows.Forms.Button btnFindLast;
    }
}

