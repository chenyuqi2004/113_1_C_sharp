namespace stadium_seating
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAseats = new System.Windows.Forms.TextBox();
            this.txtBseats = new System.Windows.Forms.TextBox();
            this.txtCseats = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblARevenue = new System.Windows.Forms.Label();
            this.lblBRevenue = new System.Windows.Forms.Label();
            this.lblCRevenue = new System.Windows.Forms.Label();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCseats);
            this.groupBox1.Controls.Add(this.txtBseats);
            this.groupBox1.Controls.Add(this.txtAseats);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(29, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 269);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tickets Sold";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTotalRevenue);
            this.groupBox2.Controls.Add(this.lblCRevenue);
            this.groupBox2.Controls.Add(this.lblBRevenue);
            this.groupBox2.Controls.Add(this.lblARevenue);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(330, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 269);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Revenue Generated";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "輸入每個區域座位的門票數";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "A區";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "B區";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "C區";
            // 
            // txtAseats
            // 
            this.txtAseats.Location = new System.Drawing.Point(104, 105);
            this.txtAseats.Name = "txtAseats";
            this.txtAseats.Size = new System.Drawing.Size(100, 33);
            this.txtAseats.TabIndex = 4;
            // 
            // txtBseats
            // 
            this.txtBseats.Location = new System.Drawing.Point(104, 155);
            this.txtBseats.Name = "txtBseats";
            this.txtBseats.Size = new System.Drawing.Size(100, 33);
            this.txtBseats.TabIndex = 5;
            // 
            // txtCseats
            // 
            this.txtCseats.Location = new System.Drawing.Point(104, 206);
            this.txtCseats.Name = "txtCseats";
            this.txtCseats.Size = new System.Drawing.Size(100, 33);
            this.txtCseats.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "A區";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "B區";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "C區";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "總計";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 65);
            this.button1.TabIndex = 2;
            this.button1.Text = "計算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(268, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 65);
            this.button2.TabIndex = 3;
            this.button2.Text = "清除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(402, 403);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 65);
            this.button3.TabIndex = 4;
            this.button3.Text = "離開";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblARevenue
            // 
            this.lblARevenue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblARevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblARevenue.Location = new System.Drawing.Point(103, 64);
            this.lblARevenue.Name = "lblARevenue";
            this.lblARevenue.Size = new System.Drawing.Size(133, 30);
            this.lblARevenue.TabIndex = 9;
            // 
            // lblBRevenue
            // 
            this.lblBRevenue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBRevenue.Location = new System.Drawing.Point(103, 116);
            this.lblBRevenue.Name = "lblBRevenue";
            this.lblBRevenue.Size = new System.Drawing.Size(133, 30);
            this.lblBRevenue.TabIndex = 10;
            // 
            // lblCRevenue
            // 
            this.lblCRevenue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCRevenue.Location = new System.Drawing.Point(103, 166);
            this.lblCRevenue.Name = "lblCRevenue";
            this.lblCRevenue.Size = new System.Drawing.Size(133, 30);
            this.lblCRevenue.TabIndex = 11;
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalRevenue.Location = new System.Drawing.Point(72, 217);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(209, 30);
            this.lblTotalRevenue.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 522);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "stadium seating";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCseats;
        private System.Windows.Forms.TextBox txtBseats;
        private System.Windows.Forms.TextBox txtAseats;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblARevenue;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Label lblCRevenue;
        private System.Windows.Forms.Label lblBRevenue;
    }
}

