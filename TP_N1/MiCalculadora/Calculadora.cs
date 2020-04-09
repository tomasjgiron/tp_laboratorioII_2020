using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.cmbOperador.Text = "+";
            this.lblResultado.Text = "";
            this.btnConvertirABinario.Enabled = false;
            this.btnConvertirADecimal.Enabled = false;
        }

        private static double Operar(string numero1, string numero2, string operador)
        {
            double resultado;
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);

            resultado = Calculadora.Operar(num1, num2, operador);

            return resultado;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();//Application.Exit();
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = false;
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = (FormCalculadora.Operar(txtNumero1.Text,
                txtNumero2.Text, cmbOperador.Text)).ToString();
            btnConvertirABinario.Enabled = true;
            btnConvertirADecimal.Enabled = false;
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if(!(lblResultado.Text is null) && lblResultado.Text != "Valor invalido")
            {
                Numero valor = new Numero(lblResultado.Text);
                 lblResultado.Text = valor.DecimalBinario(lblResultado.Text);
                 btnConvertirABinario.Enabled = false;
                 btnConvertirADecimal.Enabled = true;
            }
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            if(!(lblResultado.Text is null) && lblResultado.Text != "Valor invalido")
            {
                Numero valor = new Numero(lblResultado.Text);
                lblResultado.Text = valor.BinarioDecimal(lblResultado.Text);
                btnConvertirABinario.Enabled = true;
                btnConvertirADecimal.Enabled = false;
            }
        }
    }
}
