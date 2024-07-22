namespace Cadastro
{
    partial class Main
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
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_endereco = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_cpf_consulta = new System.Windows.Forms.Label();
            this.lbl_bairro = new System.Windows.Forms.Label();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.tb_endereco = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_bairro = new System.Windows.Forms.TextBox();
            this.gb_sexo = new System.Windows.Forms.GroupBox();
            this.rb_feminino = new System.Windows.Forms.RadioButton();
            this.rb_masculino = new System.Windows.Forms.RadioButton();
            this.mtb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.mtb_cpf = new System.Windows.Forms.MaskedTextBox();
            this.mtb_consulta = new System.Windows.Forms.MaskedTextBox();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_codigo = new System.Windows.Forms.Label();
            this.gb_sexo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.Location = new System.Drawing.Point(39, 9);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(100, 23);
            this.lbl_codigo.TabIndex = 0;
            this.lbl_codigo.Text = "Código";
            // 
            // lbl_nome
            // 
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(39, 74);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(100, 23);
            this.lbl_nome.TabIndex = 1;
            this.lbl_nome.Text = "Nome";
            // 
            // lbl_endereco
            // 
            this.lbl_endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_endereco.Location = new System.Drawing.Point(39, 140);
            this.lbl_endereco.Name = "lbl_endereco";
            this.lbl_endereco.Size = new System.Drawing.Size(100, 23);
            this.lbl_endereco.TabIndex = 2;
            this.lbl_endereco.Text = "Endereço";
            // 
            // lbl_email
            // 
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(39, 217);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(100, 23);
            this.lbl_email.TabIndex = 3;
            this.lbl_email.Text = "E-mail";
            // 
            // lbl_cpf_consulta
            // 
            this.lbl_cpf_consulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpf_consulta.Location = new System.Drawing.Point(39, 300);
            this.lbl_cpf_consulta.Name = "lbl_cpf_consulta";
            this.lbl_cpf_consulta.Size = new System.Drawing.Size(100, 23);
            this.lbl_cpf_consulta.TabIndex = 4;
            this.lbl_cpf_consulta.Text = "CPF";
            // 
            // lbl_bairro
            // 
            this.lbl_bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bairro.Location = new System.Drawing.Point(368, 140);
            this.lbl_bairro.Name = "lbl_bairro";
            this.lbl_bairro.Size = new System.Drawing.Size(100, 23);
            this.lbl_bairro.TabIndex = 6;
            this.lbl_bairro.Text = "Bairro";
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefone.Location = new System.Drawing.Point(368, 217);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(100, 23);
            this.lbl_telefone.TabIndex = 7;
            this.lbl_telefone.Text = "Telefone";
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpf.Location = new System.Drawing.Point(552, 217);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(100, 23);
            this.lbl_cpf.TabIndex = 8;
            this.lbl_cpf.Text = "CPF";
            // 
            // tb_nome
            // 
            this.tb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nome.Location = new System.Drawing.Point(42, 100);
            this.tb_nome.Multiline = true;
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(293, 26);
            this.tb_nome.TabIndex = 9;
            // 
            // tb_endereco
            // 
            this.tb_endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_endereco.Location = new System.Drawing.Point(42, 168);
            this.tb_endereco.Multiline = true;
            this.tb_endereco.Name = "tb_endereco";
            this.tb_endereco.Size = new System.Drawing.Size(293, 26);
            this.tb_endereco.TabIndex = 10;
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.Location = new System.Drawing.Point(42, 245);
            this.tb_email.Multiline = true;
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(293, 26);
            this.tb_email.TabIndex = 11;
            // 
            // tb_bairro
            // 
            this.tb_bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_bairro.Location = new System.Drawing.Point(371, 168);
            this.tb_bairro.Multiline = true;
            this.tb_bairro.Name = "tb_bairro";
            this.tb_bairro.Size = new System.Drawing.Size(321, 26);
            this.tb_bairro.TabIndex = 12;
            // 
            // gb_sexo
            // 
            this.gb_sexo.Controls.Add(this.rb_feminino);
            this.gb_sexo.Controls.Add(this.rb_masculino);
            this.gb_sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_sexo.Location = new System.Drawing.Point(371, 74);
            this.gb_sexo.Name = "gb_sexo";
            this.gb_sexo.Size = new System.Drawing.Size(299, 52);
            this.gb_sexo.TabIndex = 13;
            this.gb_sexo.TabStop = false;
            this.gb_sexo.Text = "Sexo";
            // 
            // rb_feminino
            // 
            this.rb_feminino.AutoSize = true;
            this.rb_feminino.Location = new System.Drawing.Point(149, 23);
            this.rb_feminino.Name = "rb_feminino";
            this.rb_feminino.Size = new System.Drawing.Size(87, 22);
            this.rb_feminino.TabIndex = 1;
            this.rb_feminino.TabStop = true;
            this.rb_feminino.Text = "Feminino";
            this.rb_feminino.UseVisualStyleBackColor = true;
            // 
            // rb_masculino
            // 
            this.rb_masculino.AutoSize = true;
            this.rb_masculino.Location = new System.Drawing.Point(28, 23);
            this.rb_masculino.Name = "rb_masculino";
            this.rb_masculino.Size = new System.Drawing.Size(94, 22);
            this.rb_masculino.TabIndex = 0;
            this.rb_masculino.TabStop = true;
            this.rb_masculino.Text = "Masculino";
            this.rb_masculino.UseVisualStyleBackColor = true;
            // 
            // mtb_telefone
            // 
            this.mtb_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_telefone.Location = new System.Drawing.Point(371, 245);
            this.mtb_telefone.Mask = "(99) 00000-0000";
            this.mtb_telefone.Name = "mtb_telefone";
            this.mtb_telefone.Size = new System.Drawing.Size(137, 24);
            this.mtb_telefone.TabIndex = 14;
            this.mtb_telefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mtb_cpf
            // 
            this.mtb_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_cpf.Location = new System.Drawing.Point(555, 245);
            this.mtb_cpf.Mask = "000.000.000-00";
            this.mtb_cpf.Name = "mtb_cpf";
            this.mtb_cpf.Size = new System.Drawing.Size(137, 24);
            this.mtb_cpf.TabIndex = 15;
            this.mtb_cpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mtb_consulta
            // 
            this.mtb_consulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_consulta.Location = new System.Drawing.Point(83, 297);
            this.mtb_consulta.Mask = "000.000.000-00";
            this.mtb_consulta.Name = "mtb_consulta";
            this.mtb_consulta.Size = new System.Drawing.Size(137, 24);
            this.mtb_consulta.TabIndex = 16;
            this.mtb_consulta.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pesquisar.Location = new System.Drawing.Point(226, 296);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(93, 27);
            this.btn_pesquisar.TabIndex = 18;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(3, 3);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(100, 33);
            this.btn_novo.TabIndex = 0;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_inserir
            // 
            this.btn_inserir.Location = new System.Drawing.Point(111, 3);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(100, 33);
            this.btn_inserir.TabIndex = 1;
            this.btn_inserir.Text = "Inserir";
            this.btn_inserir.UseVisualStyleBackColor = true;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(219, 3);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(100, 33);
            this.btn_alterar.TabIndex = 2;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(327, 3);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(100, 33);
            this.btn_excluir.TabIndex = 3;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(435, 3);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(100, 33);
            this.btn_limpar.TabIndex = 4;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(543, 3);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(100, 33);
            this.btn_sair.TabIndex = 5;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Controls.Add(this.btn_sair, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_limpar, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_excluir, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_alterar, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_inserir, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_novo, 0, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(70, 337);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(650, 39);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // tb_codigo
            // 
            this.tb_codigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tb_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_codigo.Location = new System.Drawing.Point(42, 32);
            this.tb_codigo.Name = "tb_codigo";
            this.tb_codigo.Size = new System.Drawing.Size(47, 23);
            this.tb_codigo.TabIndex = 20;
            this.tb_codigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 388);
            this.Controls.Add(this.tb_codigo);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.mtb_consulta);
            this.Controls.Add(this.mtb_cpf);
            this.Controls.Add(this.mtb_telefone);
            this.Controls.Add(this.gb_sexo);
            this.Controls.Add(this.tb_bairro);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_endereco);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.lbl_cpf);
            this.Controls.Add(this.lbl_telefone);
            this.Controls.Add(this.lbl_bairro);
            this.Controls.Add(this.lbl_cpf_consulta);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_endereco);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_codigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Alunos";
            this.Load += new System.EventHandler(this.Main_Load);
            this.gb_sexo.ResumeLayout(false);
            this.gb_sexo.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_endereco;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_cpf_consulta;
        private System.Windows.Forms.Label lbl_bairro;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.TextBox tb_endereco;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_bairro;
        private System.Windows.Forms.GroupBox gb_sexo;
        private System.Windows.Forms.RadioButton rb_feminino;
        private System.Windows.Forms.RadioButton rb_masculino;
        private System.Windows.Forms.MaskedTextBox mtb_telefone;
        private System.Windows.Forms.MaskedTextBox mtb_cpf;
        private System.Windows.Forms.MaskedTextBox mtb_consulta;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label tb_codigo;
    }
}

