using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DevEduManager.Screens
{
    public partial class frmThongTinHocVien : Form
    {
        private Panel _mainPanel;

        public frmThongTinHocVien(Panel mainPanel)
        {
            InitializeComponent();
            _mainPanel = mainPanel;
            Load += frmThongTinHocVien_Load;
            gridLopHoc.CellPainting += gridLopHoc_CellPainting;
        }

        private void frmThongTinHocVien_Load(object sender, EventArgs e)
        {
            // Setup columns
            gridLopHoc.AutoGenerateColumns = false;
            gridLopHoc.ColumnCount = 2;
            gridLopHoc.Columns[0].Name = "ChuongTrinh";
            gridLopHoc.Columns[0].HeaderText = "Chương trình học";
            gridLopHoc.Columns[1].Name = "MonHoc";
            gridLopHoc.Columns[1].HeaderText = "Môn học";

            // Sample data
            var data = new List<HocVienChuongTrinh>
            {
                new HocVienChuongTrinh { ChuongTrinh = "Tin học căn bản", MonHoc = "Word" },
                new HocVienChuongTrinh { ChuongTrinh = "Tin học căn bản", MonHoc = "Excel" },
                new HocVienChuongTrinh { ChuongTrinh = "Tin học căn bản", MonHoc = "PowerPoint" },
                new HocVienChuongTrinh { ChuongTrinh = "Lập trình C#", MonHoc = "Cơ bản" },
                new HocVienChuongTrinh { ChuongTrinh = "Lập trình C#", MonHoc = "Nâng cao" },
            };

            // Add rows
            gridLopHoc.RowTemplate.Height = 40;
            foreach (var item in data)
            {
                gridLopHoc.Rows.Add(item.ChuongTrinh, item.MonHoc);
            }
            gridLopHoc.EnableHeadersVisualStyles = false;
            gridLopHoc.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            gridLopHoc.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridLopHoc.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            gridLopHoc.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            gridLopHoc.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            gridLopHoc.DefaultCellStyle.SelectionForeColor = Color.Black;

            gridLopHoc.AllowUserToAddRows = false;
            gridLopHoc.AllowUserToResizeRows = false;
            gridLopHoc.RowHeadersVisible = false;
            gridLopHoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void gridLopHoc_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != 0) return;

            e.Handled = true;
            e.PaintBackground(e.CellBounds, true);

            string currentValue = e.Value?.ToString();
            string previousValue = e.RowIndex > 0
                ? gridLopHoc.Rows[e.RowIndex - 1].Cells[e.ColumnIndex].Value?.ToString()
                : null;

            bool isSameAsAbove = currentValue == previousValue;

            if (!isSameAsAbove && !string.IsNullOrEmpty(currentValue))
            {
                // Căn giữa dọc và trái đẹp hơn
                using (SolidBrush brush = new SolidBrush(e.CellStyle.ForeColor))
                {
                    var textSize = TextRenderer.MeasureText(currentValue, e.CellStyle.Font);
                    var location = new Point(e.CellBounds.X + 6, e.CellBounds.Y + (e.CellBounds.Height - textSize.Height) / 2);
                    e.Graphics.DrawString(currentValue, e.CellStyle.Font, brush, location);
                }
            }

            // Vẽ border để ngăn rõ ràng
            using (Pen gridLinePen = new Pen(gridLopHoc.GridColor))
            {
                e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right, e.CellBounds.Bottom - 1);
                e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom);
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            var frm = new frmQuanLyHocVien(_mainPanel)
            {
                Dock = DockStyle.Fill,
                TopLevel = false
            };

            _mainPanel.Controls.Clear();
            _mainPanel.Controls.Add(frm);
            frm.Show();
        }

        public class HocVienChuongTrinh
        {
            public string ChuongTrinh { get; set; }
            public string MonHoc { get; set; }
        }
    }
}
