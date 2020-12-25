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
    public partial class frmPhieuNhap : Form
    {
        handle.main handle = new handle.main();
        DataRow user;
        string IDUSER;
        public frmPhieuNhap(string _idUser)
        {
            InitializeComponent();
            IDUSER = _idUser;
        }

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            user = handle.nguoidung.findID(IDUSER);

            cboMaSP.DataSource = handle.get("SANPHAM");
            cboMaSP.DisplayMember = "TENSP";
            cboMaSP.ValueMember = "ID_SP";

            cboNhaCC.DataSource = handle.get("NHACUNGCAP");
            cboNhaCC.DisplayMember = "TENNCC";
            cboNhaCC.ValueMember = "ID_NCC";

            cboPhieuNhap.DataSource = handle.get("PHIEUNHAP");
            cboPhieuNhap.DisplayMember = "ID_PN";
            cboPhieuNhap.ValueMember = "ID_PN";

            dgvChiTietPN.DataSource = handle.get("CHITIETPN");
        }

        private void bntTaoPN_Click(object sender, EventArgs e)
        {
            txtMaPN.Text = handle.phieunhap.GeneratorID();
            dtpNgayNhap.Value = DateTime.Now;
            txtThanhTien.Text = "0";
        }

        private void btnLuuPN_Click(object sender, EventArgs e)
        {
            string idPN = txtMaPN.Text.Trim();
            string idNCC = cboNhaCC.SelectedValue.ToString().Trim();
            string idUser = user["ID_USER"].ToString().Trim();
            bool notice = handle.phieunhap.add(idPN, idUser, idNCC);
            if (notice)
            {
                MessageBox.Show("Thêm phiếu nhập thành công");
                //handle.save("PHIEUNHAP");
            }
            else
            {
                MessageBox.Show("Thêm phiếu nhập thất bại");
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string idPN = cboPhieuNhap.SelectedValue.ToString().Trim();
            string idSP = cboMaSP.SelectedValue.ToString().Trim();
            int soLuong = int.Parse(txtSoLuong.Text.Trim());
            int donGia = int.Parse(txtDonGia.Text.Trim());
            bool notice = handle.phieunhap.addCTPN(idPN, idSP, soLuong, donGia);
            if (notice)
            {
                MessageBox.Show("Thêm sản phẩm thành công");
                //handle.save("PHIEUNHAP");
            }
            else
            {
                MessageBox.Show("Thêm sản phẩm thất bại");
            }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnLuuThayDoi_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn lưu tất cả các thay đổi này ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                handle.save("PHIEUNHAP");
                handle.save("CHITIETPN");
            }
        }

        private void cboPhieuNhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            string MaPhieuNhap = cboPhieuNhap.SelectedValue.ToString();
            if (MaPhieuNhap.Trim().Count() > 0 && MaPhieuNhap != "System.Data.DataRowView")
            {
                txtMaPN.Text = MaPhieuNhap;
                txtThanhTien.Text = handle.phieunhap.ThanhTien(MaPhieuNhap).ToString();
                DataRow row = handle.phieunhap.find(MaPhieuNhap);
                dtpNgayNhap.Value = (DateTime)row["NGAYNHAP"];
            }
        }

        private void dgvChiTietPN_Click(object sender, EventArgs e)
        {
            int row_index = dgvChiTietPN.CurrentRow.Index;
            if (row_index >= 0)
            {
                string _idPN = dgvChiTietPN.Rows[row_index].Cells[0].Value.ToString();
                string _idSP = dgvChiTietPN.Rows[row_index].Cells[1].Value.ToString();
                DataRow row = handle.phieunhap.findCTPN(_idPN,_idSP);
                txtDonGia.Text = row["DONGIANHAP"].ToString();
                txtSoLuong.Text = row["SOLUONGNHAP"].ToString();
            }
        }

        private void btnInPhieuNhap_Click(object sender, EventArgs e)
        {
            frmInPhieuNhap inPhieuNhap = new frmInPhieuNhap();
            inPhieuNhap.Show();
        }
    }
}
