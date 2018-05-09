namespace RandomLottery
{
    partial class MainWindow
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
            this.NumLabel0 = new System.Windows.Forms.Label();
            this.NumLabel1 = new System.Windows.Forms.Label();
            this.NumLabel2 = new System.Windows.Forms.Label();
            this.NumLabel3 = new System.Windows.Forms.Label();
            this.RandomButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumLabel0
            // 
            this.NumLabel0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NumLabel0.Font = new System.Drawing.Font("微軟正黑體", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NumLabel0.Location = new System.Drawing.Point(81, 84);
            this.NumLabel0.Name = "NumLabel0";
            this.NumLabel0.Padding = new System.Windows.Forms.Padding(10);
            this.NumLabel0.Size = new System.Drawing.Size(112, 144);
            this.NumLabel0.TabIndex = 0;
            this.NumLabel0.Text = "0";
            this.NumLabel0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NumLabel0.UseCompatibleTextRendering = true;
            // 
            // NumLabel1
            // 
            this.NumLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NumLabel1.Font = new System.Drawing.Font("微軟正黑體", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NumLabel1.Location = new System.Drawing.Point(224, 84);
            this.NumLabel1.Name = "NumLabel1";
            this.NumLabel1.Padding = new System.Windows.Forms.Padding(10);
            this.NumLabel1.Size = new System.Drawing.Size(112, 144);
            this.NumLabel1.TabIndex = 1;
            this.NumLabel1.Text = "0";
            this.NumLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NumLabel1.UseCompatibleTextRendering = true;
            // 
            // NumLabel2
            // 
            this.NumLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NumLabel2.Font = new System.Drawing.Font("微軟正黑體", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NumLabel2.Location = new System.Drawing.Point(364, 84);
            this.NumLabel2.Name = "NumLabel2";
            this.NumLabel2.Padding = new System.Windows.Forms.Padding(10);
            this.NumLabel2.Size = new System.Drawing.Size(112, 144);
            this.NumLabel2.TabIndex = 2;
            this.NumLabel2.Text = "0";
            this.NumLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NumLabel2.UseCompatibleTextRendering = true;
            // 
            // NumLabel3
            // 
            this.NumLabel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NumLabel3.Font = new System.Drawing.Font("微軟正黑體", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NumLabel3.Location = new System.Drawing.Point(504, 84);
            this.NumLabel3.Name = "NumLabel3";
            this.NumLabel3.Padding = new System.Windows.Forms.Padding(10);
            this.NumLabel3.Size = new System.Drawing.Size(112, 144);
            this.NumLabel3.TabIndex = 3;
            this.NumLabel3.Text = "0";
            this.NumLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NumLabel3.UseCompatibleTextRendering = true;
            // 
            // RandomButton
            // 
            this.RandomButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.RandomButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RandomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RandomButton.Location = new System.Drawing.Point(81, 290);
            this.RandomButton.Name = "RandomButton";
            this.RandomButton.Size = new System.Drawing.Size(535, 152);
            this.RandomButton.TabIndex = 4;
            this.RandomButton.Text = "Ramdom !";
            this.RandomButton.UseVisualStyleBackColor = false;
            this.RandomButton.Click += new System.EventHandler(this.RandomButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(38F, 81F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(704, 521);
            this.Controls.Add(this.RandomButton);
            this.Controls.Add(this.NumLabel3);
            this.Controls.Add(this.NumLabel2);
            this.Controls.Add(this.NumLabel1);
            this.Controls.Add(this.NumLabel0);
            this.Font = new System.Drawing.Font("微軟正黑體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(19, 20, 19, 20);
            this.Name = "MainWindow";
            this.Text = "Random 4 Numbers";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label NumLabel0;
        private System.Windows.Forms.Label NumLabel1;
        private System.Windows.Forms.Label NumLabel2;
        private System.Windows.Forms.Label NumLabel3;
        private System.Windows.Forms.Button RandomButton;
    }
}

