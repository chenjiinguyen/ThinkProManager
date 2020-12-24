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
    public partial class frmQuanLyNhanVien : Form
    {
        handle.main handle = new handle.main();
        DataRow user;
        string IDUSER;
        DataRow dataNhanVien = null;
        public frmQuanLyNhanVien(string _idUser)
        {
            IDUSER = _idUser;
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            user = handle.nguoidung.findID(IDUSER);
            dgvNguoiDung.AutoGenerateColumns = false;
            dgvNguoiDung.DataSource = handle.get("NGUOIDUNG");

            cboChucVu.DataSource = handle.get("VAITRO");
            cboChucVu.DisplayMember = "TENVAITRO";
            cboChucVu.ValueMember = "ID_VAITRO";

            var listGioiTinh = new List<string> { "Nam","Nữ" };
            List<KeyValuePair<string, string>> DataSourceGioiTinh = new List<KeyValuePair<string, string>>();
            for (int i = 0; i < listGioiTinh.Count; i++)
            {
                DataSourceGioiTinh.Add(new KeyValuePair<string, string>(listGioiTinh[i], listGioiTinh[i]));
            }
            cboGioiTinh.DataSource = DataSourceGioiTinh;
            cboGioiTinh.ValueMember = "Key";
            cboGioiTinh.DisplayMember = "Value";

            setEnableNV(false);
        }

		private void dgvNguoiDung_Click(object sender, EventArgs e)
		{
            int row_index = dgvNguoiDung.CurrentRow.Index;
            if (row_index >= 0)
            {
                string _idSP = dgvNguoiDung.Rows[row_index].Cells[0].Value.ToString();
                DataRow row = handle.nguoidung.findID(_idSP);
                txtMaNV.Text = row["ID_USER"].ToString();
                txtHoTen.Text = row["HOTEN"].ToString();
                txtEmail.Text = row["EMAIL"].ToString();
                txtSDT.Text = row["DIENTHOAI"].ToString();
                txtDiaChi.Text = row["DIACHI"].ToString();
                txtAvatar.Text = row["AVATAR"].ToString();
                cboChucVu.SelectedValue = row["ID_VAITRO"].ToString();
                cboGioiTinh.SelectedValue = row["GIOITINH"].ToString();
                pboxAvatar.InitialImage = null;
                pboxAvatar.Image = null;
                pboxAvatar.Update();
                try
                {
                  
                    pboxAvatar.Load(row["AVATAR"].ToString());
                }
                catch (Exception ex)
                {

                }
                dataNhanVien = handle.nguoidung.findNV(_idSP);
                if (dataNhanVien != null)
                {
                    setEnableNV(true);
                    txtHeSoLuong.Text = dataNhanVien["HESOLUONG"].ToString();
                    if (dataNhanVien.Field<bool>("TINHTRANG"))
                        rdbDiLam.Checked = true;
                    else
                        rdbDaNghi.Checked = true;
                }
                else
                {
                    setEnableNV(false);
                }
            }
                
		}

        private void ResetEle()
        {
            txtMaNV.Clear();
            txtHoTen.Clear();
            txtEmail.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtAvatar.Clear();
            pboxAvatar.InitialImage = null;
            pboxAvatar.Image = null;
            pboxAvatar.Update();
            setEnableNV(false);
        }

        private void setEnableNV(bool _Checked)
        {
            foreach (Control c in gboxNV.Controls)
            {
                if (c is TextBox)
                {
                    c.Enabled = _Checked;
                    c.Text = "";
                }
                if (c is RadioButton)
                {
                    c.Enabled = _Checked;
                    ((RadioButton)c).Checked = false;
                    
                }
            }
            gboxNV.Enabled = _Checked;
            chbxNhanVien.Checked = _Checked;
        }

		private void chbxNhanVien_CheckedChanged(object sender, EventArgs e)
		{
            setEnableNV(chbxNhanVien.Checked);
            if (chbxNhanVien.Checked) {
                string idUser = txtMaNV.Text.Trim();
                if (dataNhanVien == null && idUser.Length > 0)
                {
                    dataNhanVien = handle.get("NHANVIEN").NewRow();
                    dataNhanVien["ID_USER"] = idUser;
                }
                btnLuuNV.Enabled = false;
            }

        }

		private void btnClear_Click(object sender, EventArgs e)
		{
            ResetEle();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string idUser = txtMaNV.Text.Trim();
            if (checkValidate())
            {
                string AnhAvatar = txtAvatar.Text.Trim();
                if (Uri.IsWellFormedUriString(AnhAvatar, UriKind.Absolute))
                {
                    string email = txtEmail.Text.Trim();
                    if (handle.nguoidung.IsValidEmail(email)) {
                        if (handle.nguoidung.findID(idUser) == null)
                        {
                            string idRole = cboChucVu.SelectedValue.ToString();
                            string gioiTinh = cboGioiTinh.SelectedValue.ToString();
                            string hoTen = txtHoTen.Text.Trim();
                            string dienThoai = txtSDT.Text.Trim();
                            string diaChi = txtDiaChi.Text.Trim();
                            bool result = handle.nguoidung.add(idUser,email, idRole, hoTen, dienThoai, diaChi, gioiTinh, AnhAvatar);
                            if (result)
                            {
                                bool result_tt = true;
								if (dataNhanVien != null && chbxNhanVien.Checked)
								{
									result_tt = handle.nguoidung.addNV(dataNhanVien);
								}
								if (result_tt)
                                {
                                    MessageBox.Show("Thêm người dùng thành công");
                                    ResetEle();
                                }
                                else
                                {
                                    MessageBox.Show("Thông tin thêm của sản phẩm bị lỗi");
                                }

                            }
                            else
                            {
                                MessageBox.Show("Có lỗi khi thêm sản phẩm");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Người dùng đã tồn tại. Vui lòng thử lại");
                        }
                    } else {
                        MessageBox.Show("Vui lòng nhập đúng định dạng Email");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Url ảnh không đúng");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các trường");
            }
        }

        private bool checkValidate()
        {
            bool check = true;
            foreach (Control c in gbxThongTinNguoiDung.Controls)
            {
                if (c is TextBox)
                {
                    if (((TextBox)c).Text.Trim().Length == 0)
                    {
                        check = false;
                        break;
                    }
                }
            }
            if (chbxNhanVien.Checked)
            {
                if (!rdbDiLam.Checked && !rdbDaNghi.Checked)
                    check = false;
                if (txtHeSoLuong.Text.Trim().Length == 0)
                    check = false;
            }
            
            return check;
        }

		private void btnluu_Click(object sender, EventArgs e)
		{
            DialogResult result = MessageBox.Show("Bạn có muốn lưu tất cả các thay đổi này ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                handle.save("NGUOIDUNG");
                handle.save("NHANVIEN");
            }
        }

		private void frmQuanLyNhanVien_FormClosing(object sender, FormClosingEventArgs e)
		{
            DialogResult result = MessageBox.Show("Bạn có muốn lưu tất cả các thay đổi này ?", "Thông Báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                handle.save("NGUOIDUNG");
                handle.save("NHANVIEN");
            }
            else if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

		private void btnsua_Click(object sender, EventArgs e)
		{
            string idUser = txtMaNV.Text.Trim();
            if (checkValidate())
            {
                string AnhAvatar = txtAvatar.Text.Trim();
                if (Uri.IsWellFormedUriString(AnhAvatar, UriKind.Absolute))
                {
                    string email = txtEmail.Text.Trim();
                    if (handle.nguoidung.IsValidEmail(email))
                    {
                        if (handle.nguoidung.findID(idUser) != null)
                        {
                            string idRole = cboChucVu.SelectedValue.ToString();
                            string gioiTinh = cboGioiTinh.SelectedValue.ToString();
                            string hoTen = txtHoTen.Text.Trim();
                            string dienThoai = txtSDT.Text.Trim();
                            string diaChi = txtDiaChi.Text.Trim();
                            bool result = handle.nguoidung.update(idUser, email, idRole, hoTen, dienThoai, diaChi, gioiTinh, AnhAvatar);
                            if (result)
                            {
                                bool result_tt = true;
                                if (dataNhanVien != null && chbxNhanVien.Checked)
                                {
                                    if (handle.nguoidung.findNV(idUser) != null)
                                        result_tt = handle.nguoidung.updateNV(dataNhanVien);
                                    else
                                        result_tt = handle.nguoidung.addNV(dataNhanVien);
                                }
                                else
                                {
                                    if (handle.nguoidung.findNV(idUser) != null)
                                        result_tt = handle.nguoidung.deleteNV(idUser);
                                }
                                if (result_tt)
                                {
                                    MessageBox.Show("Chỉnh sửa người dùng thành công");
                                    ResetEle();
                                }
                                else
                                {
                                    MessageBox.Show("Thành phần nhân viên của người dùng bị lỗi");
                                }

                            }
                            else
                            {
                                MessageBox.Show("Có lỗi khi sửa người dùng");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Người dùng chưa tồn tại. Vui lòng thử lại");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập đúng định dạng Email");
                    }

                }
                else
                {
                    MessageBox.Show("Url ảnh không đúng");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các trường");
            }
        }

		private void btnxoa_Click(object sender, EventArgs e)
		{
            string idUser = txtMaNV.Text.Trim();
            if (handle.nguoidung.findID(idUser) != null)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa người dùng này ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    bool final_result = handle.nguoidung.delete(idUser);
                    if (final_result)
                    {
                        MessageBox.Show("Xóa sản phẩm thành công");
                    }
                    else
                    {
                        MessageBox.Show("Xóa sản phẩm thất bại");
                    }
                }
            }
            else
            {
                MessageBox.Show("Mã sản phẩm không tồn tại");
            }
        }

		private void btnLuuNV_Click(object sender, EventArgs e)
		{
            dataNhanVien["HESOLUONG"] = int.Parse(txtHeSoLuong.Text.Trim());
            dataNhanVien["TINHTRANG"] = (rdbDiLam.Checked) ? 1 : 0;
            btnLuuNV.Enabled = false;
        }

		private void txtHeSoLuong_KeyUp(object sender, KeyEventArgs e)
		{
            btnLuuNV.Enabled = checkTTNV();
        }

		private void rdbDiLam_CheckedChanged(object sender, EventArgs e)
		{
            btnLuuNV.Enabled = checkTTNV();

        }

		private void rdbDaNghi_CheckedChanged(object sender, EventArgs e)
		{
            btnLuuNV.Enabled = checkTTNV();
        }

		private void txtHeSoLuong_TextChanged(object sender, EventArgs e)
		{
            btnLuuNV.Enabled = checkTTNV();
        }

        private bool checkTTNV()
        {
            if (dataNhanVien != null)
            {
                string heSoLuong_old = txtHeSoLuong.Text.Trim();
                string heSoLuong_new = dataNhanVien["HESOLUONG"].ToString().Trim();
                int TinhTrang_old = (rdbDiLam.Checked || rdbDaNghi.Checked) ? (rdbDiLam.Checked) ?1:0: -1;
                int TinhTrang_new = (dataNhanVien["TINHTRANG"].ToString().Trim().Length > 0)?(dataNhanVien.Field<bool>("TINHTRANG"))?1:0:-1;
                if ((heSoLuong_old != heSoLuong_new || TinhTrang_old != TinhTrang_new) && TinhTrang_old != -1)
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }


	}
}
