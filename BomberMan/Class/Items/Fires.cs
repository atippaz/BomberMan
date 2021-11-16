using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace BomberMan
{
    class Fires
    {
        private PictureBox fire;
        public PictureBox Up()
        {
            return fire = new PictureBox()
            {
               // Site = new Size(),
               // Location = new Point(),
               // Image = MapImage.Fire,
            };
        }
    }
}
