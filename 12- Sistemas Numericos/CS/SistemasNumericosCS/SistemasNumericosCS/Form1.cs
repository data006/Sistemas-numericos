using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace SistemasNumericosCS
{
	public partial class frmSistemasNumericosCS : Form
	{


		

		private int i, dec;
		private string salida;
		private int salidaInt;
		private string[] binario = new string[69696];
		private string[] octal = new string[69696];
		private string[] hex = new string[69696];
		private string hexa;
		private int modulo;



		public frmSistemasNumericosCS()
		{
			InitializeComponent();
		}

		private void btnTransformar_Click(object sender, EventArgs e)
		{
			if (txtIn.Text != string.Empty)
			{
				i = 0;
				if (radDecimalOut.Checked == true)
				{
					if (radBinario.Checked == true)
					{
						binToDec(0);
					}
					else if (radOctal.Checked == true)
					{
						octToDec(0);
					}
					else if (radHexa.Checked == true)
					{
						hexToDec(0);
					}
				}
				else if (radBinarioOut.Checked == true)
				{
					if (radDecimal.Checked == true)
					{
						decToBin(0);
					}
					else if (radOctal.Checked == true)
					{
						octToDec(1);
						decToBin(1);
					}
					else if (radHexa.Checked == true)
					{
						hexToDec(1);
						decToBin(1);
					}
				}
				else if (radOctalOut.Checked == true)
				{
					if (radBinario.Checked == true)
					{
						binToDec(1);
						decToOct(1);
					}
					else if (radDecimal.Checked == true)
					{
						decToOct(0);
					}
					else if (radHexa.Checked == true)
					{
						hexToDec(1);
						decToOct(1);
					}
				}
				else if (radHexaOut.Checked == true)
				{
					if (radBinario.Checked == true)
					{
						binToDec(1);
						decToHex(1);
					}
					else if (radOctal.Checked == true)
					{
						octToDec(1);
						decToHex(1);
					}
					else if (radDecimal.Checked == true)
					{
						decToHex(0);
					}
				}
			}

			dec = 0;
			salida = "";
			salidaInt = 0;
		}







		
		






		// Decimal a Binario
		public void decToBin(int ex)
		{
			if (ex == 0)
			{
				dec = Conversions.ToInteger(txtIn.Text);
			}

			while (dec >= 1)
			{
				modulo = dec % 2;
				binario[i] = Conversions.ToString(modulo);
				dec /= 2;
				salida += binario[i];
				i += 1;
			}

			txtOut.Text = Strings.StrReverse(salida);
			Array.Clear(binario, 0, binario.Length);
		}

		




		// Decimal a Hexadecimal
		public void decToHex(int ex)
		{
			if (ex == 0)
			{
				dec = Conversions.ToInteger(txtIn.Text);
			}

			while (dec >= 1)
			{
				int modulo;
				modulo = dec % 16;
				dec /= 16;
				hex[i] = Conversions.ToString(modulo);
				var switchExpr = hex[i];
				switch (switchExpr)
				{
					case var @case when @case == Conversions.ToString(15):
						{
							salida += "F";
							break;
						}

					case var case1 when case1 == Conversions.ToString(14):
						{
							salida += "E";
							break;
						}

					case var case2 when case2 == Conversions.ToString(13):
						{
							salida += "D";
							break;
						}

					case var case3 when case3 == Conversions.ToString(12):
						{
							salida += "C";
							break;
						}

					case var case4 when case4 == Conversions.ToString(11):
						{
							salida += "B";
							break;
						}

					case var case5 when case5 == Conversions.ToString(10):
						{
							salida += "A";
							break;
						}

					default:
						{
							salida += hex[i];
							break;
						}
				}

				i += 1;
			}

			txtOut.Text = Strings.StrReverse(salida);
			Array.Clear(hex, 0, hex.Length);
		}

		





		// Decimal a Octal
		public void decToOct(int ex)
		{
			if (ex == 0)
			{
				dec = Conversions.ToInteger(txtIn.Text);
			}

			while (dec >= 1)
			{
				int modulo;
				modulo = dec % 8;
				dec /= 8;
				octal[i] = Conversions.ToString(modulo);
				salida += octal[i];
				i += 1;
			}

			txtOut.Text = Strings.StrReverse(salida);
			Array.Clear(octal, 0, octal.Length);
		}

		









		// Hexadecimal a Decimal
		public void hexToDec(int ex)
		{
			int largo = txtIn.Text.Length;
			foreach (char j in txtIn.Text)
			{
				switch (j)
				{
					case 'F':
						{
							hexa = "15";
							break;
						}

					case 'E':
						{
							hexa = "14";
							break;
						}

					case 'D':
						{
							hexa = "13";
							break;
						}

					case 'C':
						{
							hexa = "12";
							break;
						}

					case 'B':
						{
							hexa = "11";
							break;
						}

					case 'A':
						{
							hexa = "10";
							break;
						}

					default:
						{
							hexa = Conversions.ToString(j);
							break;
						}
				}

				salidaInt += int.Parse(hexa) * Convert.ToInt32(Math.Pow(16, Conversions.ToDouble(largo) - 1));
				largo -= 1;
				i += 1;
			}

			if (ex == 0)
			{
				txtOut.Text = salidaInt.ToString();
			}
			else if (ex == 1)
			{
				dec = Conversions.ToInteger(salidaInt);
				salidaInt = 0;
			}
		}
	












		// Binario a Decimal
		public void binToDec(int ex)
		{
			int bin = txtIn.Text.Length;
			foreach (char j in txtIn.Text)
			{
				salidaInt += int.Parse(Conversions.ToString(j)) * Convert.ToInt32(Math.Pow(2, bin - 1));
				bin -= 1;
				i += 1;
			}

			if (ex == 0)
			{
				txtOut.Text = salidaInt.ToString();
			}
			else if (ex == 1)
			{
				dec = Conversions.ToInteger(salidaInt);
				salidaInt = 0;
			}
		}







		// Octal a Decimal
		public void octToDec(int ex)
		{
			int oct = txtIn.Text.Length;
			foreach (char j in txtIn.Text)
			{
				salidaInt += int.Parse(Conversions.ToString(j)) * Convert.ToInt32(Math.Pow(8, oct - 1));
				oct -= 1;
				i += 1;
			}

			if (ex == 0)
			{
				txtOut.Text = salidaInt.ToString();
			}
			else if (ex == 1)
			{
				dec = Conversions.ToInteger(salidaInt);
				salidaInt = 0;
			}
		}









		//Bloqueo de radiobotones
		private void radBinario_CheckedChanged(object sender, EventArgs e)
		{

			if (radBinario.Checked)
			{
				radBinarioOut.Enabled = false;
				radBinarioOut.Checked = false;
			}
			else if (!radBinario.Checked)
			{
				radBinarioOut.Enabled = true;
				txtIn.Text = string.Empty;
			}

		}


		private void radOctal_CheckedChanged(object sender, EventArgs e)
		{
			if (radOctal.Checked)
			{
				radOctalOut.Enabled = false;
				radOctalOut.Checked = false;
			}
			else if (!radOctal.Checked)
			{
				radOctalOut.Enabled = true;
				txtIn.Text = string.Empty;
			}
		}

		private void radDecimal_CheckedChanged(object sender, EventArgs e)
		{
			if (radDecimal.Checked)
			{
				radDecimalOut.Enabled = false;
				radDecimalOut.Checked = false;
			}
			else if (!radDecimal.Checked)
			{
				radDecimalOut.Enabled = true;
				txtIn.Text = string.Empty;
			}
		}

		private void radHexa_CheckedChanged(object sender, EventArgs e)
		{
			if (radHexa.Checked)
			{
				radHexaOut.Enabled = false;
				radHexaOut.Checked = false;
			}
			else if (!radHexa.Checked)
			{
				radHexaOut.Enabled = true;
				txtIn.Text = string.Empty;
			}
		}









		// Bloqueo de teclas segun el sistema seleccionado
		private void txtIn_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Binario
			if (radBinario.Checked)
			{
				e.Handled = !(Conversions.ToString(e.KeyChar) == "1") & !(Conversions.ToString(e.KeyChar) == "0") & !char.IsControl(e.KeyChar);
			}



			// Decimal
			else if (radDecimal.Checked)
			{
				e.Handled = !char.IsNumber(e.KeyChar) & !char.IsControl(e.KeyChar);
			}





			// Octal
			else if (radOctal.Checked)
			{
				e.Handled = !(Conversions.ToString(e.KeyChar) == "0") & !(Conversions.ToString(e.KeyChar) == "1") & !(Conversions.ToString(e.KeyChar) == "2") & !(Conversions.ToString(e.KeyChar) == "3") & !(Conversions.ToString(e.KeyChar) == "4") & !(Conversions.ToString(e.KeyChar) == "5") & !(Conversions.ToString(e.KeyChar) == "6") & !(Conversions.ToString(e.KeyChar) == "7") & !char.IsControl(e.KeyChar);
			}







			// Hexadecimal
			else if (radHexa.Checked)
			{
				e.Handled = !(Conversions.ToString(e.KeyChar) == "0") & !(Conversions.ToString(e.KeyChar) == "1") & !(Conversions.ToString(e.KeyChar) == "2") & !(Conversions.ToString(e.KeyChar) == "3") & !(Conversions.ToString(e.KeyChar) == "4") & !(Conversions.ToString(e.KeyChar) == "5") & !(Conversions.ToString(e.KeyChar) == "6") & !(Conversions.ToString(e.KeyChar) == "7") & !(Conversions.ToString(e.KeyChar) == "8") & !(Conversions.ToString(e.KeyChar) == "9") & !(Conversions.ToString(e.KeyChar) == "A") & !(Conversions.ToString(e.KeyChar) == "B") & !(Conversions.ToString(e.KeyChar) == "C") & !(Conversions.ToString(e.KeyChar) == "D") & !(Conversions.ToString(e.KeyChar) == "E") & !(Conversions.ToString(e.KeyChar) == "F") & !char.IsControl(e.KeyChar);
			}
		}

	}
}
