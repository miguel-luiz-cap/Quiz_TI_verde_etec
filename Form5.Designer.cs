namespace Quiz
{
	partial class frm_Q5
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Q5));
			this.lbl_Questao = new System.Windows.Forms.Label();
			this.rad_E = new System.Windows.Forms.RadioButton();
			this.rad_D = new System.Windows.Forms.RadioButton();
			this.rad_C = new System.Windows.Forms.RadioButton();
			this.rad_B = new System.Windows.Forms.RadioButton();
			this.rad_A = new System.Windows.Forms.RadioButton();
			this.pic_Quiz = new System.Windows.Forms.PictureBox();
			this.btnProx = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pic_Quiz)).BeginInit();
			this.SuspendLayout();
			// 
			// lbl_Questao
			// 
			this.lbl_Questao.AutoSize = true;
			this.lbl_Questao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Questao.Location = new System.Drawing.Point(218, 12);
			this.lbl_Questao.Name = "lbl_Questao";
			this.lbl_Questao.Size = new System.Drawing.Size(405, 40);
			this.lbl_Questao.TabIndex = 15;
			this.lbl_Questao.Text = "5 - Como é chamado o plano de sustentabilidade \r\ndo Banco do Brasil?";
			// 
			// rad_E
			// 
			this.rad_E.AutoSize = true;
			this.rad_E.Location = new System.Drawing.Point(222, 155);
			this.rad_E.Name = "rad_E";
			this.rad_E.Size = new System.Drawing.Size(105, 17);
			this.rad_E.TabIndex = 21;
			this.rad_E.TabStop = true;
			this.rad_E.Text = "Economia verde ";
			this.rad_E.UseVisualStyleBackColor = true;
			// 
			// rad_D
			// 
			this.rad_D.AutoSize = true;
			this.rad_D.Location = new System.Drawing.Point(222, 132);
			this.rad_D.Name = "rad_D";
			this.rad_D.Size = new System.Drawing.Size(94, 17);
			this.rad_D.TabIndex = 20;
			this.rad_D.TabStop = true;
			this.rad_D.Text = "Agenda 21 BB";
			this.rad_D.UseVisualStyleBackColor = true;
			// 
			// rad_C
			// 
			this.rad_C.AutoSize = true;
			this.rad_C.Location = new System.Drawing.Point(222, 109);
			this.rad_C.Name = "rad_C";
			this.rad_C.Size = new System.Drawing.Size(107, 17);
			this.rad_C.TabIndex = 19;
			this.rad_C.TabStop = true;
			this.rad_C.Text = "Brasil sustentável";
			this.rad_C.UseVisualStyleBackColor = true;
			// 
			// rad_B
			// 
			this.rad_B.AutoSize = true;
			this.rad_B.Location = new System.Drawing.Point(222, 86);
			this.rad_B.Name = "rad_B";
			this.rad_B.Size = new System.Drawing.Size(94, 17);
			this.rad_B.TabIndex = 18;
			this.rad_B.TabStop = true;
			this.rad_B.Text = "Agenda 20 BB";
			this.rad_B.UseVisualStyleBackColor = true;
			// 
			// rad_A
			// 
			this.rad_A.AutoSize = true;
			this.rad_A.Location = new System.Drawing.Point(222, 64);
			this.rad_A.Name = "rad_A";
			this.rad_A.Size = new System.Drawing.Size(94, 17);
			this.rad_A.TabIndex = 17;
			this.rad_A.TabStop = true;
			this.rad_A.Text = "Agenda 30 BB";
			this.rad_A.UseVisualStyleBackColor = true;
			// 
			// pic_Quiz
			// 
			this.pic_Quiz.Image = global::Quiz.Properties.Resources.logo;
			this.pic_Quiz.Location = new System.Drawing.Point(12, 12);
			this.pic_Quiz.Name = "pic_Quiz";
			this.pic_Quiz.Size = new System.Drawing.Size(200, 180);
			this.pic_Quiz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_Quiz.TabIndex = 16;
			this.pic_Quiz.TabStop = false;
			// 
			// btnProx
			// 
			this.btnProx.BackColor = System.Drawing.Color.Transparent;
			this.btnProx.BackgroundImage = global::Quiz.Properties.Resources.botao;
			this.btnProx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnProx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnProx.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnProx.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnProx.Location = new System.Drawing.Point(525, 145);
			this.btnProx.Name = "btnProx";
			this.btnProx.Size = new System.Drawing.Size(105, 45);
			this.btnProx.TabIndex = 0;
			this.btnProx.Text = ">>";
			this.btnProx.UseCompatibleTextRendering = true;
			this.btnProx.UseVisualStyleBackColor = false;
			this.btnProx.Click += new System.EventHandler(this.btn_Concluir_Click);
			// 
			// frm_Q5
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(100)))));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(644, 201);
			this.Controls.Add(this.btnProx);
			this.Controls.Add(this.lbl_Questao);
			this.Controls.Add(this.rad_E);
			this.Controls.Add(this.rad_D);
			this.Controls.Add(this.rad_C);
			this.Controls.Add(this.rad_B);
			this.Controls.Add(this.rad_A);
			this.Controls.Add(this.pic_Quiz);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(660, 240);
			this.MinimumSize = new System.Drawing.Size(660, 240);
			this.Name = "frm_Q5";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Questão 5";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Q5_FormClosing);
			this.Load += new System.EventHandler(this.frm_Q5_Load);
			((System.ComponentModel.ISupportInitialize)(this.pic_Quiz)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_Questao;
		private System.Windows.Forms.RadioButton rad_E;
		private System.Windows.Forms.RadioButton rad_D;
		private System.Windows.Forms.RadioButton rad_C;
		private System.Windows.Forms.RadioButton rad_B;
		private System.Windows.Forms.RadioButton rad_A;
		private System.Windows.Forms.PictureBox pic_Quiz;
		private System.Windows.Forms.Button btnProx;
	}
}