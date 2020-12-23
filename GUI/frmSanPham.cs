using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThinkProManager.GUI
{
    public partial class frmSanPham : Form
    {
        
        handle.main handle = new handle.main();
        DataRow dataThongTin = null;
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            dgvDSSP.AutoGenerateColumns = false;
            dgvDSSP.DataSource = handle.get("SANPHAM");

            cboLoai.DataSource = handle.get("LOAI");
            cboLoai.DisplayMember = "TENLOAI";
            cboLoai.ValueMember = "ID_LOAI";

            cboThuongHieu.DataSource = handle.get("THUONGHIEU");
            cboThuongHieu.DisplayMember = "TENTH";
            cboThuongHieu.ValueMember = "ID_BRAND";

            cboTinhTrang.DataSource = handle.get("TINHTRANG");
            cboTinhTrang.DisplayMember = "TENTT";
            cboTinhTrang.ValueMember = "ID_TINHTRANG";

            cboThongTinThem.Enabled = false;
            txtThongTinThem.Enabled = false;
            txtThongTinThem.Clear();

            var listDataThongTin = handle.get("THONGTIN").Columns.Cast<DataColumn>().Select(x => x.ColumnName).ToList();
            listDataThongTin.RemoveAt(0);
            var listNameThongTin = new List<string> { "Vi Xử Lý", "Màn Hình", "RAM", "Card Đồ Họa", "Lưu Trữ", "Pin", "Kết Nối", "Trọng Lượng", "Hệ Điều Hành", "Màu Sắc" };
            List<KeyValuePair<string, string>> DataSourceThongTin = new List<KeyValuePair<string, string>>();
            for(int i = 0; i < listDataThongTin.Count; i++)
            {
                DataSourceThongTin.Add(new KeyValuePair<string, string>(listDataThongTin[i], listNameThongTin[i]));
            }

            cboThongTinThem.DataSource = DataSourceThongTin;
            cboThongTinThem.DisplayMember = "Value";
            cboThongTinThem.ValueMember = "Key";
        }

        private void dgvDSSP_Click(object sender, EventArgs e)
        {
            int row_index = dgvDSSP.CurrentRow.Index;
            if (row_index >= 0)
            {
                string _idSP = dgvDSSP.Rows[row_index].Cells[0].Value.ToString();
                DataRow row = handle.sanpham.find(_idSP);
                txtMaSP.Text = row["ID_SP"].ToString();
                txtTenSP.Text = row["TENSP"].ToString();
                txtDonGia.Text = row["GIATIEN"].ToString();
                txtTHBH.Text = row["THOIHAN_BH"].ToString();
                txtAnhSP.Text = row["ANH_SP"].ToString();
                richtxtGhiChu.Text = row["THONGTIN"].ToString();
                cboLoai.SelectedValue = row["ID_LOAI"].ToString();
                cboThuongHieu.SelectedValue = row["ID_BRAND"].ToString();
                cboTinhTrang.SelectedValue = row["ID_TINHTRANG"].ToString();
                anhSP.InitialImage = null;
                anhSP.Image = null;
                anhSP.Update();
                try
                {
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                    anhSP.Load(row["ANH_SP"].ToString());
                }
                catch(Exception ex)
                {

                }
                
                dataThongTin = handle.sanpham.findThongTin(_idSP);
                if (dataThongTin != null)
                {
                    chboxThongTinThem.Checked = true;
                    cboThongTinThem.SelectedIndex = 0;
                    txtThongTinThem.Text = dataThongTin["VIXULY"].ToString();
                }
                else
                {
                    chboxThongTinThem.Checked = false;
                    cboThongTinThem.SelectedIndex = 0;
                    txtThongTinThem.Clear();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetEle();
        }

        private void chboxThongTinThem_CheckedChanged(object sender, EventArgs e)
        {
            if (chboxThongTinThem.Checked)
            {
                string MaSP = txtMaSP.Text.Trim();
                if (dataThongTin == null && MaSP.Length > 0)
                {
                    dataThongTin = handle.get("THONGTIN").NewRow();
                    dataThongTin["ID_SP"] = MaSP;
                }
                cboThongTinThem.Enabled = true;
                txtThongTinThem.Enabled = true;
                txtThongTinThem.Clear();
                txtThongTinThem.Text = dataThongTin[cboThongTinThem.SelectedValue.ToString()].ToString();
                btnLuuTT.Enabled = false;
            }
            else
            {
                cboThongTinThem.Enabled = false;
                txtThongTinThem.Enabled = false;
                txtThongTinThem.Clear();
                btnLuuTT.Enabled = false;
            }
        }

        private void cboThongTinThem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(dataThongTin != null)
                txtThongTinThem.Text = dataThongTin[cboThongTinThem.SelectedValue.ToString()].ToString();

        }

        private void txtThongTinThem_KeyUp(object sender, KeyEventArgs e)
        {
            string thongtin_new = txtThongTinThem.Text.ToString().Trim();
            string thongtin_old = dataThongTin[cboThongTinThem.SelectedValue.ToString()].ToString().Trim();
            if (thongtin_old != thongtin_new)
                btnLuuTT.Enabled = true;
            else
                btnLuuTT.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string idSP = txtMaSP.Text.Trim();
            if(checkValidate())
            {
                string AnhSP = txtAnhSP.Text.Trim();
                if (Uri.IsWellFormedUriString(AnhSP, UriKind.Absolute))
                {
                    if (handle.sanpham.find(idSP) == null)
                    {
                        string idBrand = cboThuongHieu.SelectedValue.ToString().Trim();
                        string idLoai = cboLoai.SelectedValue.ToString().Trim();
                        string idTinhTrang = cboTinhTrang.SelectedValue.ToString().Trim();
                        string TenSP = txtTenSP.Text.Trim();
                        int GiaTien = int.Parse(txtDonGia.Text.Trim());
                        int ThoiHanBH = int.Parse(txtTHBH.Text.Trim());
                        string MoTa = richtxtGhiChu.Text;
                        bool result = handle.sanpham.add(idSP, idBrand, idLoai, TenSP, AnhSP, GiaTien, idTinhTrang, ThoiHanBH, MoTa);
                        if (result)
                        {
                            bool result_tt = true;
                            if (dataThongTin != null && chboxThongTinThem.Checked)
                            {
                                result_tt = handle.sanpham.addThongTin(dataThongTin);
                            }
                            if (result_tt)
                            {
                                MessageBox.Show("Thêm sản phẩm thành công");
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
                        MessageBox.Show("Sản phẩm đã tồn tại. Vui lòng thử lại");
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
            foreach(Control c in grboxThongTin.Controls)
            {
                if(c is TextBox)
                {
                    if(((TextBox)c).Text.Trim().Length == 0)
                    {
                        check = false;
                        break;
                    }
                }
            }
            return check;
        }

        private void txtTHBH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void ResetEle()
        {
            txtAnhSP.Clear();
            txtDonGia.Clear();
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtTHBH.Clear();
            txtThongTinThem.Clear();
            richtxtGhiChu.Clear();
            anhSP.InitialImage = null;
            anhSP.Image = null;
            anhSP.Update();
            dataThongTin = null;
            cboThongTinThem.Enabled = false;
            txtThongTinThem.Enabled = false;
            txtThongTinThem.Clear();
            btnLuuTT.Enabled = false;
            chboxThongTinThem.Checked = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn lưu tất cả các thay đổi này ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                handle.save("SANPHAM");
                handle.save("THONGTIN");
            }
            
        }

        private void btnLuuTT_Click(object sender, EventArgs e)
        {
            string thongtin_new = txtThongTinThem.Text.ToString().Trim();
            dataThongTin[cboThongTinThem.SelectedValue.ToString()] = thongtin_new;
            btnLuuTT.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string idSP = txtMaSP.Text.Trim();
            if (handle.sanpham.find(idSP) != null)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa sản phẩm này ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    bool final_result = handle.sanpham.delete(idSP);
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            string idSP = txtMaSP.Text.Trim();
            if (checkValidate())
            {
                string AnhSP = txtAnhSP.Text.Trim();
                if (Uri.IsWellFormedUriString(AnhSP, UriKind.Absolute))
                {
                    if (handle.sanpham.find(idSP) != null)
                    {
                        string idBrand = cboThuongHieu.SelectedValue.ToString().Trim();
                        string idLoai = cboLoai.SelectedValue.ToString().Trim();
                        string idTinhTrang = cboTinhTrang.SelectedValue.ToString().Trim();
                        string TenSP = txtTenSP.Text.Trim();
                        int GiaTien = int.Parse(txtDonGia.Text.Trim());
                        int ThoiHanBH = int.Parse(txtTHBH.Text.Trim());
                        string MoTa = richtxtGhiChu.Text;
                        bool result = handle.sanpham.update(idSP, idBrand, idLoai, TenSP, AnhSP, GiaTien, idTinhTrang, ThoiHanBH, MoTa);
                        if (result)
                        {
                            bool result_tt = true;
                            if (dataThongTin != null && chboxThongTinThem.Checked)
                            {
                                result_tt = handle.sanpham.updateThongTin(dataThongTin);
                            }
                            if (result_tt)
                            {
                                MessageBox.Show("Sửa sản phẩm thành công");
                                ResetEle();
                            }
                            else
                            {
                                MessageBox.Show("Thông tin thêm của sản phẩm bị lỗi");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Có lỗi khi sửa sản phẩm");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sản phẩm chưa tồn tại. Vui lòng thử lại");
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

        private void frmSanPham_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn lưu tất cả các thay đổi này ?", "Thông Báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                handle.save("SANPHAM");
                handle.save("THONGTIN");
            }
            else if(result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
