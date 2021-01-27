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
	public partial class frm_Q4 : Form
	{
		public frm_Q4()
		{
			InitializeComponent();
		}

		private void btn_Prox_Click(object sender, EventArgs e)
		{
			if (rad_D.Checked)
			{
				Dados.Acertou();
			}
			else
			{
				Dados.Errou();
			}

			frm_Q5 q5 = new frm_Q5();
			q5.Show();
			this.Hide();
		}

		private void frm_Q4_FormClosed(object sender, FormClosedEventArgs e)
		{
			Dados.Fechar_Dialogo();
		}

		private void frm_Q4_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!Dados.Fechar_Dialogo())
				e.Cancel = true;
			else
				Application.Exit();
		}

		private void frm_Q4_Load(object sender, EventArgs e)
		{
			rad_A.Checked = false;
			rad_B.Checked = false;
			rad_C.Checked = false;
			rad_D.Checked = false;
			rad_E.Checked = false;
		}
	}
}
