using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary1
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Paint(object sender, PaintEventArgs e)
        {
            Graphics dc = e.Graphics;
            Pen pn = new Pen(ForeColor);
            SolidBrush br = new SolidBrush(ForeColor);
            initCoordinates(dc );

        }

        private void initCoordinates(Graphics dc)
        {
            throw new NotImplementedException();
        }
    }
}
