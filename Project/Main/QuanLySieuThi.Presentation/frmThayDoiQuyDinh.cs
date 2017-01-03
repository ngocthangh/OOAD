using QuanLySieuThi.DataBussiness;
using QuanLySieuThi.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThi.Presentation
{
    public partial class frmThayDoiQuyDinh : Form
    {
        int slTonToiThieu, slQuayToiThieu, tiLeDoiThuong;
        public frmThayDoiQuyDinh()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThayDoiQuyDinh_Load(object sender, EventArgs e)
        {
            DataTable ThamSo = ThamSoService.LoadDataTable();
            if(ThamSo != null)
            {
                for(int i = 0; i < ThamSo.Rows.Count; i++)
                {
                    if(ThamSo.Rows[i].Field<string>("TenThamSo") == "SLTonToiThieu")
                    {
                        slTonToiThieu = ThamSo.Rows[i].Field<int>("GiaTri");
                        tedSLTonToiThieu.Text = slTonToiThieu.ToString();
                    }else if (ThamSo.Rows[i].Field<string>("TenThamSo") == "SLQuayToiThieu")
                    {
                        slQuayToiThieu = ThamSo.Rows[i].Field<int>("GiaTri");
                        tedSLQuayToiThieu.Text = slQuayToiThieu.ToString();
                    }
                    else if(ThamSo.Rows[i].Field<string>("TenThamSo") == "TiLeDoiThuong")
                    {
                        tiLeDoiThuong = ThamSo.Rows[i].Field<int>("GiaTri");
                        tedTiLeDiemThuong.Text = tiLeDoiThuong.ToString();
                    }
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(tedSLTonToiThieu.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng tồn tối thiểu");
                return;
            }
            if (tedSLQuayToiThieu.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng quầy tối thiểu");
                return;
            }
            if (tedTiLeDiemThuong.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tỉ lệ đổi thưởng");
                return;
            }
            int sltt = 0, slqtt = 0, tldt = 0;
            try
            {
                sltt = int.Parse(tedSLTonToiThieu.Text);
                if(sltt < 0)
                {
                    MessageBox.Show("Số lượng tồn phải >= 0");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Số lượng tồn phải là số, vui lòng nhập lại");
                return;
            }
            try
            {
                slqtt = int.Parse(tedSLQuayToiThieu.Text);
                if (slqtt < 0)
                {
                    MessageBox.Show("Số lượng quầy phải >= 0");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Số lượng quầy phải là số, vui lòng nhập lại");
                return;
            }
            try
            {
                tldt = int.Parse(tedTiLeDiemThuong.Text);
                if (tldt < 0)
                {
                    MessageBox.Show("Tỉ lệ đổi thưởng phải >= 0");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("tỉ lệ đổi thưởng phải là số, vui lòng nhập lại");
                return;
            }
            if(sltt == slTonToiThieu && slqtt == slQuayToiThieu && tldt == tiLeDoiThuong)
            {
                MessageBox.Show("Bạn chưa sửa giá trị!");
                return;
            }
            int num = 0;
            if(sltt != slTonToiThieu)
            {
                if (ThamSoService.Update(new ThamSo("SLTonToiThieu", sltt)))
                {
                    slTonToiThieu = sltt;
                }
                else {
                    MessageBox.Show("Update không thành công!");
                    return;
                }
            }
            if (slqtt != slQuayToiThieu)
            {
                if (ThamSoService.Update(new ThamSo("SLQuayToiThieu", slqtt)))
                {
                    slQuayToiThieu = slqtt;
                }
                else {
                    MessageBox.Show("Update không thành công!");
                    return;
                }
            }
            if (tldt != tiLeDoiThuong)
            {
                if (ThamSoService.Update(new ThamSo("TiLeDoiThuong", tldt)))
                {
                    tiLeDoiThuong = tldt;
                }
                else {
                    MessageBox.Show("Update không thành công!");
                    return;
                }
            }
            MessageBox.Show("Update thành công!");
        }
    }
}
