using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanLyKho
{
    /// <summary>
    /// Class formManager được dùng để hiển thị form con form cha. được viết theo kiểu singleton
    /// lấy instance của formManager
    /// formManager fm = formManager.GetInstance(this);
    /// tạo form con
    /// ChildForm childForm = new ChildForm();
    /// gọi phương thức showForm để hiển thị Form con
    ///fm.showForm(pnlContainer, childForm);
    /// </summary>
    public class formManager
    {
        private static formManager instance;

        private Form parentForm;

        private Form currentChildForm;

        private formManager(Form parentForm)
        {
            this.parentForm = parentForm;
        }

        public static formManager GetInstance (Form parentForm)
        {
            if (instance == null) instance = new formManager(parentForm);
            return instance;
        }

        public formManager() { }

        public void showForm(Panel pnlContainer ,Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            int formWidth = childForm.Width;
            int pnlWidth = pnlContainer.Width;
            int width = (pnlWidth - formWidth) / 2;
            pnlContainer.Padding = new Padding(width, 0, 0, 0);
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(childForm);
            pnlContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
