namespace Quiz
{
	partial class frm_TelaInicial
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TelaInicial));
			this.btn_Comecar = new System.Windows.Forms.Button();
			this.btn_Sair = new System.Windows.Forms.Button();
			this.pic_TelaInicial = new System.Windows.Forms.PictureBox();
			this.btnSobre = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pic_TelaInicial)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_Comecar
			// 
			this.btn_Comecar.Location = new System.Drawing.Point(9, 337);
			this.btn_Comecar.Name = "btn_Comecar";
			this.btn_Comecar.Size = new System.Drawing.Size(100, 35);
			this.btn_Comecar.TabIndex = 0;
			this.btn_Comecar.Text = "Começar";
			this.btn_Comecar.UseVisualStyleBackColor = true;
			this.btn_Comecar.Click += new System.EventHandler(this.btn_Comecar_Click);
			// 
			// btn_Sair
			// 
			this.btn_Sair.Location = new System.Drawing.Point(224, 337);
			this.btn_Sair.Name = "btn_Sair";
			this.btn_Sair.Size = new System.Drawing.Size(100, 35);
			this.btn_Sair.TabIndex = 2;
			this.btn_Sair.Text = "Sair";
			this.btn_Sair.UseVisualStyleBackColor = true;
			this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
			// 
			// pic_TelaInicial
			// 
			this.pic_TelaInicial.Image = global::Quiz.Properties.Resources.logo;
			this.pic_TelaInicial.Location = new System.Drawing.Point(9, 12);
			this.pic_TelaInicial.Name = "pic_TelaInicial";
			this.pic_TelaInicial.Size = new System.Drawing.Size(315, 315);
			this.pic_TelaInicial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_TelaInicial.TabIndex = 0;
			this.pic_TelaInicial.TabStop = false;
			// 
			// btnSobre
			// 
			this.btnSobre.Location = new System.Drawing.Point(117, 337);
			this.btnSobre.Name = "btnSobre";
			this.btnSobre.Size = new System.Drawing.Size(100, 35);
			this.btnSobre.TabIndex = 1;
			this.btnSobre.Text = "Sobre";
			this.btnSobre.UseVisualStyleBackColor = true;
			this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
			// 
			// frm_TelaInicial
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(100)))));
			this.ClientSize = new System.Drawing.Size(334, 381);
			this.Controls.Add(this.btnSobre);
			this.Controls.Add(this.btn_Sair);
			this.Controls.Add(this.btn_Comecar);
			this.Controls.Add(this.pic_TelaInicial);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(350, 420);
			this.MinimumSize = new System.Drawing.Size(350, 420);
			this.Name = "frm_TelaInicial";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quiz TI Verde";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_TelaInicial_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.pic_TelaInicial)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pic_TelaInicial;
		private System.Windows.Forms.Button btn_Comecar;
		private System.Windows.Forms.Button btn_Sair;
		private System.Windows.Forms.Button btnSobre;
	}
}