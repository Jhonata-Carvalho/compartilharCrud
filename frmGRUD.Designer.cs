namespace CRUD
{
    partial class frmGRUD
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
            this.lblcliente = new System.Windows.Forms.Label();
            this.lblpedido = new System.Windows.Forms.Label();
            this.lblquanti = new System.Windows.Forms.Label();
            this.lblvalor = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.txtpedido = new System.Windows.Forms.TextBox();
            this.txtquantde = new System.Windows.Forms.TextBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.txtcliente_pesquisar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblcliente
            // 
            this.lblcliente.AutoSize = true;
            this.lblcliente.Location = new System.Drawing.Point(6, 132);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(39, 13);
            this.lblcliente.TabIndex = 0;
            this.lblcliente.Text = "Cliente";
            // 
            // lblpedido
            // 
            this.lblpedido.AutoSize = true;
            this.lblpedido.Location = new System.Drawing.Point(5, 171);
            this.lblpedido.Name = "lblpedido";
            this.lblpedido.Size = new System.Drawing.Size(40, 13);
            this.lblpedido.TabIndex = 1;
            this.lblpedido.Text = "Pedido";
            // 
            // lblquanti
            // 
            this.lblquanti.AutoSize = true;
            this.lblquanti.Location = new System.Drawing.Point(6, 210);
            this.lblquanti.Name = "lblquanti";
            this.lblquanti.Size = new System.Drawing.Size(62, 13);
            this.lblquanti.TabIndex = 2;
            this.lblquanti.Text = "Quantidade";
            // 
            // lblvalor
            // 
            this.lblvalor.AutoSize = true;
            this.lblvalor.Location = new System.Drawing.Point(98, 210);
            this.lblvalor.Name = "lblvalor";
            this.lblvalor.Size = new System.Drawing.Size(31, 13);
            this.lblvalor.TabIndex = 3;
            this.lblvalor.Text = "Valor";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(9, 249);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(31, 13);
            this.lbltotal.TabIndex = 4;
            this.lbltotal.Text = "Total";
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(9, 148);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(153, 20);
            this.txtcliente.TabIndex = 5;
            // 
            // txtpedido
            // 
            this.txtpedido.Location = new System.Drawing.Point(8, 187);
            this.txtpedido.Name = "txtpedido";
            this.txtpedido.Size = new System.Drawing.Size(153, 20);
            this.txtpedido.TabIndex = 6;
            // 
            // txtquantde
            // 
            this.txtquantde.Location = new System.Drawing.Point(9, 226);
            this.txtquantde.Name = "txtquantde";
            this.txtquantde.Size = new System.Drawing.Size(60, 20);
            this.txtquantde.TabIndex = 7;
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(101, 226);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(60, 20);
            this.txtvalor.TabIndex = 8;
            // 
            // txttotal
            // 
            this.txttotal.Enabled = false;
            this.txttotal.Location = new System.Drawing.Point(11, 265);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(57, 20);
            this.txttotal.TabIndex = 9;
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(9, 110);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(59, 20);
            this.txtid.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nº cadastro";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(168, 94);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(504, 191);
            this.dgv.TabIndex = 12;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(93, 302);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(75, 23);
            this.btnsalvar.TabIndex = 13;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(12, 302);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 14;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(174, 302);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 23);
            this.btnexcluir.TabIndex = 15;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Lista completa de cadastro";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnpesquisar);
            this.groupBox1.Controls.Add(this.txtcliente_pesquisar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 70);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.Location = new System.Drawing.Point(209, 14);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(68, 48);
            this.btnpesquisar.TabIndex = 18;
            this.btnpesquisar.Text = "Pesquisar";
            this.btnpesquisar.UseVisualStyleBackColor = true;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // txtcliente_pesquisar
            // 
            this.txtcliente_pesquisar.Location = new System.Drawing.Point(9, 32);
            this.txtcliente_pesquisar.Name = "txtcliente_pesquisar";
            this.txtcliente_pesquisar.Size = new System.Drawing.Size(153, 20);
            this.txtcliente_pesquisar.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cliente";
            // 
            // frmGRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 337);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.txtquantde);
            this.Controls.Add(this.txtpedido);
            this.Controls.Add(this.txtcliente);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lblvalor);
            this.Controls.Add(this.lblquanti);
            this.Controls.Add(this.lblpedido);
            this.Controls.Add(this.lblcliente);
            this.Name = "frmGRUD";
            this.Text = "GRUD";
            this.Load += new System.EventHandler(this.frmGRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcliente;
        private System.Windows.Forms.Label lblpedido;
        private System.Windows.Forms.Label lblquanti;
        private System.Windows.Forms.Label lblvalor;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.TextBox txtpedido;
        private System.Windows.Forms.TextBox txtquantde;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.TextBox txtcliente_pesquisar;
        private System.Windows.Forms.Label label3;
    }
}

