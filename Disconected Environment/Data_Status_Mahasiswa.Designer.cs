namespace Disconected_Environment
{
    partial class Data_Status_Mahasiswa
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
            this.Open = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Nama = new System.Windows.Forms.ComboBox();
            this.StatusMahasiswa = new System.Windows.Forms.ComboBox();
            this.TahunMasuk = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNIM = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(115, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(519, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(663, 24);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(75, 23);
            this.Open.TabIndex = 1;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(456, 219);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 2;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(456, 273);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(456, 318);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 4;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Nama
            // 
            this.Nama.FormattingEnabled = true;
            this.Nama.Location = new System.Drawing.Point(296, 219);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(121, 24);
            this.Nama.TabIndex = 5;
            this.Nama.SelectedIndexChanged += new System.EventHandler(this.Nama_SelectedIndexChanged);
            // 
            // StatusMahasiswa
            // 
            this.StatusMahasiswa.FormattingEnabled = true;
            this.StatusMahasiswa.Location = new System.Drawing.Point(296, 317);
            this.StatusMahasiswa.Name = "StatusMahasiswa";
            this.StatusMahasiswa.Size = new System.Drawing.Size(121, 24);
            this.StatusMahasiswa.TabIndex = 6;
            // 
            // TahunMasuk
            // 
            this.TahunMasuk.FormattingEnabled = true;
            this.TahunMasuk.Location = new System.Drawing.Point(296, 361);
            this.TahunMasuk.Name = "TahunMasuk";
            this.TahunMasuk.Size = new System.Drawing.Size(121, 24);
            this.TahunMasuk.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nama Mahasiswa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nomor Induk Mahasiswa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Status Mahasiswa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tahun Masuk";
            // 
            // txtNIM
            // 
            this.txtNIM.AutoSize = true;
            this.txtNIM.Location = new System.Drawing.Point(293, 276);
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.Size = new System.Drawing.Size(43, 16);
            this.txtNIM.TabIndex = 12;
            this.txtNIM.Text = "txtNIM";
            // 
            // Data_Status_Mahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNIM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TahunMasuk);
            this.Controls.Add(this.StatusMahasiswa);
            this.Controls.Add(this.Nama);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Data_Status_Mahasiswa";
            this.Text = "Data_Status_Mahasiswa";
            this.Load += new System.EventHandler(this.Data_Status_Mahasiswa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.ComboBox Nama;
        private System.Windows.Forms.ComboBox StatusMahasiswa;
        private System.Windows.Forms.ComboBox TahunMasuk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtNIM;
    }
}