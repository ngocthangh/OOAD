﻿using QuanLySieuThi.DataBussiness;
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
    public partial class frmBaoCaoDoanhThu : Form
    {
        public frmBaoCaoDoanhThu()
        {
            InitializeComponent();
        }

        private void BaoCaoDoanhThu_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLapBaoCao_Click(object sender, EventArgs e)
        {
            decimal doanhthu = 0;
            grcDoanhThu.DataSource = HoaDonService.LoadDataTable();
            for(int i = 0; i < grvDoanhThu.RowCount; i++)
            {
                decimal tt = decimal.Parse(grvDoanhThu.GetRowCellValue(i, "TongTien").ToString());
                doanhthu += tt;
            }
            lblTongDoanhThu.Text = "Tổng Doanh Thu: " + doanhthu + "(VNĐ)";
        }
    }
}
