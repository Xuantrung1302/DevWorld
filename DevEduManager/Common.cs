using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevEduManager
{
    public static class Common
    {

        /// <summary>
        /// Kiểm tra DataGridView nếu không có dữ liệu thì hiển thị Label thông báo
        /// </summary>
        /// <param name="dgv">DataGridView cần kiểm tra</param>
        /// <param name="_isShowLabelNull">True để hiển thị label nếu không có dữ liệu</param>
        /// <param name="text">Nội dung thông báo</param>
        public static void DataSourceIsNull(this DataGridView dgv, bool _isShowLabelNull = true, string text = "Không có dữ liệu để hiển thị")
        {
            try
            {
                if (dgv != null)
                {
                    // Xóa label cũ nếu có
                    if (dgv.Controls != null && dgv.Controls.Count > 0)
                    {
                        foreach (Control control in dgv.Controls)
                        {
                            if (control is Label lbl && lbl.Name == "Dgv_Label_DataSourceNull")
                            {
                                dgv.Controls.Remove(lbl);
                                break;
                            }
                        }
                    }

                    // Nếu không cần hiển thị thì thoát
                    if (_isShowLabelNull == false) return;

                    // Nếu DataGridView không có dòng nào
                    if (dgv.RowCount == 0)
                    {
                        Label lbl = new Label
                        {
                            Name = "Dgv_Label_DataSourceNull",
                            Text = text, // Ví dụ: "Không có dữ liệu để hiển thị"
                            Height = 40,
                            AutoSize = true,
                            TextAlign = ContentAlignment.MiddleLeft,
                            Location = new Point(dgv.RowHeadersWidth + 10, dgv.ColumnHeadersHeight + 30),
                            ForeColor = Color.Gray,
                            Font = new Font("Segoe UI", 10, FontStyle.Italic)
                        };

                        dgv.Controls.Add(lbl);
                        dgv.Refresh();
                    }
                }
            }
            catch
            {
                // Bỏ qua lỗi (nếu có)
            }
        }


        public static void LoadComboBoxLoaiHV(ComboBox cboLoaiHV)
        {
            List<Item> list = new List<Item>()
            {
                new Item{ Name = "Học viên tiềm năng", Value = "LHV00" },
                new Item{ Name = "Học viên chính thức", Value = "LHV01" }
            };
            cboLoaiHV.DataSource = list;
            cboLoaiHV.DisplayMember = "Name";
            cboLoaiHV.ValueMember = "Value";
        }
        public static void LoadComboBoxLoaiNV(ComboBox cboLoaiNV)
        {
            List<Item> list = new List<Item>()
            {
                new Item{ Name = "Quản trị viên", Value = "LNV00" },
                new Item{ Name = "Nhân viên ghi danh", Value = "LNV01" },
                new Item{ Name = "Nhân viên học vụ", Value = "LNV02" },
                new Item{ Name = "Nhân viên kế toán", Value = "LNV03" },
            };
            cboLoaiNV.DataSource = list;
            cboLoaiNV.DisplayMember = "Name";
            cboLoaiNV.ValueMember = "Value";
        }
    }

    public class Item
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public static class UserSession
    {
        public static string UserId { get; set; }      // ID tương ứng theo Role
        public static string Role { get; set; }     // "Admin", "Employee", "Teacher", "Student"
    }

}
