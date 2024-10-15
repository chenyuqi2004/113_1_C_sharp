namespace tutorial3_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbkm = new System.Windows.Forms.TextBox();
            this.txbliter = new System.Windows.Forms.TextBox();
            this.lblshow = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(96, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "公里數";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(68, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "使用油耗";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(31, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "公里/每公升";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbkm
            // 
            this.txbkm.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txbkm.Location = new System.Drawing.Point(282, 141);
            this.txbkm.Name = "txbkm";
            this.txbkm.Size = new System.Drawing.Size(164, 40);
            this.txbkm.TabIndex = 3;
            // 
            // txbliter
            // 
            this.txbliter.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txbliter.Location = new System.Drawing.Point(282, 198);
            this.txbliter.Name = "txbliter";
            this.txbliter.Size = new System.Drawing.Size(164, 40);
            this.txbliter.TabIndex = 4;
            // 
            // lblshow
            // 
            this.lblshow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblshow.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblshow.Location = new System.Drawing.Point(282, 264);
            this.lblshow.Name = "lblshow";
            this.lblshow.Size = new System.Drawing.Size(164, 37);
            this.lblshow.TabIndex = 5;
            this.lblshow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(101, 383);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(107, 47);
            this.btncalculate.TabIndex = 6;
            this.btncalculate.Text = "計算";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(327, 383);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(107, 47);
            this.btnexit.TabIndex = 7;
            this.btnexit.Text = "離開";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 533);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.lblshow);
            this.Controls.Add(this.txbliter);
            this.Controls.Add(this.txbkm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbkm;
        private System.Windows.Forms.TextBox txbliter;
        private System.Windows.Forms.Label lblshow;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnexit;
    }
}

