using HydraApp.Models;
using HydraApp.Services;
using Microsoft.Toolkit.Uwp.Notifications;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HydraApp
{
    public partial class Dashboard : Form
    {
        private HidratacaoService hidratacaoService;

        public RegistroConsumo Registro { get; private set; }

        public Dashboard()
        {

            InitializeComponent();
           
            Registro = new RegistroConsumo ();
            hidratacaoService = new HidratacaoService();
            label1.Text = DateTime.Now.ToString("dd/MM/yyyy");
            ToastNotificationManagerCompat.OnActivated += ToastNotificationManagerCompat_OnActivated;

        }

        private void btn_25_Click(object sender, EventArgs e)
        {
            Registro = hidratacaoService.AdicionarConsumo(Registro,25);
            circularProgressBar1.Percentage = Registro.Porcentagem;
            
        }
        private void btn_50_Click(object sender, EventArgs e)
        {
            Registro = hidratacaoService.AdicionarConsumo(Registro, 50);
            circularProgressBar1.Percentage = Registro.Porcentagem;
            
        }
        private void btn_100_Click(object sender, EventArgs e)
        {
            Registro = hidratacaoService.AdicionarConsumo(Registro, 100);
            circularProgressBar1.Percentage = Registro.Porcentagem;
           
        }

        private void btn_zerar_Click(object sender, EventArgs e)
        {
            Registro = hidratacaoService.ZerarConsumo(Registro, 0);
            circularProgressBar1.Percentage = Registro.Porcentagem;
        }

        bool menuAberto = true;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (menuAberto)
            {
                menu_lateral.Width += 10;

                if (menu_lateral.Width >= 152)
                {
                    timer1.Stop();
                }
            }
            else
            {
                menu_lateral.Width -= 10;

                if (menu_lateral.Width <= 0)
                {
                    timer1.Stop();
                }


            }
        }

        private void menu_lateral_Paint(object sender, PaintEventArgs e)
        {
            menu_lateral.Dock = DockStyle.Left;
        }

        private void btn_ham_Click(object sender, EventArgs e)
        {
            menuAberto = !menuAberto;
            timer1.Start();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void flow_principal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

           
        }

        private void flow_dashbord_Paint(object sender, PaintEventArgs e)
        {
  
        }

        private void painel_principal_Paint(object sender, PaintEventArgs e)
        {
            painel_principal.Dock = DockStyle.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                
                new ToastContentBuilder()
            .AddText("HydraApp")
            .AddText("Beba a sua quantidade de água")
            .AddText("Você deseja adicionar 25ml de água?")
            .AddButton(
                new ToastButton()
                    .SetContent("SIM")
                    .AddArgument("acao", "sim")
            )
            .AddButton(
                new ToastButton()
                    .SetContent("NÃO")
                    .AddArgument("acao", "nao")
            )
            .Show();
            }
        }

        private void ToastNotificationManagerCompat_OnActivated( ToastNotificationActivatedEventArgsCompat e)
        {
            var args = ToastArguments.Parse(e.Argument);

            string acao = args["acao"];

            if (acao == "sim")
            {
                Registro = hidratacaoService.AdicionarConsumo(Registro, 25);
                circularProgressBar1.Percentage = Registro.Porcentagem;
                MessageBox.Show("deu certo!");

            }
            else if (acao == "nao")
            {
                MessageBox.Show("Você clicou em NÃO!");

            }

        }

        private void flow_msg_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
    
}
