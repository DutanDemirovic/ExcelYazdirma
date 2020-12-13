namespace Excel
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnCek = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cmbTablo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbVeriTabani = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1078, 390);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(595, 439);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(153, 55);
            this.btnExcel.TabIndex = 1;
            this.btnExcel.Text = "Excel\'e Aktar";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCek
            // 
            this.btnCek.Location = new System.Drawing.Point(450, 439);
            this.btnCek.Name = "btnCek";
            this.btnCek.Size = new System.Drawing.Size(128, 55);
            this.btnCek.TabIndex = 3;
            this.btnCek.Text = "Veriyi Çek";
            this.btnCek.UseVisualStyleBackColor = true;
            this.btnCek.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cmbTablo
            // 
            this.cmbTablo.FormattingEnabled = true;
            this.cmbTablo.Location = new System.Drawing.Point(264, 502);
            this.cmbTablo.Name = "cmbTablo";
            this.cmbTablo.Size = new System.Drawing.Size(121, 21);
            this.cmbTablo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 510);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tablo Seç :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 447);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "VeriTabanı Seç :";
            // 
            // cmbVeriTabani
            // 
            this.cmbVeriTabani.FormattingEnabled = true;
            this.cmbVeriTabani.Location = new System.Drawing.Point(264, 439);
            this.cmbVeriTabani.Name = "cmbVeriTabani";
            this.cmbVeriTabani.Size = new System.Drawing.Size(121, 21);
            this.cmbVeriTabani.TabIndex = 6;
            this.cmbVeriTabani.SelectedIndexChanged += new System.EventHandler(this.cmbVeriTabani_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 579);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbVeriTabani);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTablo);
            this.Controls.Add(this.btnCek);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnCek;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cmbTablo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbVeriTabani;
    }
}

