using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador_Investimento
{
    public partial class Simulador : Form
    {
        public Simulador()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            rdbTxmes.Checked = true;
            rdbMeses.Checked = true;
            txtInicial.Text = "R$ 0,00";
            txtMensal.Text = "R$ 0,00";
            label4.Select();
        }


        private void txtRendimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            //txt aceita numeros e virgulas
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            //txt aceita apenas uma virgula
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtTempo_KeyPress(object sender, KeyPressEventArgs e) 
        {
            //txt aceita apenas numeros
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) 
            { 
                e.Handled = true; 
            }
        }

        private void txtMensal_KeyPress(object sender, KeyPressEventArgs e) 
        {
            //txt aceita numeros e virgulas
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            //txt aceita apenas uma virgula
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            //pega a posição da virgula:
            int posSeparator = txtMensal.Text.IndexOf(',');
            //pega posição do cursor
            int posCursor = txtMensal.SelectionStart;
            //se a virgula existir
            if (posSeparator != -1)
            {
                //se o cursor tiver após a virgula E já tiver duas casas após a virgula, ele nega o dígito
                if ((posCursor > posSeparator) && ((txtMensal.TextLength - posSeparator) > 2) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            //txt aceita numeros e virgulas
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            //txt aceita apenas uma virgula
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            //pega a posição da virgula:
            int posSeparator = txtInicial.Text.IndexOf(',');
            //pega posição do cursor
            int posCursor = txtInicial.SelectionStart;
            //se a virgula existir
            if (posSeparator != -1)
            {
                //se o cursor tiver após a virgula E já tiver duas casas após a virgula, ele nega o dígito
                if ((posCursor > posSeparator) && ((txtInicial.TextLength - posSeparator) > 2) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }

        }

        private void txtMensal_Enter(object sender, EventArgs e)
        {
            if (txtMensal.Text == "R$ 0,00")
            {
                txtMensal.Clear();
            }
            else
            {
                string trim = txtMensal.Text;
                //retira os caracteres desejados (espaço, R, $ e .)
                trim = trim.Replace(" ", "").Replace("R", "").Replace("$", "").Replace(".", "");
                txtMensal.Text = trim;
            }
        }

        private void txtInicial_Enter(object sender, EventArgs e)
        {
            if (txtInicial.Text == "R$ 0,00")
            {
                txtInicial.Clear();
            }
            else
            {
                string trim = txtInicial.Text;
                //retira os caracteres desejados (espaço, R, $ e .)
                trim = trim.Replace(" ", "").Replace("R", "").Replace("$", "").Replace(".", "");
                txtInicial.Text = trim;
            }
        }        
        
        private void txtInicial_Leave(object sender, EventArgs e)
        {
            Double value;
            string valor = txtInicial.Text.Trim(new Char[] { ' ', 'R', '$', '.' });
            if (Double.TryParse(valor, out value))
            {                
                valor = string.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N}", value);
                txtInicial.Text = "R$ " + valor;
            }
            else if (string.IsNullOrEmpty(txtInicial.Text))
            {
                txtInicial.Text = "R$ 0,00";
            }
            else
                MessageBox.Show("Digite um valor correto!");
        }

        private void txtMensal_Leave(object sender, EventArgs e)
        {
            Double value;
            string valor = txtMensal.Text.Trim(new Char[] { ' ', 'R', '$', '.' }); ;
            if (Double.TryParse(valor, out value))
            {
                valor = string.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N}", value);
                txtMensal.Text = "R$ " + valor;
            }
            else if (string.IsNullOrEmpty(txtMensal.Text))
            {
                txtMensal.Text = "R$ 0,00";
            }
            else
                MessageBox.Show("Digite um valor correto!");
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInicial.Text) || (txtInicial.Text == "R$ 0,00"))
            {
                if (string.IsNullOrEmpty(txtInicial.Text))
                {
                    MessageBox.Show("Digite o valor inicial do investimento");
                }
                else
                {
                    MessageBox.Show("O valor inicial do investimento não pode ser R$ 0,00");
                }
                                
            }
            else if (string.IsNullOrEmpty(txtTempo.Text))
            {
                MessageBox.Show("Digite o tempo do investimento");
            }
            else if (string.IsNullOrEmpty(txtRendimento.Text))
            {
                MessageBox.Show("Digite o rendimento do investimento");
            }
            else
            {
                //fazer retirar o R$
                double valorinicial = Convert.ToDouble(txtInicial.Text.Trim(new Char[] { ' ', 'R', '$' }));
                double valormensal = Convert.ToDouble(txtMensal.Text.Trim(new Char[] { ' ', 'R', '$' }));
                double rendimento = (Convert.ToDouble(txtRendimento.Text) / 100);
                double valorfinal;

                int tempo = Convert.ToInt32(txtTempo.Text);

                //verificar tempo em meses ou anos
                if (rdbAnos.Checked == true)
                {
                    tempo = tempo * 12;
                }

                //simulação sem incremento
                if (valormensal == 0.00)
                {
                    valorfinal = valorinicial;

                    //taxa mensal
                    if (rdbTxmes.Checked == true)
                    {
                        for (int i = 0; i < tempo; i++)
                        {
                            valorfinal += valorfinal * rendimento;
                        }
                        MessageBox.Show("O valor final é de R$: " + string.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N}", valorfinal), "Resultado");
                                               
                    }

                    else
                    {
                        for (int i = 0; i < tempo; i++)
                        {
                            valorfinal += valorfinal * (rendimento / 12);
                        }
                        MessageBox.Show("O valor final é de R$: " + string.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N}", valorfinal), "Resultado");                                              
                    }

                }

                //simulação com incremento
                else
                {
                    valorfinal = valorinicial;

                    //taxa mensal
                    if (rdbTxmes.Checked == true)
                    {
                        for (int i = 0; i < tempo; i++)
                        {
                            valorfinal += (valorfinal * rendimento) + valormensal;
                        }
                        MessageBox.Show("O valor final é de R$: " + string.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N}", valorfinal), "Resultado");                                            
                    }

                    else
                    {
                        for (int i = 0; i < tempo; i++)
                        {
                            valorfinal += (valorfinal * (rendimento / 12)) + valormensal;
                        }
                        MessageBox.Show("O valor final é de R$: " + string.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N}", valorfinal), "Resultado");
                    }
                }
            }
        }       
    }
}
