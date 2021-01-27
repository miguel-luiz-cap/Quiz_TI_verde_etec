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
	public partial class frm_Q5 : Form
	{
		public frm_Q5()
		{
			InitializeComponent();
		}

		private void btn_Concluir_Click(object sender, EventArgs e)
		{
			if (rad_A.Checked)
			{
				Dados.Acertou();
			}
			else
			{
				Dados.Errou();
			}

			frm_Resultados res = new frm_Resultados();
			res.Show();
			this.Hide();
		}

		private void frm_Q5_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!Dados.Fechar_Dialogo())
				e.Cancel = true;
			else
				Application.Exit();
		}

		private void frm_Q5_Load(object sender, EventArgs e)
		{
			rad_A.Checked = false;
			rad_B.Checked = false;
			rad_C.Checked = false;
			rad_D.Checked = false;
			rad_E.Checked = false;
		}

	}
}
