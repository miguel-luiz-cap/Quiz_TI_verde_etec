using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    class Dados
    {
        public static int Acerto = 0;
        public static int Erro = 0;
        public static bool NaoPergunte = false;

        public static void Acertou()
        {
            Acerto++;
        }
        public static void Errou()
        {
            Erro++;
        }
        public static int getAcertos()
        {
            return Acerto;
        }
        public static int getErros()
        {
            return Erro;
        }
        public static void Resetar_Dados()
        {
            Erro = 0;
            Acerto = 0;
        }
        public static bool Fechar_Dialogo()
		{
            if(NaoPergunte)
                return true;

            DialogResult resultado = MessageBox.Show("Voce deseja realmente Sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                NaoPergunte = true;
                return true;
            }

            return false;
        }
    }

}
