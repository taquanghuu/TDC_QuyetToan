using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuyetToanVCG_TDC_2021
{
    public partial class frmBaoGia_XangDau : Form
    {
        int mid_hopdong_;
        public frmBaoGia_XangDau(int xid_hopdong_)
        {
            mid_hopdong_ = xid_hopdong_;
            InitializeComponent();
        }

        private void frmBaoGia_XangDau_Load(object sender, EventArgs e)
        {

        }

        private void btThoat2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
