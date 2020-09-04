using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaHoaDES;


namespace DEMO_DES
{
    public partial class DES_Encrpytion : Form
    {
        public DES_Encrpytion()
        {
            InitializeComponent();
        }
        public string check;
        private void btnEncrpytion_Click(object sender, EventArgs e)
        {

            if (radioEncryp.Checked == true)
            {
                if (string.IsNullOrEmpty(txtBanRo.Text) == false && string.IsNullOrEmpty(txtKey.Text) == false)
                {
                    dgvKeyLR.Rows.Clear();
                    dgvKeyLR.Columns.Clear();
                    check = DesLibrary.EncrpytionDES(txtKey.Text.ToString(), txtBanRo.Text.ToString());
                    while (check.Count() < 16)
                    {
                        check = 0 + check;
                    }
                    if (check.Count() == 16)
                    {
                        txtResult.Text = check;
                    }
                    showKeyLR();
                }
                else
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin bản rõ và khóa");
            }
            if (radioDecryp.Checked == true)
            {
                if (string.IsNullOrEmpty(txtBanRo.Text) == false && string.IsNullOrEmpty(txtKey.Text) == false)
                {
                    dgvKeyLR.Rows.Clear();
                    dgvKeyLR.Columns.Clear();
                    check = DesLibrary.DecrpytionDES(txtKey.Text.ToString(), txtBanRo.Text.ToString());
                    while (check.Count() < 16)
                    {
                        check = 0 + check;
                    }
                    if (check.Count() == 16)
                    {
                        txtResult.Text = check;
                    }
                    showKeyLR();
                }
                else
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin bản rõ và khóa");
            }

        }

        private void radioEncryp_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Nhập bản rõ M";
            txtBanRo.Text = null;
            txtBanRo.Enabled = true;
            txtResult.Text = null;
            btnResult.Enabled = true;
        }

        private void radioDecryp_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Nhập bản mã C";
            txtBanRo.Text = null;
            txtBanRo.Enabled = true;
            txtResult.Text = null;
            btnResult.Enabled = true;
        }

        private void DES_Encrpytion_Load(object sender, EventArgs e)
        {
            txtBanRo.Enabled = false;
            txtBanRo.Text = "Chọn hình thức Mã hóa/ Giải mã";
            btnResult.Enabled = false;
            radioEncryp.Enabled = false;
            radioDecryp.Enabled = false;
        }
        void showKey()
        {
            dgvListKey.Columns.Add("C1", "i");
            dgvListKey.Columns["C1"].DataPropertyName = "Property1";
            dgvListKey.Columns.Add("C2", "Ki");
            dgvListKey.Columns["C2"].DataPropertyName = "Property2";
            string[] ListKeys = DesLibrary.ListKeys(txtKey.Text);
            int Length = ListKeys.Length;
            for (int i = 0; i < Length; i++)
            {
                DataGridViewRow row = (DataGridViewRow)dgvListKey.Rows[0].Clone();
                row.Cells[0].Value = (i+1).ToString();
                row.Cells[1].Value = DesLibrary.cvtBinaToHex(ListKeys[i]);
                dgvListKey.Rows.Add(row);
            }            
        }
        void showKeyLR()
        {
            dgvKeyLR.ColumnCount = 3;
            dgvKeyLR.Columns[0].Name = "i";
            dgvKeyLR.Columns[1].Name = "K Left";
            dgvKeyLR.Columns[2].Name = "K right";

            int Length = DesLibrary.ListKL.Length;
            for (int i = 0; i < Length; i++)
            {
                dgvKeyLR.Rows.Add(i, DesLibrary.ListKL[i], DesLibrary.ListKR[i]);
            }
            
        }
        private void GenKey_Click(object sender, EventArgs e)
        {
            showKey();
            if (dgvListKey != null)
            {
                radioEncryp.Enabled = true;
                radioDecryp.Enabled = true;
            }
        }
    }
}
