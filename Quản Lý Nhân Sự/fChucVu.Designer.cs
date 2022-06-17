namespace Quản_Lý_Nhân_Sự
{
    partial class fChucVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fChucVu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvCV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnQuaylai = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvCV);
            this.panel1.Location = new System.Drawing.Point(0, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 177);
            this.panel1.TabIndex = 0;
            // 
            // dgvCV
            // 
            this.dgvCV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCV.Location = new System.Drawing.Point(0, 0);
            this.dgvCV.Name = "dgvCV";
            this.dgvCV.RowHeadersWidth = 51;
            this.dgvCV.RowTemplate.Height = 24;
            this.dgvCV.Size = new System.Drawing.Size(537, 174);
            this.dgvCV.TabIndex = 0;
            this.dgvCV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCV_CellClick);
            this.dgvCV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCV_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(30, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Chức vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(24, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Chức vụ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(118, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 4;
            // 
            // btnQuaylai
            // 
            this.btnQuaylai.BackgroundImage = global::Quản_Lý_Nhân_Sự.Properties.Resources.butbut;
            this.btnQuaylai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuaylai.Image = global::Quản_Lý_Nhân_Sự.Properties.Resources.Back;
            this.btnQuaylai.Location = new System.Drawing.Point(0, -1);
            this.btnQuaylai.Name = "btnQuaylai";
            this.btnQuaylai.Size = new System.Drawing.Size(98, 39);
            this.btnQuaylai.TabIndex = 6;
            this.btnQuaylai.Text = "Quay lại";
            this.btnQuaylai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuaylai.UseVisualStyleBackColor = true;
            this.btnQuaylai.Click += new System.EventHandler(this.btnQuaylai_Click);
            // 
            // fChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(537, 331);
            this.Controls.Add(this.btnQuaylai);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fChucVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chức vụ";
            this.Load += new System.EventHandler(this.fChucVu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnQuaylai;
        private System.Windows.Forms.DataGridView dgvCV;
    }
}