using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperature_monitoring
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void butProcess_Click(object sender, EventArgs e)
        {
            try
            {
                string[] MaxTemp = new string[2];
                MaxTemp[0] = textBoxMaxTemp.Text;
                MaxTemp[1] = textBoxTimeMax.Text;

                string[] MinTemp = new string[2];
                MinTemp[0] = textBoxMinTemp.Text;
                MinTemp[1] = textBoxMinTime.Text;
            }
            catch (Exception e)
            {

            }
        }
    }

}
