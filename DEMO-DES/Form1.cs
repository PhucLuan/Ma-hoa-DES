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
            if (string.IsNullOrEmpty(txtBanRo.Text) == false && string.IsNullOrEmpty(txtKey.Text) == false)
            {
                txtResult.Text = DesLibrary.EncrpytionDES(txtKey.Text.ToString(), txtBanRo.Text.ToString());
               
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!");
        }
    }
}
