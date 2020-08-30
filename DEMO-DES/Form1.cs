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
        
        private void btnEncrpytion_Click(object sender, EventArgs e)
        {

            if (radioEncryp.Checked == true)
            {
                if (string.IsNullOrEmpty(txtBanRo.Text) == false && string.IsNullOrEmpty(txtKey.Text) == false)
                {
                    txtResult.Text = DesLibrary.EncrpytionDES(txtKey.Text.ToString(), txtBanRo.Text.ToString());

                }
                else
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin bản rõ và khóa");
            }
            if (radioDecryp.Checked == true)
            {
                if (string.IsNullOrEmpty(txtBanRo.Text) == false && string.IsNullOrEmpty(txtKey.Text) == false)
                {
                    txtResult.Text = DesLibrary.DecrpytionDES(txtKey.Text.ToString(), txtBanRo.Text.ToString());

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
        }
    }
}
