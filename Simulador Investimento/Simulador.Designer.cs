
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
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtInicial
            // 
            resources.ApplyResources(this.txtInicial, "txtInicial");
            this.txtInicial.Name = "txtInicial";
            this.txtInicial.Enter += new System.EventHandler(this.txtInicial_Enter);
            this.txtInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInicial_KeyPress);
            this.txtInicial.Leave += new System.EventHandler(this.txtInicial_Leave);
            // 
            // btnCalc
            // 
            resources.ApplyResources(this.btnCalc, "btnCalc");
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtMensal
            // 
            resources.ApplyResources(this.txtMensal, "txtMensal");
            this.txtMensal.Name = "txtMensal";
            this.txtMensal.Enter += new System.EventHandler(this.txtMensal_Enter);
            this.txtMensal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMensal_KeyPress);
            this.txtMensal.Leave += new System.EventHandler(this.txtMensal_Leave);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtTempo
            // 
            resources.ApplyResources(this.txtTempo, "txtTempo");
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTempo_KeyPress);
            // 
            // rdbMeses
            // 
            resources.ApplyResources(this.rdbMeses, "rdbMeses");
            this.rdbMeses.Name = "rdbMeses";
            this.rdbMeses.TabStop = true;
            this.rdbMeses.UseVisualStyleBackColor = true;
            // 
            // rdbAnos
            // 
            resources.ApplyResources(this.rdbAnos, "rdbAnos");
            this.rdbAnos.Name = "rdbAnos";
            this.rdbAnos.TabStop = true;
            this.rdbAnos.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtRendimento
            // 
            resources.ApplyResources(this.txtRendimento, "txtRendimento");
            this.txtRendimento.Name = "txtRendimento";
            this.txtRendimento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRendimento_KeyPress);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.txtTempo);
            this.groupBox1.Controls.Add(this.rdbMeses);
            this.groupBox1.Controls.Add(this.rdbAnos);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.rsbTxano);
            this.groupBox2.Controls.Add(this.rdbTxmes);
            this.groupBox2.Controls.Add(this.txtRendimento);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // rsbTxano
            // 
            resources.ApplyResources(this.rsbTxano, "rsbTxano");
            this.rsbTxano.Name = "rsbTxano";
            this.rsbTxano.TabStop = true;
            this.rsbTxano.UseVisualStyleBackColor = true;
            // 
            // rdbTxmes
            // 
            resources.ApplyResources(this.rdbTxmes, "rdbTxmes");
            this.rdbTxmes.Name = "rdbTxmes";
            this.rdbTxmes.TabStop = true;
            this.rdbTxmes.UseVisualStyleBackColor = true;
            // 
            // Simulador
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMensal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtInicial);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Simulador";
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rsbTxano;
        private System.Windows.Forms.RadioButton rdbTxmes;
    }
}

