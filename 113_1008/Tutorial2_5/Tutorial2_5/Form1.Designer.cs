namespace Tutorial2_5
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
            this.PtxFront = new System.Windows.Forms.PictureBox();
            this.PtxBack = new System.Windows.Forms.PictureBox();
            this.BtnShowBack = new System.Windows.Forms.Button();
            this.BtnShowFront = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PtxFront)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // PtxFront
            // 
            this.PtxFront.Image = global::Tutorial2_5.Properties.Resources.Ace_Spades;
            this.PtxFront.Location = new System.Drawing.Point(341, 130);
            this.PtxFront.Name = "PtxFront";
            this.PtxFront.Size = new System.Drawing.Size(189, 251);
            this.PtxFront.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PtxFront.TabIndex = 1;
            this.PtxFront.TabStop = false;
            this.PtxFront.Visible = false;
            // 
            // PtxBack
            // 
            this.PtxBack.Image = global::Tutorial2_5.Properties.Resources.Backface_Blue;
            this.PtxBack.Location = new System.Drawing.Point(70, 130);
            this.PtxBack.Name = "PtxBack";
            this.PtxBack.Size = new System.Drawing.Size(189, 251);
            this.PtxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PtxBack.TabIndex = 0;
            this.PtxBack.TabStop = false;
            this.PtxBack.Visible = false;
            // 
            // BtnShowBack
            // 
            this.BtnShowBack.Location = new System.Drawing.Point(89, 409);
            this.BtnShowBack.Name = "BtnShowBack";
            this.BtnShowBack.Size = new System.Drawing.Size(146, 63);
            this.BtnShowBack.TabIndex = 2;
            this.BtnShowBack.Text = "背面";
            this.BtnShowBack.UseVisualStyleBackColor = true;
            this.BtnShowBack.Click += new System.EventHandler(this.BtnShowBack_Click);
            // 
            // BtnShowFront
            // 
            this.BtnShowFront.Location = new System.Drawing.Point(364, 409);
            this.BtnShowFront.Name = "BtnShowFront";
            this.BtnShowFront.Size = new System.Drawing.Size(146, 63);
            this.BtnShowFront.TabIndex = 3;
            this.BtnShowFront.Text = "正面";
            this.BtnShowFront.UseVisualStyleBackColor = true;
            this.BtnShowFront.Click += new System.EventHandler(this.BtnShowFront_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(136, 528);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(352, 38);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.Text = "離開";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 613);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnShowFront);
            this.Controls.Add(this.BtnShowBack);
            this.Controls.Add(this.PtxFront);
            this.Controls.Add(this.PtxBack);
            this.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "翻牌";
            ((System.ComponentModel.ISupportInitialize)(this.PtxFront)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtxBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PtxBack;
        private System.Windows.Forms.PictureBox PtxFront;
        private System.Windows.Forms.Button BtnShowBack;
        private System.Windows.Forms.Button BtnShowFront;
        private System.Windows.Forms.Button BtnExit;
    }
}

