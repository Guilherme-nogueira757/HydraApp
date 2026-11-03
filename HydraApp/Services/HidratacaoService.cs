using HydraApp.Class;
using HydraApp.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HydraApp.Services
{
    public class HidratacaoService
    {
        private object circularProgressBar1;

        public RegistroConsumo AdicionarConsumo( RegistroConsumo registroAtual,int porcentagem)
        {
            registroAtual.Porcentagem += porcentagem;

            if (registroAtual.Porcentagem > 100)
            {
                registroAtual.Porcentagem = 100;
            }

            return registroAtual;

        }

        public RegistroConsumo ZerarConsumo(RegistroConsumo registroAtual, int porcentagem)
        {
            registroAtual.Porcentagem = porcentagem;
            return registroAtual;

        }


        public RegistroConsumo meta_batida (RegistroConsumo registroAtual)
        {
            if (registroAtual.Porcentagem == 100)
            {
                MessageBox.Show("parabensssssss");
                return registroAtual;
            }
            

            return registroAtual;

        }

        
    }
}
