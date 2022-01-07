using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Winform.GUI.QLKhoaThi;
using Winform.GUI.QLNguoiDung;

namespace Winform.GUI
{
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
        }

        private void FMain_Load(object sender, EventArgs e)
        {
            GetPage(new FKhoaThi());
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Có phải bạn muốn thoát chương trình ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
                Application.Exit();
        }

        #region PUBLIC STATIC METHODS
        public static void GetPage(Form F)
        {
            foreach (Form form in pnlContent.Controls.OfType<Form>().ToArray()) { form.Close(); };
            F.TopLevel = false;
            F.Dock = DockStyle.Fill;
            try
            {
                F.Show();
                pnlContent.Controls.Add(F);
            }
            catch
            {
                MessageBox.Show("Lỗi thao tác!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        //
        // SetVisibleBtns
        //
        public static void SetVisible(Button button, bool b)
        {
            if (button.Visible != b && button.Enabled != b)
            {
                button.Visible = b;
                button.Enabled = b;
            }
        }

        public static void SetVisible(List<Button> buttons, bool b)
        {
            foreach (Button button in buttons)
            {
                if (button.Visible != b && button.Enabled != b)
                {
                    button.Visible = b;
                    button.Enabled = b;
                }
            }
        }
        #endregion



        #region Style
        private void resetStyles()
        {
            btnQLKhoaThi.BackColor = Color.DodgerBlue;
            btnQLKhoaThi.ForeColor = Color.White;
            btnQLNguoiDung.BackColor = Color.DodgerBlue;
            btnQLNguoiDung.ForeColor = Color.White;
        }

        private void btnQLKhoaThi_Click(object sender, EventArgs e)
        {
            resetStyles();
            btnQLKhoaThi.BackColor = Color.White;
            btnQLKhoaThi.ForeColor = Color.DodgerBlue;
            GetPage(new FKhoaThi());
        }

        private void btnQLNguoiDung_Click(object sender, EventArgs e)
        {
            resetStyles();
            btnQLNguoiDung.BackColor = Color.White;
            btnQLNguoiDung.ForeColor = Color.DodgerBlue;
            GetPage(new FNguoiDung());
        }
        #endregion
    }
}
