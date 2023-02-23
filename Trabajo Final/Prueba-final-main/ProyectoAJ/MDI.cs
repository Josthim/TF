using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAJ
{
    public partial class MDI : Form
    {
       
        public Conectar con;
        public MDI()
        {
            InitializeComponent();
        }
        public MDI(Conectar con)
        {
            this.con = con;
            InitializeComponent();
            IsMdiContainer = true;
        }
        private void balanceGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 X = new Form1(con);
            X.MdiParent = this;
            X.Show();
        }
    }
}
