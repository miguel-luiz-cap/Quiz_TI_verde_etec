namespace Quiz
{
	partial class frm_Resultados
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Resultados));
			this.rtb_Resultado = new System.Windows.Forms.RichTextBox();
			this.btn_Inicio = new System.Windows.Forms.Button();
			this.btn_Fim = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// rtb_Resultado
			// 
			this.rtb_Resultado.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.rtb_Resultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.rtb_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtb_Resultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.rtb_Resultado.Location = new System.Drawing.Point(0, 6);
			this.rtb_Resultado.Name = "rtb_Resultado";
			this.rtb_Resultado.ReadOnly = true;
			this.rtb_Resultado.Size = new System.Drawing.Size(364, 202);
			this.rtb_Resultado.TabIndex = 2;
			this.rtb_Resultado.Text = "";
			// 
			// btn_Inicio
			// 
			this.btn_Inicio.BackColor = System.Drawing.Color.Transparent;
			this.btn_Inicio.BackgroundImage = global::Quiz.Properties.Resources.botao;
			this.btn_Inicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btn_Inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
			this.btn_Inicio.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btn_Inicio.Location = new System.Drawing.Point(40, 210);
			this.btn_Inicio.Name = "btn_Inicio";
			this.btn_Inicio.Size = new System.Drawing.Size(125, 45);
			this.btn_Inicio.TabIndex = 0;
			this.btn_Inicio.Text = "Início";
			this.btn_Inicio.UseVisualStyleBackColor = false;
			this.btn_Inicio.Click += new System.EventHandler(this.btn_Inicio_Click);
			// 
			// btn_Fim
			// 
			this.btn_Fim.BackColor = System.Drawing.Color.Transparent;
			this.btn_Fim.BackgroundImage = global::Quiz.Properties.Resources.botao;
			this.btn_Fim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btn_Fim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Fim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Fim.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btn_Fim.Location = new System.Drawing.Point(200, 210);
			this.btn_Fim.Name = "btn_Fim";
			this.btn_Fim.Size = new System.Drawing.Size(125, 45);
			this.btn_Fim.TabIndex = 1;
			this.btn_Fim.Text = "Fim";
			this.btn_Fim.UseCompatibleTextRendering = true;
			this.btn_Fim.UseVisualStyleBackColor = false;
			this.btn_Fim.Click += new System.EventHandler(this.btn_Fim_Click);
			// 
			// frm_Resultados
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(100)))));
			this.ClientSize = new System.Drawing.Size(364, 261);
			this.Controls.Add(this.btn_Fim);
			this.Controls.Add(this.btn_Inicio);
			this.Controls.Add(this.rtb_Resultado);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(380, 300);
			this.MinimumSize = new System.Drawing.Size(380, 300);
			this.Name = "frm_Resultados";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Resultado";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Resultados_FormClosing);
			this.Load += new System.EventHandler(this.Carregar_Resultados);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox rtb_Resultado;
		private System.Windows.Forms.Button btn_Inicio;
		private System.Windows.Forms.Button btn_Fim;
	}
}