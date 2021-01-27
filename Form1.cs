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
	public partial class frm_Q1 : Form
	{
		public frm_Q1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (rad_C.Checked)
			{
				Dados.Acertou();
			}
			else
			{
				Dados.Errou();
			}
			this.rad_A.Checked = false;
			this.rad_B.Checked = false;
			this.rad_C.Checked = false;
			this.rad_D.Checked = false;
			this.rad_E.Checked = false;
			frm_Q2 q2 = new frm_Q2();
			q2.Show();
			this.Hide();

		}

		private void frm_Q1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!Dados.Fechar_Dialogo())
				e.Cancel = true;
			else
				Application.Exit();
		}

		private void frm_Q1_Load(object sender, EventArgs e)
		{
			this.rad_A.Checked = false;
			this.rad_B.Checked = false;
			this.rad_C.Checked = false;
			this.rad_D.Checked = false;
			this.rad_E.Checked = false;
		}
	}
}
