using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjWinform202344073
{
    public partial class multibootForm : Form
    {
        public multibootForm()
        {
            InitializeComponent();
            string name = "강찬휘";
            string num = "202344073";

            multibootLbl.Text = name + "\n";
            multibootLbl.Text += num;
        }
    }
}
