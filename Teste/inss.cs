using INSS.Classe;
using INSS.Validacao.Regras;
using INSS.Validacao.Formatacao;
using System.Windows.Forms;
using System;

namespace WindowsFormsApp1.Teste
{
    public partial class inss : Form
    {
        public inss()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btncalcula_Click(object sender, EventArgs e)
        {
            CalculadorInss calcula = new CalculadorInss();


            string _ano = string.Empty;
            string _sal = string.Empty;

            if (String.IsNullOrEmpty(mtxtdata.Text) || !numerico.IsNumericPositive(mtxtdata.Text))
            {
                MessageBox.Show("Ano inválido!", "Aviso",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Warning);
                return;
            }
            else
            {
                _ano = this.mtxtdata.Text;
            }

            if (String.IsNullOrEmpty(txtsal.Text) ||numerico.IsZeroNegativo(txtsal.Text))
            {
                MessageBox.Show("Valor do salário inválido!", "Aviso",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Warning);
                return;

            }
            else
            {
                _sal = this.txtsal.Text;
            }



            this.mtxtdesc.Text = calcula.CalcularDesconto(int.Parse(_ano), Decimal.Parse(_sal)).ToString("C2", System.Globalization.CultureInfo.CurrentCulture);

        }

        private void txtsal_LostFocus(object sender, EventArgs e)
        {

            this.txtsal.Text = FormatosGerais.ToMoney(txtsal,"N2");
        }
      
    }
}
