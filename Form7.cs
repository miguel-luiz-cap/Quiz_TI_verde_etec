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
	public partial class frm_TelaInicial : Form
	{
		public frm_TelaInicial()
		{
			InitializeComponent();
		}

		private void btn_Comecar_Click(object sender, EventArgs e)
		{
			frm_Q1 q1 = new frm_Q1();
            q1.Show();
            this.Hide();

		}

		private void btn_Sair_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void frm_TelaInicial_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!Dados.Fechar_Dialogo())
				e.Cancel = true;
			else
				Application.Exit();
		}

		private void btnSobre_Click(object sender, EventArgs e)
		{
			frm_Sobre sobre = new frm_Sobre();
			sobre.Show();
		}
	}
}
