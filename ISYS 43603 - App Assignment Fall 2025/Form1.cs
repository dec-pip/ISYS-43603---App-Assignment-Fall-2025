using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISYS_43603___App_Assignment_Fall_2025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void LoginScreen_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Walton_DB.OpenConnection().ToString());
        }
    }
}
