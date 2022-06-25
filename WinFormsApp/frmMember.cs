using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class frmMember : Form
    {
        public frmMember() {
            InitializeComponent();
        }
        public frmMember(string situation) {
            InitializeComponent();
            if (situation.Equals("new")) {
                
            } else if (situation.Equals("update")) {

            }
        }

    }
}
