
namespace Simulador_Investimento
{
    partial class Simulador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Simulador));
            this.label1 = new System.Windows.Forms.Label();
            this.txtInicial = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtMensal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.rdbMeses = new System.Windows.Forms.RadioButton();
            this.rdbAnos = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRendimento = new System.Windows.Forms.TextBox();
            this.lblTextovalor = new System.Windows.Forms.Label();
            this.lblvalor = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rsbTxano = new System.Windows.Forms.RadioButton();
            this.rdbTxmes = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Depósito inicial";
            // 
            // txtInicial
            // 
            this.txtInicial.Location = new System.Drawing.Point(34, 79);
            this.txtInicial.MaxLength = 16;
            this.txtInicial.Name = "txtInicial";
            this.txtInicial.Size = new System.Drawing.Size(100, 20);
            this.txtInicial.TabIndex = 1;
            this.txtInicial.Enter += new System.EventHandler(this.txtInicial_Enter);
            this.txtInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInicial_KeyPress);
            this.txtInicial.Leave += new System.EventHandler(this.txtInicial_Leave);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(126, 190);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(106, 48);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtMensal
            // 
            this.txtMensal.Location = new System.Drawing.Point(222, 79);
            this.txtMensal.MaxLength = 14;
            this.txtMensal.Name = "txtMensal";
            this.txtMensal.Size = new System.Drawing.Size(100, 20);
            this.txtMensal.TabIndex = 4;
            this.txtMensal.Enter += new System.EventHandler(this.txtMensal_Enter);
            this.txtMensal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMensal_KeyPress);
            this.txtMensal.Leave += new System.EventHandler(this.txtMensal_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(217, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Depósito mensal";
            // 
            // txtTempo
            // 
            this.txtTempo.Location = new System.Drawing.Point(22, 20);
            this.txtTempo.MaxLength = 4;
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(100, 21);
            this.txtTempo.TabIndex = 6;
            this.txtTempo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTempo_KeyPress);
            // 
            // rdbMeses
            // 
            this.rdbMeses.AutoSize = true;
            this.rdbMeses.Location = new System.Drawing.Point(14, 43);
            this.rdbMeses.Name = "rdbMeses";
            this.rdbMeses.Size = new System.Drawing.Size(62, 19);
            this.rdbMeses.TabIndex = 7;
            this.rdbMeses.TabStop = true;
            this.rdbMeses.Text = "Meses";
            this.rdbMeses.UseVisualStyleBackColor = true;
            // 
            // rdbAnos
            // 
            this.rdbAnos.AutoSize = true;
            this.rdbAnos.Location = new System.Drawing.Point(76, 42);
            this.rdbAnos.Name = "rdbAnos";
            this.rdbAnos.Size = new System.Drawing.Size(52, 19);
            this.rdbAnos.TabIndex = 8;
            this.rdbAnos.TabStop = true;
            this.rdbAnos.Text = "Anos";
            this.rdbAnos.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Simule seu Investimento";
            // 
            // txtRendimento
            // 
            this.txtRendimento.Location = new System.Drawing.Point(47, 20);
            this.txtRendimento.MaxLength = 6;
            this.txtRendimento.Name = "txtRendimento";
            this.txtRendimento.Size = new System.Drawing.Size(48, 21);
            this.txtRendimento.TabIndex = 11;
            this.txtRendimento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRendimento_KeyPress);
            // 
            // lblTextovalor
            // 
            this.lblTextovalor.AutoSize = true;
            this.lblTextovalor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextovalor.Location = new System.Drawing.Point(58, 250);
            this.lblTextovalor.Name = "lblTextovalor";
            this.lblTextovalor.Size = new System.Drawing.Size(186, 20);
            this.lblTextovalor.TabIndex = 13;
            this.lblTextovalor.Text = "Seu valor final será de: ";
            this.lblTextovalor.Visible = false;
            // 
            // lblvalor
            // 
            this.lblvalor.AutoSize = true;
            this.lblvalor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalor.Location = new System.Drawing.Point(240, 250);
            this.lblvalor.Name = "lblvalor";
            this.lblvalor.Size = new System.Drawing.Size(53, 20);
            this.lblvalor.TabIndex = 14;
            this.lblvalor.Text = "label7";
            this.lblvalor.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(96, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "%";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTempo);
            this.groupBox1.Controls.Add(this.rdbMeses);
            this.groupBox1.Controls.Add(this.rdbAnos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 69);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tempo de investimento";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.rsbTxano);
            this.groupBox2.Controls.Add(this.rdbTxmes);
            this.groupBox2.Controls.Add(this.txtRendimento);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(197, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(148, 69);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Rendimento";
            // 
            // rsbTxano
            // 
            this.rsbTxano.AutoSize = true;
            this.rsbTxano.Location = new System.Drawing.Point(85, 42);
            this.rsbTxano.Name = "rsbTxano";
            this.rsbTxano.Size = new System.Drawing.Size(63, 19);
            this.rsbTxano.TabIndex = 17;
            this.rsbTxano.TabStop = true;
            this.rsbTxano.Text = "Ao ano";
            this.rsbTxano.UseVisualStyleBackColor = true;
            // 
            // rdbTxmes
            // 
            this.rdbTxmes.AutoSize = true;
            this.rdbTxmes.Location = new System.Drawing.Point(6, 42);
            this.rdbTxmes.Name = "rdbTxmes";
            this.rdbTxmes.Size = new System.Drawing.Size(66, 19);
            this.rdbTxmes.TabIndex = 16;
            this.rdbTxmes.TabStop = true;
            this.rdbTxmes.Text = "Ao mês";
            this.rdbTxmes.UseVisualStyleBackColor = true;
            // 
            // Simulador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(358, 302);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblvalor);
            this.Controls.Add(this.lblTextovalor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMensal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtInicial);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Simulador";
            this.Text = "Simulador de Investimentos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInicial;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtMensal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.RadioButton rdbMeses;
        private System.Windows.Forms.RadioButton rdbAnos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRendimento;
        private System.Windows.Forms.Label lblTextovalor;
        private System.Windows.Forms.Label lblvalor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rsbTxano;
        private System.Windows.Forms.RadioButton rdbTxmes;
    }
}

