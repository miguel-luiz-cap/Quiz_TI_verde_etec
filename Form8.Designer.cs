namespace Quiz
{
	partial class frm_Sobre
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Sobre));
			this.pic_TIverde = new System.Windows.Forms.PictureBox();
			this.lbl_Creditos = new System.Windows.Forms.Label();
			this.lblNomes = new System.Windows.Forms.Label();
			this.btnFechar = new System.Windows.Forms.Button();
			this.pic_Etec = new System.Windows.Forms.PictureBox();
			this.pic_CPS = new System.Windows.Forms.PictureBox();
			this.lbl_Turma = new System.Windows.Forms.Label();
			this.lbl_TiVerde = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pic_TIverde)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_Etec)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_CPS)).BeginInit();
			this.SuspendLayout();
			// 
			// pic_TIverde
			// 
			this.pic_TIverde.Image = global::Quiz.Properties.Resources.ti_verde2;
			this.pic_TIverde.Location = new System.Drawing.Point(83, 148);
			this.pic_TIverde.Name = "pic_TIverde";
			this.pic_TIverde.Size = new System.Drawing.Size(200, 200);
			this.pic_TIverde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_TIverde.TabIndex = 0;
			this.pic_TIverde.TabStop = false;
			// 
			// lbl_Creditos
			// 
			this.lbl_Creditos.AutoSize = true;
			this.lbl_Creditos.BackColor = System.Drawing.Color.Transparent;
			this.lbl_Creditos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Creditos.Location = new System.Drawing.Point(119, 351);
			this.lbl_Creditos.Name = "lbl_Creditos";
			this.lbl_Creditos.Size = new System.Drawing.Size(133, 31);
			this.lbl_Creditos.TabIndex = 0;
			this.lbl_Creditos.Text = "Créditos:";
			// 
			// lblNomes
			// 
			this.lblNomes.AutoSize = true;
			this.lblNomes.BackColor = System.Drawing.Color.Transparent;
			this.lblNomes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNomes.Location = new System.Drawing.Point(138, 402);
			this.lblNomes.Name = "lblNomes";
			this.lblNomes.Size = new System.Drawing.Size(89, 120);
			this.lblNomes.TabIndex = 2;
			this.lblNomes.Text = "Miguel Luiz\r\nGiovanni\r\nJoão Victor\r\nKaue\r\nDouglas\r\nErick";
			this.lblNomes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnFechar
			// 
			this.btnFechar.Location = new System.Drawing.Point(0, 525);
			this.btnFechar.Name = "btnFechar";
			this.btnFechar.Size = new System.Drawing.Size(365, 35);
			this.btnFechar.TabIndex = 5;
			this.btnFechar.Text = "Fechar";
			this.btnFechar.UseVisualStyleBackColor = true;
			this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
			// 
			// pic_Etec
			// 
			this.pic_Etec.Image = global::Quiz.Properties.Resources.etec_gru;
			this.pic_Etec.Location = new System.Drawing.Point(22, 6);
			this.pic_Etec.Name = "pic_Etec";
			this.pic_Etec.Size = new System.Drawing.Size(153, 90);
			this.pic_Etec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_Etec.TabIndex = 6;
			this.pic_Etec.TabStop = false;
			// 
			// pic_CPS
			// 
			this.pic_CPS.Image = global::Quiz.Properties.Resources.Centro_Paula_Souza;
			this.pic_CPS.Location = new System.Drawing.Point(202, 6);
			this.pic_CPS.Name = "pic_CPS";
			this.pic_CPS.Size = new System.Drawing.Size(132, 90);
			this.pic_CPS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_CPS.TabIndex = 7;
			this.pic_CPS.TabStop = false;
			// 
			// lbl_Turma
			// 
			this.lbl_Turma.AutoSize = true;
			this.lbl_Turma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Turma.Location = new System.Drawing.Point(104, 382);
			this.lbl_Turma.Name = "lbl_Turma";
			this.lbl_Turma.Size = new System.Drawing.Size(158, 20);
			this.lbl_Turma.TabIndex = 8;
			this.lbl_Turma.Text = "Turma 1º DS Noite";
			// 
			// lbl_TiVerde
			// 
			this.lbl_TiVerde.AutoSize = true;
			this.lbl_TiVerde.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_TiVerde.Location = new System.Drawing.Point(42, 114);
			this.lbl_TiVerde.Name = "lbl_TiVerde";
			this.lbl_TiVerde.Size = new System.Drawing.Size(292, 31);
			this.lbl_TiVerde.TabIndex = 9;
			this.lbl_TiVerde.Text = "PROJETO TI VERDE";
			// 
			// frm_Sobre
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			this.BackColor = System.Drawing.Color.PaleGreen;
			this.ClientSize = new System.Drawing.Size(364, 561);
			this.ControlBox = false;
			this.Controls.Add(this.lbl_TiVerde);
			this.Controls.Add(this.lbl_Turma);
			this.Controls.Add(this.pic_CPS);
			this.Controls.Add(this.pic_Etec);
			this.Controls.Add(this.btnFechar);
			this.Controls.Add(this.lblNomes);
			this.Controls.Add(this.lbl_Creditos);
			this.Controls.Add(this.pic_TIverde);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(380, 600);
			this.MinimumSize = new System.Drawing.Size(380, 600);
			this.Name = "frm_Sobre";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TI - Verde: Sobre";
			((System.ComponentModel.ISupportInitialize)(this.pic_TIverde)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_Etec)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_CPS)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pic_TIverde;
		private System.Windows.Forms.Label lbl_Creditos;
		private System.Windows.Forms.Label lblNomes;
		private System.Windows.Forms.Button btnFechar;
		private System.Windows.Forms.PictureBox pic_Etec;
		private System.Windows.Forms.PictureBox pic_CPS;
		private System.Windows.Forms.Label lbl_Turma;
		private System.Windows.Forms.Label lbl_TiVerde;
	}
}