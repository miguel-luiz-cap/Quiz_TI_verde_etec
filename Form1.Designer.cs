namespace Quiz
{
	partial class frm_Q1
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Q1));
			this.rad_A = new System.Windows.Forms.RadioButton();
			this.rad_B = new System.Windows.Forms.RadioButton();
			this.rad_C = new System.Windows.Forms.RadioButton();
			this.rad_D = new System.Windows.Forms.RadioButton();
			this.rad_E = new System.Windows.Forms.RadioButton();
			this.btn_Prox = new System.Windows.Forms.Button();
			this.lbl_Questao = new System.Windows.Forms.Label();
			this.pic_Quiz = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pic_Quiz)).BeginInit();
			this.SuspendLayout();
			// 
			// rad_A
			// 
			this.rad_A.AutoSize = true;
			this.rad_A.Location = new System.Drawing.Point(225, 65);
			this.rad_A.Name = "rad_A";
			this.rad_A.Size = new System.Drawing.Size(31, 17);
			this.rad_A.TabIndex = 10;
			this.rad_A.TabStop = true;
			this.rad_A.Text = "1";
			this.rad_A.UseVisualStyleBackColor = true;
			// 
			// rad_B
			// 
			this.rad_B.AutoSize = true;
			this.rad_B.Location = new System.Drawing.Point(225, 88);
			this.rad_B.Name = "rad_B";
			this.rad_B.Size = new System.Drawing.Size(37, 17);
			this.rad_B.TabIndex = 20;
			this.rad_B.TabStop = true;
			this.rad_B.Text = "35";
			this.rad_B.UseVisualStyleBackColor = true;
			// 
			// rad_C
			// 
			this.rad_C.AutoSize = true;
			this.rad_C.Location = new System.Drawing.Point(225, 111);
			this.rad_C.Name = "rad_C";
			this.rad_C.Size = new System.Drawing.Size(31, 17);
			this.rad_C.TabIndex = 30;
			this.rad_C.TabStop = true;
			this.rad_C.Text = "8";
			this.rad_C.UseVisualStyleBackColor = true;
			// 
			// rad_D
			// 
			this.rad_D.AutoSize = true;
			this.rad_D.Location = new System.Drawing.Point(225, 134);
			this.rad_D.Name = "rad_D";
			this.rad_D.Size = new System.Drawing.Size(31, 17);
			this.rad_D.TabIndex = 40;
			this.rad_D.TabStop = true;
			this.rad_D.Text = "3";
			this.rad_D.UseVisualStyleBackColor = true;
			// 
			// rad_E
			// 
			this.rad_E.AutoSize = true;
			this.rad_E.Location = new System.Drawing.Point(225, 156);
			this.rad_E.Name = "rad_E";
			this.rad_E.Size = new System.Drawing.Size(37, 17);
			this.rad_E.TabIndex = 50;
			this.rad_E.TabStop = true;
			this.rad_E.Text = "78";
			this.rad_E.UseVisualStyleBackColor = true;
			// 
			// btn_Prox
			// 
			this.btn_Prox.BackColor = System.Drawing.Color.Transparent;
			this.btn_Prox.BackgroundImage = global::Quiz.Properties.Resources.botao;
			this.btn_Prox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btn_Prox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Prox.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Prox.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btn_Prox.Location = new System.Drawing.Point(525, 145);
			this.btn_Prox.Name = "btn_Prox";
			this.btn_Prox.Size = new System.Drawing.Size(105, 45);
			this.btn_Prox.TabIndex = 0;
			this.btn_Prox.Text = ">>";
			this.btn_Prox.UseCompatibleTextRendering = true;
			this.btn_Prox.UseVisualStyleBackColor = false;
			this.btn_Prox.Click += new System.EventHandler(this.button1_Click);
			// 
			// lbl_Questao
			// 
			this.lbl_Questao.AutoSize = true;
			this.lbl_Questao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Questao.Location = new System.Drawing.Point(221, 12);
			this.lbl_Questao.Name = "lbl_Questao";
			this.lbl_Questao.Size = new System.Drawing.Size(412, 40);
			this.lbl_Questao.TabIndex = 1;
			this.lbl_Questao.Text = "1 -  No ranking de empresas mais sustentáveis de \n2019, o Banco do Brasil ficou e" +
    "m qual posição?";
			// 
			// pic_Quiz
			// 
			this.pic_Quiz.Image = global::Quiz.Properties.Resources.logo;
			this.pic_Quiz.Location = new System.Drawing.Point(12, 12);
			this.pic_Quiz.Name = "pic_Quiz";
			this.pic_Quiz.Size = new System.Drawing.Size(200, 180);
			this.pic_Quiz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_Quiz.TabIndex = 0;
			this.pic_Quiz.TabStop = false;
			// 
			// frm_Q1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(100)))));
			this.ClientSize = new System.Drawing.Size(644, 201);
			this.Controls.Add(this.lbl_Questao);
			this.Controls.Add(this.btn_Prox);
			this.Controls.Add(this.rad_E);
			this.Controls.Add(this.rad_D);
			this.Controls.Add(this.rad_C);
			this.Controls.Add(this.rad_B);
			this.Controls.Add(this.rad_A);
			this.Controls.Add(this.pic_Quiz);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(660, 240);
			this.MinimumSize = new System.Drawing.Size(660, 240);
			this.Name = "frm_Q1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Questão 1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Q1_FormClosing);
			this.Load += new System.EventHandler(this.frm_Q1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pic_Quiz)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pic_Quiz;
		private System.Windows.Forms.RadioButton rad_A;
		private System.Windows.Forms.RadioButton rad_B;
		private System.Windows.Forms.RadioButton rad_C;
		private System.Windows.Forms.RadioButton rad_D;
		private System.Windows.Forms.RadioButton rad_E;
		private System.Windows.Forms.Button btn_Prox;
		private System.Windows.Forms.Label lbl_Questao;
	}
}

