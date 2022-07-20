namespace SistemasNumericosCS
{
	partial class frmSistemasNumericosCS
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnTransformar = new System.Windows.Forms.Button();
			this.txtOut = new System.Windows.Forms.TextBox();
			this.txtIn = new System.Windows.Forms.TextBox();
			this.grpOut = new System.Windows.Forms.GroupBox();
			this.radHexaOut = new System.Windows.Forms.RadioButton();
			this.radDecimalOut = new System.Windows.Forms.RadioButton();
			this.radOctalOut = new System.Windows.Forms.RadioButton();
			this.radBinarioOut = new System.Windows.Forms.RadioButton();
			this.grpIn = new System.Windows.Forms.GroupBox();
			this.radHexa = new System.Windows.Forms.RadioButton();
			this.radDecimal = new System.Windows.Forms.RadioButton();
			this.radOctal = new System.Windows.Forms.RadioButton();
			this.radBinario = new System.Windows.Forms.RadioButton();
			this.grpOut.SuspendLayout();
			this.grpIn.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnTransformar
			// 
			this.btnTransformar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTransformar.Location = new System.Drawing.Point(146, 176);
			this.btnTransformar.Name = "btnTransformar";
			this.btnTransformar.Size = new System.Drawing.Size(75, 23);
			this.btnTransformar.TabIndex = 14;
			this.btnTransformar.Text = "Transformar";
			this.btnTransformar.UseVisualStyleBackColor = true;
			this.btnTransformar.Click += new System.EventHandler(this.btnTransformar_Click);
			// 
			// txtOut
			// 
			this.txtOut.Location = new System.Drawing.Point(230, 179);
			this.txtOut.Name = "txtOut";
			this.txtOut.Size = new System.Drawing.Size(100, 20);
			this.txtOut.TabIndex = 13;
			// 
			// txtIn
			// 
			this.txtIn.Location = new System.Drawing.Point(34, 179);
			this.txtIn.Name = "txtIn";
			this.txtIn.Size = new System.Drawing.Size(100, 20);
			this.txtIn.TabIndex = 12;
			this.txtIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIn_KeyPress);
			// 
			// grpOut
			// 
			this.grpOut.Controls.Add(this.radHexaOut);
			this.grpOut.Controls.Add(this.radDecimalOut);
			this.grpOut.Controls.Add(this.radOctalOut);
			this.grpOut.Controls.Add(this.radBinarioOut);
			this.grpOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpOut.Location = new System.Drawing.Point(208, 12);
			this.grpOut.Name = "grpOut";
			this.grpOut.Size = new System.Drawing.Size(130, 161);
			this.grpOut.TabIndex = 11;
			this.grpOut.TabStop = false;
			this.grpOut.Text = "Sistema de salida";
			// 
			// radHexaOut
			// 
			this.radHexaOut.AutoSize = true;
			this.radHexaOut.Location = new System.Drawing.Point(22, 100);
			this.radHexaOut.Name = "radHexaOut";
			this.radHexaOut.Size = new System.Drawing.Size(97, 17);
			this.radHexaOut.TabIndex = 3;
			this.radHexaOut.TabStop = true;
			this.radHexaOut.Text = "Hexadecimal";
			this.radHexaOut.UseVisualStyleBackColor = true;
			// 
			// radDecimalOut
			// 
			this.radDecimalOut.AutoSize = true;
			this.radDecimalOut.Location = new System.Drawing.Point(22, 77);
			this.radDecimalOut.Name = "radDecimalOut";
			this.radDecimalOut.Size = new System.Drawing.Size(70, 17);
			this.radDecimalOut.TabIndex = 2;
			this.radDecimalOut.TabStop = true;
			this.radDecimalOut.Text = "Decimal";
			this.radDecimalOut.UseVisualStyleBackColor = true;
			// 
			// radOctalOut
			// 
			this.radOctalOut.AutoSize = true;
			this.radOctalOut.Location = new System.Drawing.Point(22, 54);
			this.radOctalOut.Name = "radOctalOut";
			this.radOctalOut.Size = new System.Drawing.Size(55, 17);
			this.radOctalOut.TabIndex = 1;
			this.radOctalOut.TabStop = true;
			this.radOctalOut.Text = "Octal";
			this.radOctalOut.UseVisualStyleBackColor = true;
			// 
			// radBinarioOut
			// 
			this.radBinarioOut.AutoSize = true;
			this.radBinarioOut.Location = new System.Drawing.Point(22, 31);
			this.radBinarioOut.Name = "radBinarioOut";
			this.radBinarioOut.Size = new System.Drawing.Size(64, 17);
			this.radBinarioOut.TabIndex = 0;
			this.radBinarioOut.TabStop = true;
			this.radBinarioOut.Text = "Binario";
			this.radBinarioOut.UseVisualStyleBackColor = true;
			// 
			// grpIn
			// 
			this.grpIn.Controls.Add(this.radHexa);
			this.grpIn.Controls.Add(this.radDecimal);
			this.grpIn.Controls.Add(this.radOctal);
			this.grpIn.Controls.Add(this.radBinario);
			this.grpIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpIn.Location = new System.Drawing.Point(12, 12);
			this.grpIn.Name = "grpIn";
			this.grpIn.Size = new System.Drawing.Size(130, 161);
			this.grpIn.TabIndex = 10;
			this.grpIn.TabStop = false;
			this.grpIn.Text = "Sistema de entrada";
			// 
			// radHexa
			// 
			this.radHexa.AutoSize = true;
			this.radHexa.Location = new System.Drawing.Point(22, 100);
			this.radHexa.Name = "radHexa";
			this.radHexa.Size = new System.Drawing.Size(97, 17);
			this.radHexa.TabIndex = 3;
			this.radHexa.TabStop = true;
			this.radHexa.Text = "Hexadecimal";
			this.radHexa.UseVisualStyleBackColor = true;
			this.radHexa.CheckedChanged += new System.EventHandler(this.radHexa_CheckedChanged);
			// 
			// radDecimal
			// 
			this.radDecimal.AutoSize = true;
			this.radDecimal.Location = new System.Drawing.Point(22, 77);
			this.radDecimal.Name = "radDecimal";
			this.radDecimal.Size = new System.Drawing.Size(70, 17);
			this.radDecimal.TabIndex = 2;
			this.radDecimal.TabStop = true;
			this.radDecimal.Text = "Decimal";
			this.radDecimal.UseVisualStyleBackColor = true;
			this.radDecimal.CheckedChanged += new System.EventHandler(this.radDecimal_CheckedChanged);
			// 
			// radOctal
			// 
			this.radOctal.AutoSize = true;
			this.radOctal.Location = new System.Drawing.Point(22, 54);
			this.radOctal.Name = "radOctal";
			this.radOctal.Size = new System.Drawing.Size(55, 17);
			this.radOctal.TabIndex = 1;
			this.radOctal.TabStop = true;
			this.radOctal.Text = "Octal";
			this.radOctal.UseVisualStyleBackColor = true;
			this.radOctal.CheckedChanged += new System.EventHandler(this.radOctal_CheckedChanged);
			// 
			// radBinario
			// 
			this.radBinario.AutoSize = true;
			this.radBinario.Location = new System.Drawing.Point(22, 31);
			this.radBinario.Name = "radBinario";
			this.radBinario.Size = new System.Drawing.Size(64, 17);
			this.radBinario.TabIndex = 0;
			this.radBinario.TabStop = true;
			this.radBinario.Text = "Binario";
			this.radBinario.UseVisualStyleBackColor = true;
			this.radBinario.CheckedChanged += new System.EventHandler(this.radBinario_CheckedChanged);
			// 
			// frmSistemasNumericosCS
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(353, 213);
			this.Controls.Add(this.btnTransformar);
			this.Controls.Add(this.txtOut);
			this.Controls.Add(this.txtIn);
			this.Controls.Add(this.grpOut);
			this.Controls.Add(this.grpIn);
			this.Name = "frmSistemasNumericosCS";
			this.Text = "Sistemas Numericos";
			this.grpOut.ResumeLayout(false);
			this.grpOut.PerformLayout();
			this.grpIn.ResumeLayout(false);
			this.grpIn.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.Button btnTransformar;
		internal System.Windows.Forms.TextBox txtOut;
		internal System.Windows.Forms.TextBox txtIn;
		internal System.Windows.Forms.GroupBox grpOut;
		internal System.Windows.Forms.RadioButton radHexaOut;
		internal System.Windows.Forms.RadioButton radDecimalOut;
		internal System.Windows.Forms.RadioButton radOctalOut;
		internal System.Windows.Forms.RadioButton radBinarioOut;
		internal System.Windows.Forms.GroupBox grpIn;
		internal System.Windows.Forms.RadioButton radHexa;
		internal System.Windows.Forms.RadioButton radDecimal;
		internal System.Windows.Forms.RadioButton radOctal;
		internal System.Windows.Forms.RadioButton radBinario;
	}
}

