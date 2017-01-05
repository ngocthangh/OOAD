using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySieuThi.DataBussiness;
using QuanLySieuThi.DataModel;
using DevExpress.XtraEditors;

namespace QuanLySieuThi.Presentation
{
    public partial class frmChiTietKiemKe_Them : Form
    {
        public static string MaPKK;
        public bool isDataChanged;
        public frmChiTietKiemKe_Them()
        {
            InitializeComponent();
            isDataChanged = false;
            lueHangHoa.Properties.ValueMember = "MaHangHoa";
            lueHangHoa.Properties.DisplayMember = "TenHangHoa";
            lueHangHoa.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaHangHoa", 50, "Mã Hàng Hóa"));
            lueHangHoa.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenHangHoa", 100, "Tên Hàng Hóa"));
            lueHangHoa.Properties.DataSource = HangHoaService.LoadDataTable();
        }

        public bool validateForm()
        {
            int check;
            if (lueHangHoa.Text.Trim() == "Hàng hóa")
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin!\nVui lòng chọn hàng hóa!");
                lueHangHoa.Focus();
                return false;
            }
            if (txtSLTonTrenQuay.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin!\nVui lòng nhập số lượng hàng hóa trên quầy!");
                txtSLTonTrenQuay.Focus();
                return false;
            }
            if (txtSLTonTrongKho.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin!\nVui lòng nhập số lượng hàng hóa trong kho!");
                txtSLTonTrongKho.Focus();
                return false;
            }
            try
            {
                check = Convert.ToInt32(txtSLTonTrenQuay.Text.ToString());
                if (check < 0)
                {
                    MessageBox.Show("Số lượng trên quầy không được nhỏ hơn 0\nVui lòng nhập lại!");
                    txtSLTonTrenQuay.Focus();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Số lượng trên quầy phải là số\nVui lòng nhập lại!");
                txtSLTonTrenQuay.Focus();
                return false;
            }

            try
            {
                check = Convert.ToInt32(txtSLTonTrongKho.Text.ToString());
                if (check < 0)
                {
                    MessageBox.Show("Số lượng trong kho không được nhỏ hơn 0\nVui lòng nhập lại!");
                    txtSLTonTrongKho.Focus();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Số lượng trong kho phải là số\nVui lòng nhập lại!");
                txtSLTonTrongKho.Focus();
                return false;
            }
            return true;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            DataTable dtCTKK = ChiTietKiemKeService.LoadDataTable();
            if (validateForm())
            {
                int i;
                for (i = 0; i < dtCTKK.Rows.Count; i++)
                {
                    if (lueHangHoa.EditValue.ToString().Equals(dtCTKK.Rows[i][0].ToString()))
                    {
                        XtraMessageBox.Show("Hàng hóa đã được kiểm kê");
                        return;
                    }
                }
                ChiTietKiemKe ctkk = new ChiTietKiemKe();
                ctkk.MaHangHoa = lueHangHoa.EditValue.ToString();
                ctkk.MaPhieuKiemKe = MaPKK;
                ctkk.SLTonTrenQuay = Convert.ToInt32(txtSLTonTrenQuay.Text.ToString().Trim());
                ctkk.SLTonTrongKho = Convert.ToInt32(txtSLTonTrongKho.Text.ToString().Trim());
                if (ChiTietKiemKeService.Insert(ctkk))
                {
                    isDataChanged = true;
                    XtraMessageBox.Show("Thêm thành công");
                }
                else XtraMessageBox.Show("Thêm thất bại");

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
