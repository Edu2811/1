using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        static void form2()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2());
        }
        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 objCalc = new Form1();
            objCalc.MdiParent = this;
            objCalc.Show();
        }
    }
}
