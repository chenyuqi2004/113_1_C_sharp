﻿namespace credit_card_points
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
            this.txtcost = new System.Windows.Forms.TextBox();
            this.btnshow = new System.Windows.Forms.Button();
            this.lblpoints = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(84, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "輸入一個月的刷卡金額:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtcost
            // 
            this.txtcost.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtcost.Location = new System.Drawing.Point(264, 122);
            this.txtcost.Name = "txtcost";
            this.txtcost.Size = new System.Drawing.Size(100, 27);
            this.txtcost.TabIndex = 1;
            // 
            // btnshow
            // 
            this.btnshow.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnshow.Location = new System.Drawing.Point(183, 256);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(124, 42);
            this.btnshow.TabIndex = 2;
            this.btnshow.Text = "顯示累積點數";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // lblpoints
            // 
            this.lblpoints.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblpoints.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblpoints.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblpoints.Location = new System.Drawing.Point(171, 206);
            this.lblpoints.Name = "lblpoints";
            this.lblpoints.Size = new System.Drawing.Size(161, 37);
            this.lblpoints.TabIndex = 3;
            this.lblpoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 450);
            this.Controls.Add(this.lblpoints);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.txtcost);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "信用卡點數";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcost;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Label lblpoints;
    }
}

