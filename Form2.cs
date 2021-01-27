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
	public partial class frm_Q2 : Form
	{
		public frm_Q2()
		{
			InitializeComponent();
		}

		private void btn_Prox_Click(object sender, EventArgs e)
		{
			if (rad_C.Checked)
			{
				Dados.Acertou();
			}
			else
			{
				Dados.Errou();
			}

			frm_Q3 q3 = new frm_Q3();
			q3.Show();
			this.Hide();
		}

		private void frm_Q2_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!Dados.Fechar_Dialogo())
				e.Cancel = true;
			else
				Application.Exit();
		}

		private void frm_Q2_Load(object sender, EventArgs e)
		{
			rad_A.Checked = false;
			rad_B.Checked = false;
			rad_C.Checked = false;
			rad_D.Checked = false;
			rad_E.Checked = false;
		}

		private void btnProx_Click(object sender, EventArgs e)
		{

		}
	}
}
