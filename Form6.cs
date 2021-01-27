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
	public partial class frm_Resultados : Form
	{
		public frm_Resultados()
		{
			InitializeComponent();
		}
        
		private void Carregar_Resultados(object sender, EventArgs e)
		{
            rtb_Resultado.Text = "Acertos: " + Dados.getAcertos() + "\n\nErros: " + Dados.getErros();

            if (Dados.Acerto <= 0)
            {
                rtb_Resultado.Text += "\n\nVocê errou tudo! Tente novamente !";
                rtb_Resultado.ForeColor = Color.Red;
                rtb_Resultado.BackColor = Color.DarkBlue;
            }
            else if ((Dados.Acerto >= 1) && (Dados.Acerto <= 2))
            {
                rtb_Resultado.Text += "\n\nNão desista! Voce acertou pelo menos " + (Dados.Acerto == 1 ? "uma questão." : Dados.Acerto + " questões.");
                rtb_Resultado.ForeColor = Color.Red;
                rtb_Resultado.BackColor = Color.DarkBlue;
            }
            else if((Dados.Acerto >= 3) && (Dados.Acerto <= 4))
            {
                rtb_Resultado.Text += "\n\nMuito Bom! Continue assim.";
                rtb_Resultado.ForeColor = Color.DarkBlue;
            }
            else if(Dados.Acerto == 5)
            {
                rtb_Resultado.Text += "\n\nPerfeito!!!\nVocê Dominou o Quiz !!";
                rtb_Resultado.ForeColor = Color.DarkBlue;
            }

        }

		private void btn_Inicio_Click(object sender, EventArgs e)
		{
            Dados.Resetar_Dados();
            frm_TelaInicial TI = new frm_TelaInicial();
            TI.Show();
            this.Hide();
        }

		private void btn_Fim_Click(object sender, EventArgs e)
		{
            this.Close();
        }

		private void frm_Resultados_FormClosing(object sender, FormClosingEventArgs e)
		{
            if (!Dados.Fechar_Dialogo())
                e.Cancel = true;
            else
                Application.Exit();
        }
	}
}
