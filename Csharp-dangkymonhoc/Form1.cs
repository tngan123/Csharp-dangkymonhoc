using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_dangkymonhoc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbxnienkhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void clbmonhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            rad1.Checked = true;
            clbmonhoc.Items.Add("LT WIN",CheckState.Checked);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 2020; i <= 2025; i++)
            {
                cbxnienkhoa.Items.Add(i.ToString());
            }
            cbxlop.Items.Add("Ứng dụng phần mềm 1");
            cbxlop.Items.Add("Ứng dụng phần mềm 2");
            cbxlop.Items.Add("Ứng dụng phần mềm 3");
            cbxlop.Items.Add("Thiết kế đồ họa");
            cbxlop.Items.Add("Quản lý mạng");
            
        }

        private void btndangky_Click(object sender, EventArgs e)
        {
            string thongtin;
            thongtin = "Mã số sinh viên: " + txtmssv.Text;
            thongtin = "\nHọ và tên: " + txthovaten.Text;
            thongtin += "\nNiên khóa: " + cbxnienkhoa.SelectedItem;
            thongtin += "\nLớp: " + cbxlop.SelectedItem;

            string hocky = "";
            if (rad1.Checked)
            {
                hocky = rad1.Text;
            }
            else if (rad2.Checked)
            {
                hocky = rad2.Text;
            }
            else if (rad3.Checked)
            {
                hocky = rad3.Text;
            }
            else if (rad4.Checked)
            {
                hocky = rad4.Text;
            }
            thongtin += "\nĐã đăng ký học Học Kỳ " + hocky + " các môn học sau:";

            int stt = 1;
            foreach (var Item in clbmonhoc.CheckedItems)
            {
                thongtin += "\n" + stt + ". " + Item.ToString();
                stt++;
            }
            MessageBox.Show(thongtin, "Thông tin sinh viên");
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
