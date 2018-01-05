using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Gasket_Quotation
{
    public partial class frmQuoteItem : DevExpress.XtraEditors.XtraForm
    {
        public frmQuoteItem()
        {
            InitializeComponent();
        }

        private void memoEdit1_Properties_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                popEditDesc.ShowPopup();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }
    }
}