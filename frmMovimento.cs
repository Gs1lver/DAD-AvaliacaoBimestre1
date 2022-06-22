using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvaliacaoBimestre1
{
    public partial class frmMovimento : Form
    {
        static List<contaBancaria> lstConta = new List<contaBancaria>();
        private contaBancaria contaAtual = null;
        private int operacao = 0; //1 para Depositar e 2 para Sacar


        public frmMovimento()
        {
            InitializeComponent();
            this.Size = new Size(685, 255);
            lstConta = contaBancaria.geraContas();
        }

        private void frmMovimento_Load(object sender, EventArgs e)
        {
            rdComum.Enabled = false;
            rdEspecial.Enabled = false;
            txtLimite.Enabled = false;
            txtSaldo.Enabled = false;

        }

        private void bloqueiaGrpSuperior()
        {
            grpSuperior.Enabled = false;
            btnDepositar.Enabled = false;
            btnSacar.Enabled = false;
            btnSair.Enabled = false;
            this.Size = new Size(685, 365);
            grpMovimento.Visible = true;
            grpMovimento.Enabled = true;

        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            bloqueiaGrpSuperior();
            operacao = 1;
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            bloqueiaGrpSuperior();
            operacao = 2;
        }
        private void dtMovimento_Leave(object sender, EventArgs e)
        {
            if ((dtMovimento.Value.DayOfWeek == DayOfWeek.Sunday) ||
                (dtMovimento.Value.DayOfWeek == DayOfWeek.Saturday))
            {
                MessageBox.Show("Não é possível lançar dados aos sábados e aos domingos!", "Data Inválida!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtMovimento.Focus();
            }

        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtValor.Text) <= 0)
            {
                MessageBox.Show("Não é possível lançar valores negativos, nem nulos!", "Valor Inválido!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValor.Focus();
            }
        }

        private void btnLancar_Click(object sender, EventArgs e)
        {

            if (operacao == 1)
            {
                double Saldo = Convert.ToDouble(txtSaldo.Text);
                Saldo += Convert.ToDouble(txtValor.Text);
                txtSaldo.Text = Convert.ToString(Saldo);
                contaAtual.Saldo = Saldo;


                    grpSuperior.Enabled = true;
                    grpMovimento.Enabled = false;
                    this.Size = new Size(685, 255);
                    txtConta.Enabled = true;
                    btnDepositar.Enabled = true;
                    btnSacar.Enabled = true;
                    btnSair.Enabled = true;
                    txtValor.Text = "";
            }
            else if (operacao == 2)
            {
                double valorTotal = 0;
                valorTotal += Convert.ToDouble(txtSaldo.Text);
                if (rdEspecial.Checked)
                {
                    valorTotal += Convert.ToDouble(txtLimite.Text);
                }

                double lancamento = 0;
                lancamento = Convert.ToDouble(txtValor.Text);

                if(lancamento > valorTotal)
                {
                    MessageBox.Show("Insira um valor inferior ao saldo total!!", "Lançamento superior ao saldo total!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtValor.Focus();
                }else
                {
                    if (lancamento > Convert.ToDouble(txtSaldo.Text))
                    {
                        lancamento -= Convert.ToDouble(txtSaldo.Text);
                        txtSaldo.Text = "0";
                        double limite = Convert.ToDouble(txtLimite.Text);
                        limite -= lancamento;
                        txtLimite.Text = Convert.ToString(limite);
                   }
                    else
                    {
                        double Saldo = Convert.ToDouble(txtSaldo.Text);
                        Saldo -= Convert.ToDouble(txtValor.Text);
                        txtSaldo.Text = Convert.ToString(Saldo);
                        contaAtual.Saldo = Saldo;
                    }
                    


                    grpSuperior.Enabled = true;
                    grpMovimento.Enabled = false;
                    this.Size = new Size(685, 255);
                    txtConta.Enabled = true;
                    btnDepositar.Enabled = true;
                    btnSacar.Enabled = true;
                    btnSair.Enabled = true;
                    txtValor.Text = "";
                    
                }
            }



        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtConta_Leave(object sender, EventArgs e)
        {
            foreach(contaBancaria conta in lstConta)
            {
                if (conta.CodigoConta.Equals(txtConta.Text.Trim()))
                {
                    if (conta.Tipo == 0)
                    {
                        rdComum.Checked = true;
                    }
                    else
                    {
                        rdEspecial.Checked = true;
                    }
                    txtLimite.Text = conta.Limite.ToString();
                    txtSaldo.Text = conta.Saldo.ToString();
                    contaAtual = conta;
                }
            }
            if (txtSaldo.Text.Equals(""))
            {
                MessageBox.Show("Número da conta inválido.","Alerta de Sistema!",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConta.Focus();
            }

        }

        private void txtConta_TextChanged(object sender, EventArgs e)
        {
            rdComum.Enabled = false;
            rdComum.Checked = false;
            rdEspecial.Enabled = false;
            rdEspecial.Checked = false;
            txtLimite.Enabled = false;
            txtLimite.Text = "";
            txtSaldo.Enabled = false;
            txtSaldo.Text = "";
        }
    }
}
