namespace Eskom__Prepaid_Electricity
{
    partial class frmEskom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEskom));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblToken = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblVat = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtMeterNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(223, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(735, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Meter Number";
            // 
            // lblToken
            // 
            this.lblToken.AutoSize = true;
            this.lblToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToken.Location = new System.Drawing.Point(404, 109);
            this.lblToken.Name = "lblToken";
            this.lblToken.Size = new System.Drawing.Size(163, 55);
            this.lblToken.TabIndex = 3;
            this.lblToken.Text = "Token";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(103, 515);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 55);
            this.label4.TabIndex = 4;
            this.label4.Text = "Amount";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblVat);
            this.groupBox1.Controls.Add(this.lblUnit);
            this.groupBox1.Controls.Add(this.lblToken);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(110, 760);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(982, 402);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Purchase Details";
            // 
            // lblVat
            // 
            this.lblVat.AutoSize = true;
            this.lblVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVat.Location = new System.Drawing.Point(404, 271);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(120, 55);
            this.lblVat.TabIndex = 5;
            this.lblVat.Text = "VAT";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.Location = new System.Drawing.Point(435, 194);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(113, 55);
            this.lblUnit.TabIndex = 4;
            this.lblUnit.Text = "Unit";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(524, 515);
            this.txtAmount.MaxLength = 6;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(554, 44);
            this.txtAmount.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtAmount, "Enter Whole numbers only, no cents \r\nDo not include ( . ,)");
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // btnPurchase
            // 
            this.btnPurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchase.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnPurchase.Location = new System.Drawing.Point(110, 616);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(976, 124);
            this.btnPurchase.TabIndex = 8;
            this.btnPurchase.Text = "Purchace";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // txtMeterNumber
            // 
            this.txtMeterNumber.Location = new System.Drawing.Point(524, 410);
            this.txtMeterNumber.MaxLength = 10;
            this.txtMeterNumber.Name = "txtMeterNumber";
            this.txtMeterNumber.Size = new System.Drawing.Size(554, 44);
            this.txtMeterNumber.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txtMeterNumber, "Enter Numerical Data only (0-9)");
            this.txtMeterNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMeterNumber_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(234, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 55);
            this.label2.TabIndex = 6;
            this.label2.Text = "VAT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(234, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 55);
            this.label3.TabIndex = 7;
            this.label3.Text = "Unit";
            // 
            // frmEskom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1193, 1197);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtMeterNumber);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEskom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eskom Prepaid electricity";
            this.Load += new System.EventHandler(this.frmEskom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblToken;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtMeterNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

