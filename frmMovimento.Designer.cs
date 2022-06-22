
namespace AvaliacaoBimestre1
{
    partial class frmMovimento
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
            this.txtConta = new System.Windows.Forms.TextBox();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnLancar = new System.Windows.Forms.Button();
            this.btnSacar = new System.Windows.Forms.Button();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.dtMovimento = new System.Windows.Forms.DateTimePicker();
            this.rdComum = new System.Windows.Forms.RadioButton();
            this.rdEspecial = new System.Windows.Forms.RadioButton();
            this.grpSuperior = new System.Windows.Forms.GroupBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblLimite = new System.Windows.Forms.Label();
            this.lblConta = new System.Windows.Forms.Label();
            this.grpMovimento = new System.Windows.Forms.GroupBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.grpSuperior.SuspendLayout();
            this.grpMovimento.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtConta
            // 
            this.txtConta.Location = new System.Drawing.Point(9, 49);
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(100, 20);
            this.txtConta.TabIndex = 0;
            // 
            // txtLimite
            // 
            this.txtLimite.Location = new System.Drawing.Point(315, 49);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(100, 20);
            this.txtLimite.TabIndex = 3;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(473, 49);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(100, 20);
            this.txtSaldo.TabIndex = 4;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(236, 47);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 22);
            this.txtValor.TabIndex = 9;
            // 
            // btnLancar
            // 
            this.btnLancar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLancar.Location = new System.Drawing.Point(469, 28);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(81, 39);
            this.btnLancar.TabIndex = 10;
            this.btnLancar.Text = "Lançar";
            this.btnLancar.UseVisualStyleBackColor = true;
            // 
            // btnSacar
            // 
            this.btnSacar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacar.Location = new System.Drawing.Point(191, 130);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(122, 64);
            this.btnSacar.TabIndex = 6;
            this.btnSacar.Text = "SACAR";
            this.btnSacar.UseVisualStyleBackColor = false;
            // 
            // btnDepositar
            // 
            this.btnDepositar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDepositar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepositar.Location = new System.Drawing.Point(37, 130);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(122, 64);
            this.btnDepositar.TabIndex = 5;
            this.btnDepositar.Text = "DEPOSITAR";
            this.btnDepositar.UseVisualStyleBackColor = false;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(510, 130);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(122, 64);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "S A I R";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // dtMovimento
            // 
            this.dtMovimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtMovimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtMovimento.Location = new System.Drawing.Point(5, 47);
            this.dtMovimento.Name = "dtMovimento";
            this.dtMovimento.Size = new System.Drawing.Size(101, 22);
            this.dtMovimento.TabIndex = 8;
            // 
            // rdComum
            // 
            this.rdComum.AutoSize = true;
            this.rdComum.Location = new System.Drawing.Point(154, 26);
            this.rdComum.Name = "rdComum";
            this.rdComum.Size = new System.Drawing.Size(91, 17);
            this.rdComum.TabIndex = 1;
            this.rdComum.TabStop = true;
            this.rdComum.Text = "Conta Comum";
            this.rdComum.UseVisualStyleBackColor = true;
            // 
            // rdEspecial
            // 
            this.rdEspecial.AutoSize = true;
            this.rdEspecial.Location = new System.Drawing.Point(154, 49);
            this.rdEspecial.Name = "rdEspecial";
            this.rdEspecial.Size = new System.Drawing.Size(96, 17);
            this.rdEspecial.TabIndex = 2;
            this.rdEspecial.TabStop = true;
            this.rdEspecial.Text = "Conta Especial";
            this.rdEspecial.UseVisualStyleBackColor = true;
            // 
            // grpSuperior
            // 
            this.grpSuperior.Controls.Add(this.lblSaldo);
            this.grpSuperior.Controls.Add(this.lblLimite);
            this.grpSuperior.Controls.Add(this.lblConta);
            this.grpSuperior.Controls.Add(this.rdEspecial);
            this.grpSuperior.Controls.Add(this.rdComum);
            this.grpSuperior.Controls.Add(this.txtSaldo);
            this.grpSuperior.Controls.Add(this.txtLimite);
            this.grpSuperior.Controls.Add(this.txtConta);
            this.grpSuperior.Location = new System.Drawing.Point(37, 13);
            this.grpSuperior.Name = "grpSuperior";
            this.grpSuperior.Size = new System.Drawing.Size(596, 98);
            this.grpSuperior.TabIndex = 4;
            this.grpSuperior.TabStop = false;
            this.grpSuperior.Text = "groupBox1";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(470, 26);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(44, 16);
            this.lblSaldo.TabIndex = 4;
            this.lblSaldo.Text = "Saldo";
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimite.Location = new System.Drawing.Point(312, 26);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(43, 16);
            this.lblLimite.TabIndex = 4;
            this.lblLimite.Text = "Limite";
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConta.Location = new System.Drawing.Point(6, 27);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(60, 16);
            this.lblConta.TabIndex = 4;
            this.lblConta.Text = "Nr.Conta";
            // 
            // grpMovimento
            // 
            this.grpMovimento.Controls.Add(this.dtMovimento);
            this.grpMovimento.Controls.Add(this.btnLancar);
            this.grpMovimento.Controls.Add(this.lblValor);
            this.grpMovimento.Controls.Add(this.lblData);
            this.grpMovimento.Controls.Add(this.txtValor);
            this.grpMovimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMovimento.Location = new System.Drawing.Point(41, 221);
            this.grpMovimento.Name = "grpMovimento";
            this.grpMovimento.Size = new System.Drawing.Size(591, 90);
            this.grpMovimento.TabIndex = 5;
            this.grpMovimento.TabStop = false;
            this.grpMovimento.Text = "Movimento:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(233, 28);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(40, 16);
            this.lblValor.TabIndex = 4;
            this.lblValor.Text = "Valor";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(6, 28);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(37, 16);
            this.lblData.TabIndex = 4;
            this.lblData.Text = "Data";
            // 
            // frmMovimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(669, 326);
            this.Controls.Add(this.grpMovimento);
            this.Controls.Add(this.grpSuperior);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSacar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMovimento";
            this.Text = "Movimento de Contas";
            this.Load += new System.EventHandler(this.frmMovimento_Load);
            this.grpSuperior.ResumeLayout(false);
            this.grpSuperior.PerformLayout();
            this.grpMovimento.ResumeLayout(false);
            this.grpMovimento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.TextBox txtLimite;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnLancar;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DateTimePicker dtMovimento;
        private System.Windows.Forms.RadioButton rdComum;
        private System.Windows.Forms.RadioButton rdEspecial;
        private System.Windows.Forms.GroupBox grpSuperior;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.Label lblConta;
        private System.Windows.Forms.GroupBox grpMovimento;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblData;
    }
}

