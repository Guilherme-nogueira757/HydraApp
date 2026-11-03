using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HydraApp.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
           
        }

     

        private void ArredondarPainel(Panel painel, int raio)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(painel.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(painel.Width - raio, painel.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, painel.Height - raio, raio, raio, 90, 90);

            path.CloseFigure();

            painel.Region = new Region(path);
        }


       

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            ArredondarPainel(panel1, 30);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
