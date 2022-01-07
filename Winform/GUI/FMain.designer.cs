namespace Winform.GUI
{
    partial class FMain
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnQLNguoiDung = new System.Windows.Forms.Button();
            this.btnQLKhoaThi = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTour = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            pnlContent = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.AutoScroll = true;
            this.pnlMenu.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlMenu.Controls.Add(this.btnThoat);
            this.pnlMenu.Controls.Add(this.panel2);
            this.pnlMenu.Controls.Add(this.panel1);
            this.pnlMenu.Controls.Add(this.lbTour);
            this.pnlMenu.Controls.Add(this.flowLayoutPanel1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(250, 700);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Crimson;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(0, 660);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(250, 40);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.btnQLNguoiDung);
            this.panel2.Controls.Add(this.btnQLKhoaThi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 209);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 80);
            this.panel2.TabIndex = 4;
            // 
            // btnQLNguoiDung
            // 
            this.btnQLNguoiDung.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnQLNguoiDung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLNguoiDung.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLNguoiDung.FlatAppearance.BorderSize = 0;
            this.btnQLNguoiDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLNguoiDung.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNguoiDung.ForeColor = System.Drawing.Color.White;
            this.btnQLNguoiDung.Location = new System.Drawing.Point(0, 40);
            this.btnQLNguoiDung.Name = "btnQLNguoiDung";
            this.btnQLNguoiDung.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnQLNguoiDung.Size = new System.Drawing.Size(250, 40);
            this.btnQLNguoiDung.TabIndex = 2;
            this.btnQLNguoiDung.Text = "Quản lý người dùng";
            this.btnQLNguoiDung.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLNguoiDung.UseVisualStyleBackColor = false;
            this.btnQLNguoiDung.Click += new System.EventHandler(this.btnQLNguoiDung_Click);
            // 
            // btnQLKhoaThi
            // 
            this.btnQLKhoaThi.BackColor = System.Drawing.Color.White;
            this.btnQLKhoaThi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLKhoaThi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLKhoaThi.FlatAppearance.BorderSize = 0;
            this.btnQLKhoaThi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLKhoaThi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLKhoaThi.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnQLKhoaThi.Location = new System.Drawing.Point(0, 0);
            this.btnQLKhoaThi.Name = "btnQLKhoaThi";
            this.btnQLKhoaThi.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnQLKhoaThi.Size = new System.Drawing.Size(250, 40);
            this.btnQLKhoaThi.TabIndex = 0;
            this.btnQLKhoaThi.Text = "Quản lý khoá thi";
            this.btnQLKhoaThi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLKhoaThi.UseVisualStyleBackColor = false;
            this.btnQLKhoaThi.Click += new System.EventHandler(this.btnQLKhoaThi_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 54);
            this.panel1.TabIndex = 3;
            // 
            // lbTour
            // 
            this.lbTour.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTour.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTour.ForeColor = System.Drawing.Color.White;
            this.lbTour.Location = new System.Drawing.Point(0, 42);
            this.lbTour.Name = "lbTour";
            this.lbTour.Size = new System.Drawing.Size(250, 113);
            this.lbTour.TabIndex = 2;
            this.lbTour.Text = "Trung tâm ngoại ngữ";
            this.lbTour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(250, 42);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // pnlContent
            // 
            pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlContent.Location = new System.Drawing.Point(250, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new System.Drawing.Size(950, 700);
            pnlContent.TabIndex = 1;
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(pnlContent);
            this.Controls.Add(this.pnlMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Winform";
            this.Load += new System.EventHandler(this.FMain_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnQLNguoiDung;
        private System.Windows.Forms.Button btnQLKhoaThi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTour;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnThoat;
        private static System.Windows.Forms.Panel pnlContent;
    }
}
