using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThinkProManager.GUI
{
    public partial class frmHoaDon : Form
    {
        handle.main handle = new handle.main();
        DataRow user;
        public string IDUSER;
        public frmHoaDon(string _idUser)
        {
            InitializeComponent();
            IDUSER = _idUser;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void lblSoLuong_Click(object sender, EventArgs e)
        {

        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDonGia_Click(object sender, EventArgs e)
        {

        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            user = handle.nguoidung.findID(IDUSER);

            cboxMaHoaDon.DataSource = handle.get("HOADON");
            cboxMaHoaDon.DisplayMember = "ID_HD";
            cboxMaHoaDon.ValueMember = "ID_HD";

            cboMaKH.DataSource = handle.get("NGUOIDUNG");
            cboMaKH.DisplayMember = "HOTEN";
            cboMaKH.ValueMember = "ID_USER";

            cboMaSP.DataSource = handle.get("SANPHAM");
            cboMaSP.DisplayMember = "TENSP";
            cboMaSP.ValueMember = "ID_SP";


            cboMaNV.DataSource = handle.JoinDataTables(handle.get("NGUOIDUNG"), handle.get("NHANVIEN"), (row1, row2) => row1.Field<string>("ID_USER") == row2.Field<string>("ID_USER"));
            cboMaNV.DisplayMember = "HOTEN";
            cboMaNV.ValueMember = "ID_USER";

            gridViewHD.AutoGenerateColumns = false;
        }

        private void cboxMaHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idHD = cboxMaHoaDon.SelectedValue.ToString().Trim();
            if(idHD != "System.Data.DataRowView")
            {
                DataRow hoadon = handle.hoadon.findHD(idHD);
                txtMaHoaDon.Text = hoadon["ID_HD"].ToString().Trim();
                cboMaKH.SelectedValue = hoadon["ID_USER"].ToString().Trim();
                dtpNgayBan.Value = hoadon.Field<DateTime>("NGAYLAPHD");
                DataTable CTHD = handle.hoadon.getTableCTHD(idHD);
                gridViewHD.DataSource = CTHD;
                txtTongTien.Text = CTHD.AsEnumerable().Sum(x => Convert.ToInt32(x["THANHTIEN"])).ToString();
                txtSoLuongSanPham.Text = CTHD.Rows.Count.ToString();
            }
        }

        private void cboMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idSP = cboMaSP.SelectedValue.ToString().Trim();
            if (idSP != "System.Data.DataRowView")
            {
                DataRow sanpham = handle.sanpham.find(idSP);
                txtDonGia.Text = sanpham["GIATIEN"].ToString().Trim();
               
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            clearControl();
            txtMaHoaDon.Text = handle.hoadon.GeneratorID();
            dtpNgayBan.Value = DateTime.Now;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            cboxMaHoaDon.Enabled = false;
            groupBox1.Enabled = false;
            grbxHoaDon.Enabled = false;
            gridViewHD.Enabled = false;
            gxboxThongTinMatHang.Enabled = false;
            cboMaNV.Enabled = false;
            cboMaNV.SelectedValue = IDUSER;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maHD = txtMaHoaDon.Text;
            DateTime ngayLapHD = dtpNgayBan.Value;
            string idUser = cboMaKH.SelectedValue.ToString();
            string idNhanVien = cboMaNV.SelectedValue.ToString();
            bool notice = handle.hoadon.add(maHD,idUser,ngayLapHD,idNhanVien);
            if (notice)
            {
                clearControl();
                MessageBox.Show("Thêm hóa đơn thành công");
                cboxMaHoaDon.SelectedValue = maHD;
            }
            else
            {
                MessageBox.Show("Thêm hóa đơn thất bại");
            }

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            cboxMaHoaDon.Enabled = true;
            groupBox1.Enabled = true;
            grbxHoaDon.Enabled = true;
            gridViewHD.Enabled = true;
            gxboxThongTinMatHang.Enabled = true;
            cboMaNV.Enabled = true;
        }

        private void btnXoaCTHD_Click(object sender, EventArgs e)
        {
            string maHD = txtMaHoaDon.Text.Trim();
            if (maHD.Length > 0)
            {
                string maSP = cboMaSP.SelectedValue.ToString();
                bool notice = handle.hoadon.deleteCTHD(maHD, maSP);
                if (notice)
                {
                    MessageBox.Show("Xóa sản phẩm từ hóa đơn thành công");
                    DataTable CTHD = handle.hoadon.getTableCTHD(maHD);
                    gridViewHD.DataSource = CTHD;
                    txtTongTien.Text = CTHD.AsEnumerable().Sum(x => Convert.ToInt64(x["THANHTIEN"])).ToString();
                    txtSoLuongSanPham.Text = CTHD.Rows.Count.ToString();
                }
                else
                {
                    MessageBox.Show("Xóa sản phẩm từ hóa đơn thất bại");
                }

            }
            else
            {
                MessageBox.Show("Chọn hóa đơn trước khi xóa");
            }
        }

        private void btnThemCTHD_Click(object sender, EventArgs e)
        {
            string maHD = txtMaHoaDon.Text.Trim();
            if(maHD.Length > 0)
            {
                if(txtSoLuong.Text.Trim().Length > 0)
                {
                    string maSP = cboMaSP.SelectedValue.ToString();
                    int soluong = int.Parse(txtSoLuong.Text);
                    bool notice = handle.hoadon.addCTHD(maHD, maSP, soluong);
                    if (notice)
                    {
                        MessageBox.Show("Thêm sản phẩm vào hóa đơn thành công");
                        DataTable CTHD = handle.hoadon.getTableCTHD(maHD);
                        gridViewHD.DataSource = CTHD;
                        txtTongTien.Text = CTHD.AsEnumerable().Sum(x => Convert.ToInt64(x["THANHTIEN"])).ToString();
                        txtSoLuongSanPham.Text = CTHD.Rows.Count.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Thêm sản phẩm vào hóa đơn hóa đơn thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Thêm số lượng sản phẩm");
                }
                
            }
            else
            {
                MessageBox.Show("Chọn hóa đơn trước khi thêm");
            }
               

        }

        private void clearControl()
        {
            txtMaHoaDon.Clear();
            txtSoLuong.Clear();
            gridViewHD.RowCount = 0;
        }

        private void gridViewHD_Click(object sender, EventArgs e)
        {
            int row_index = (gridViewHD.CurrentRow != null)?gridViewHD.CurrentRow.Index:-1;
            if(row_index >= 0)
            {

                cboMaSP.SelectedValue = gridViewHD.Rows[row_index].Cells[0].Value.ToString();
                txtSoLuong.Text = gridViewHD.Rows[row_index].Cells[3].Value.ToString();
                txtDonGia.Text = gridViewHD.Rows[row_index].Cells[4].Value.ToString();
            }    
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            clearControl();

            user = handle.nguoidung.findID(IDUSER);

            cboxMaHoaDon.DataSource = handle.get("HOADON");
            cboxMaHoaDon.DisplayMember = "ID_HD";
            cboxMaHoaDon.ValueMember = "ID_HD";

            cboMaKH.DataSource = handle.get("NGUOIDUNG");
            cboMaKH.DisplayMember = "HOTEN";
            cboMaKH.ValueMember = "ID_USER";

            cboMaSP.DataSource = handle.get("SANPHAM");
            cboMaSP.DisplayMember = "TENSP";
            cboMaSP.ValueMember = "ID_SP";


            cboMaNV.DataSource = handle.JoinDataTables(handle.get("NGUOIDUNG"), handle.get("NHANVIEN"), (row1, row2) => row1.Field<string>("ID_USER") == row2.Field<string>("ID_USER"));
            cboMaNV.DisplayMember = "HOTEN";
            cboMaNV.ValueMember = "ID_USER";

            gridViewHD.AutoGenerateColumns = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            cboxMaHoaDon.Enabled = true;
            groupBox1.Enabled = true;
            grbxHoaDon.Enabled = true;
            gridViewHD.Enabled = true;
            gxboxThongTinMatHang.Enabled = true;
            cboMaNV.Enabled = true;
        }

        private void frmHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (handle.get("HOADON").GetChanges() != null || handle.get("CHITIETHD").GetChanges() != null)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn lưu tất cả các thay đổi này ?", "Thông Báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    bool r1 = handle.save("HOADON");
                    bool r2 = handle.save("CHITIETHD");
                    if (r1 && r2)
                    {
                        MessageBox.Show("Lưu thành công vào CSDL");
                    }
                    else
                    {
                        MessageBox.Show("Lưu thất bại. Kiểm tra dữ liệu trước khi lưu");
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn tắt bảng này không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            
        }

        private void btnLuuThayDoi_Click(object sender, EventArgs e)
        {
            if (handle.get("HOADON").GetChanges() != null || handle.get("CHITIETHD").GetChanges() != null)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn lưu tất cả các thay đổi này ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    bool r1 = handle.save("HOADON");
                    bool r2 = handle.save("CHITIETHD");
                    if(r1 && r2)
                    {
                        MessageBox.Show("Lưu thành công vào CSDL");
                    }
                    else
                    {
                        MessageBox.Show("Lưu thất bại. Kiểm tra dữ liệu trước khi lưu");
                    }
                }
            }    
           
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            frmInHoaDon f2 = new frmInHoaDon();
            f2.MdiParent = this.ParentForm;
            f2.Show();
        }
    }
}
