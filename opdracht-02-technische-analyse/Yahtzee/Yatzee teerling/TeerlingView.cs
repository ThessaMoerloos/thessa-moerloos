using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yatzee_teerling
{
    public partial class TeerlingView : UserControl
    {
        teerlingController _controller;

        public TeerlingView()
        {

            _controller = controller;
            InitializeComponent();
            bool TeerlingStaatVast = true;
        }





        private void werpButton_Click(object sender, EventArgs e)
        {
           
            // controller.werpteerling();


            //waarde van de teerling ophalen uit het model


            //

        }



        private void teerlingLable_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            // random.next geeft een random getal terug dat tussen 2 waardes ligt
            int nieuwGetal = random.Next(1,7);

            // het (nieuw) random getal steken in het teerlingLabel (wel to string maken)
            teerlingLable.Text = nieuwGetal.ToString();

        }

        private void TeerlingView_Load(object sender, EventArgs e)
        {

        }
    }
}
