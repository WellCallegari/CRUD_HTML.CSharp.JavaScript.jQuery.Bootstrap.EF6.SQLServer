using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeerStore
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void addClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addcliente opencli = new Addcliente();          //chamando formulario addcliente
            opencli.ShowDialog(); 
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();                                      //fechando formulario/sistema
            
        }

        private void minimizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; //minimizando formulario/sistema
        }

    
    }
}
