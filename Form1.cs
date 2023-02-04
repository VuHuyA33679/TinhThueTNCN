using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TinhThue
{
    public partial class TinhThue : Form
    {
        public TinhThue()
        {
            InitializeComponent();

            comboBoxMonth.DataSource = listMonth;
            comboBoxMonth.DisplayMember = "Name";


        }
        double[] thunhap = new double[12];
        double[] thunhaptinhthue = new double[12];
        double[] tienthue = new double[12];

        List<Month> listMonth = new List<Month>(12)
            {
                new Month(){Name = "Tháng 1"},
                new Month(){Name = "Tháng 2"},
                new Month(){Name = "Tháng 3"},
                new Month(){Name = "Tháng 4"},
                new Month(){Name = "Tháng 5"},
                new Month(){Name = "Tháng 6"},
                new Month(){Name = "Tháng 7"},
                new Month(){Name = "Tháng 8"},
                new Month(){Name = "Tháng 9"},
                new Month(){Name = "Tháng 10"},
                new Month(){Name = "Tháng 11"},
                new Month(){Name = "Tháng 12"}
            };
        double giaCanh = 0, ngPhuThuoc = 0;
        double soNgPhuThuoc = 0;
        double Tax(double x)
        {
            if (x > 80) return 18.15 + 0.35 * (x - 80);
            else if (x > 52) return 9.75 + 0.3 * (x - 52);
            else if (x > 32) return 4.75 + 0.25 * (x - 32);
            else if (x > 18) return 1.95 + 0.2 * (x - 18);
            else if (x > 10) return 0.75 + 0.15 * (x - 10);
            else if (x > 5) return 0.25 + 0.1 * (x - 5);
            else return 0.05 * x;
        }

        double TaxYear(double x)
        {
            if (x > 960) return 217.8 + 0.35 * (x - 960);
            else if (x > 624) return 117 + 0.3 * (x - 624);
            else if (x > 384) return 57 + 0.25 * (x - 384);
            else if (x > 216) return 23.4 + 0.2 * (x - 216);
            else if (x > 120) return 9 + 0.15 * (x - 120);
            else if (x > 60) return 3 + 0.1 * (x - 60);
            else return 0.05 * x;
        }

        private void comboBoxMonth_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonTaxThisMonth_Click(object sender, EventArgs e)
        {
            while (thunhap[comboBoxMonth.SelectedIndex] < 0) ;
            if (radioButtonYes.Checked == false)
                thunhaptinhthue[comboBoxMonth.SelectedIndex] = Math.Max(thunhap[comboBoxMonth.SelectedIndex] - giaCanh - (soNgPhuThuoc * ngPhuThuoc), 0.0);
            else
                thunhaptinhthue[comboBoxMonth.SelectedIndex] = Math.Max(thunhap[comboBoxMonth.SelectedIndex] * 0.91 - giaCanh - (soNgPhuThuoc * ngPhuThuoc), 0.0);
            tienthue[comboBoxMonth.SelectedIndex] = Tax(thunhaptinhthue[comboBoxMonth.SelectedIndex]);
            labelTinhThueThang.Text = listMonth[comboBoxMonth.SelectedIndex].Name + " có thuế là: " + tienthue[comboBoxMonth.SelectedIndex] + " triệu đồng";
            labelTinhThueThang.Visible = true;
        }

        private void textBoxNgLaoDong_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNgLaoDong.Text == null)
            {
                MessageBox.Show("Mục này không được để trống!", "Thông báo");
            }
            else
            {
                bool b = double.TryParse(textBoxNgLaoDong.Text, out giaCanh);
                if (b == false)
                {
                    MessageBox.Show("Giá trị nhập vào không hợp lệ", "Thông báo");
                    textBoxNgLaoDong.Clear();
                }
            }
            
        }

        private void textBoxNgPhuThuoc_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNgPhuThuoc.Text == null)
            {
                MessageBox.Show("Mục này không được để trống!", "Thông báo");
            }
            else
            {
                bool b = double.TryParse(textBoxNgPhuThuoc.Text, out ngPhuThuoc);
                if (b == false)
                {
                    MessageBox.Show("Giá trị nhập vào không hợp lệ", "Thông báo");
                    textBoxNgPhuThuoc.Clear();
                }
            }

        }

        private void textBoxSoNgPhuThuoc_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSoNgPhuThuoc.Text == null)
            {
                MessageBox.Show("Mục này không được để trống!", "Thông báo");
            }
            else
            {
                bool b = double.TryParse(textBoxSoNgPhuThuoc.Text, out soNgPhuThuoc);
                if (b == false)
                {
                    MessageBox.Show("Giá trị nhập vào không hợp lệ", "Thông báo");
                    textBoxSoNgPhuThuoc.Clear();
                }
            }
        }

        private void buttonTaxThisYear_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            double tongThuNhap = 0;
            double tongThue = 0;

            string path = "output.txt";
            StreamWriter file1 = new StreamWriter(path);
            file1.WriteLine("Tháng     " +" Thu nhập    " + " Thuế thu nhập ");
            for (int i = 0; i < 12; i++)
            {
                while (thunhap[i] < 0) ;
                if (radioButtonYes.Checked == false)
                    thunhaptinhthue[i] = Math.Max(thunhap[i] - giaCanh - (soNgPhuThuoc * ngPhuThuoc), 0.0);
                else
                    thunhaptinhthue[i] = Math.Max(thunhap[i] * 0.91 - giaCanh - (soNgPhuThuoc * ngPhuThuoc), 0.0);
                tienthue[i] = Tax(thunhaptinhthue[i]);
                file1.WriteLine(listMonth[i].Name + "           " + thunhap[i] + "                 " + tienthue[i]);
                tongThuNhap += thunhap[i];
                tongThue += tienthue[i];
            }
            file1.WriteLine("Thuế thu nhập cả năm tạm nộp: " + tongThue);         // Thuế TNCN tạm nộp

            // Tính thu nhập tính thuế của cả năm trường hợp có bảo hiểm xã hội hoặc không
            double thunhaptinhthuecanam;
            if (radioButtonYes.Checked == false)
                // Không có bảo hiểm xã hội
                thunhaptinhthuecanam = Math.Max(tongThuNhap - giaCanh * 12 - soNgPhuThuoc * ngPhuThuoc * 12, 0.0);
            else
                // Có bảo hiểm xã hội
                thunhaptinhthuecanam = Math.Max(tongThuNhap * 0.91 - giaCanh * 12 - soNgPhuThuoc * ngPhuThuoc * 12, 0.0);
            // cout << thunhaptinhthuecanam << endl;
            double thuecanam = TaxYear(thunhaptinhthuecanam);                 // Tính tiền thuế thu nhập cá nhân cả năm


            file1.WriteLine("Thuế thu nhập cả năm: " + thuecanam);                  // Thuế TNCN thực tế
            file1.WriteLine("Tiền thuế nhận lại: " + (tongThue - thuecanam));         // Tiền thuế nhận lại
            file1.Close();
            f2.Show();
        }

        private void comboBoxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelThongBaoUpdate.Visible = false;
            textBoxThuNhap.Clear();
            labelTinhThueThang.Visible = false;
        }

        private void buttonUpdate_Click(object sender, EventArgs e) //ấn nút này thì lấy int của text box thu nhập gán cho index của combobox tháng tương ứng
        {
            bool b = double.TryParse(textBoxThuNhap.Text, out thunhap[comboBoxMonth.SelectedIndex]);
            labelThongBaoUpdate.Text = "Đã cập nhật lương " + listMonth[comboBoxMonth.SelectedIndex].Name;
            labelThongBaoUpdate.Visible = true;
        }
    }

    public class Month
    {
        public string Name { get; set; }
    }
}
