using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BfDwsForm
{
    public partial class DwsForm : Form
    {
        public DwsForm()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItemCameraCfg_Click(object sender, EventArgs e)
        {
            this.toolStripStatusLabelCamera.Text = "已连接";
        }
    }
}
