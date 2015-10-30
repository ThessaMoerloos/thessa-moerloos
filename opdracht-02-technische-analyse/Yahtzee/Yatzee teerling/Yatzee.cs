using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yatzee_teerling
{
    public partial class Yatzee : Form
    {
        public Yatzee()
        {
            InitializeComponent();
        }

        private void Yatzee_Load(object sender, EventArgs e)
        {
            teerlingController nieuweTeerling = new teerlingController();

            Controls.Add(nieuweTeerling.getView());
        }
    }
}
