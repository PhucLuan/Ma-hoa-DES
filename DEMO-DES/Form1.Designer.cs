namespace DEMO_DES
{
    partial class DES_Encrpytion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBanRo = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.radioEncryp = new System.Windows.Forms.RadioButton();
            this.radioDecryp = new System.Windows.Forms.RadioButton();
            this.GenKey = new System.Windows.Forms.Button();
            this.dgvListKey = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListKey)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 53);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "DEMO MÃ HÓA DES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập bản rõ M:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập khóa K:";
            // 
            // txtBanRo
            // 
            this.txtBanRo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBanRo.Location = new System.Drawing.Point(197, 72);
            this.txtBanRo.Multiline = true;
            this.txtBanRo.Name = "txtBanRo";
            this.txtBanRo.Size = new System.Drawing.Size(250, 38);
            this.txtBanRo.TabIndex = 3;
            this.txtBanRo.Text = "0123456789ABCDEF";
            this.txtBanRo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKey
            // 
            this.txtKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKey.Location = new System.Drawing.Point(197, 148);
            this.txtKey.Multiline = true;
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(250, 38);
            this.txtKey.TabIndex = 4;
            this.txtKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kết quả:";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(197, 303);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(250, 38);
            this.txtResult.TabIndex = 6;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(197, 249);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(91, 33);
            this.btnResult.TabIndex = 7;
            this.btnResult.Text = "Submit";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnEncrpytion_Click);
            // 
            // radioEncryp
            // 
            this.radioEncryp.AutoSize = true;
            this.radioEncryp.Location = new System.Drawing.Point(197, 207);
            this.radioEncryp.Name = "radioEncryp";
            this.radioEncryp.Size = new System.Drawing.Size(61, 17);
            this.radioEncryp.TabIndex = 8;
            this.radioEncryp.TabStop = true;
            this.radioEncryp.Text = "Mã hóa";
            this.radioEncryp.UseVisualStyleBackColor = true;
            this.radioEncryp.CheckedChanged += new System.EventHandler(this.radioEncryp_CheckedChanged);
            // 
            // radioDecryp
            // 
            this.radioDecryp.AutoSize = true;
            this.radioDecryp.Location = new System.Drawing.Point(333, 207);
            this.radioDecryp.Name = "radioDecryp";
            this.radioDecryp.Size = new System.Drawing.Size(60, 17);
            this.radioDecryp.TabIndex = 9;
            this.radioDecryp.TabStop = true;
            this.radioDecryp.Text = "Giải mã";
            this.radioDecryp.UseVisualStyleBackColor = true;
            this.radioDecryp.CheckedChanged += new System.EventHandler(this.radioDecryp_CheckedChanged);
            // 
            // GenKey
            // 
            this.GenKey.Location = new System.Drawing.Point(356, 249);
            this.GenKey.Name = "GenKey";
            this.GenKey.Size = new System.Drawing.Size(91, 33);
            this.GenKey.TabIndex = 10;
            this.GenKey.Text = "Sinh Khóa";
            this.GenKey.UseVisualStyleBackColor = true;
            this.GenKey.Click += new System.EventHandler(this.GenKey_Click);
            // 
            // dgvListKey
            // 
            this.dgvListKey.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListKey.Location = new System.Drawing.Point(498, 72);
            this.dgvListKey.Name = "dgvListKey";
            this.dgvListKey.Size = new System.Drawing.Size(240, 392);
            this.dgvListKey.TabIndex = 11;
            // 
            // DES_Encrpytion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 476);
            this.Controls.Add(this.dgvListKey);
            this.Controls.Add(this.GenKey);
            this.Controls.Add(this.radioDecryp);
            this.Controls.Add(this.radioEncryp);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.txtBanRo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "DES_Encrpytion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DES_Encrpytion";
            this.Load += new System.EventHandler(this.DES_Encrpytion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListKey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBanRo;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.RadioButton radioEncryp;
        private System.Windows.Forms.RadioButton radioDecryp;
        private System.Windows.Forms.Button GenKey;
        private System.Windows.Forms.DataGridView dgvListKey;
    }
}

