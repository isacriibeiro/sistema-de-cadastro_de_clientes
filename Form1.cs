using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cadastro
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        SqlConnection conexao = new SqlConnection(@"Data Source= SB-0054;integrated security=SSPI;initial Catalog=SISTEMA");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dt;

        


        private void DesabilitaCampos()
        {
            btn_novo.Select();
            tb_codigo.Enabled = false;
            tb_nome.Enabled = false;
            tb_endereco.Enabled = false;
            tb_email.Enabled = false;
            rb_masculino.Enabled = false;
            rb_feminino.Enabled = false;
            tb_bairro.Enabled = false;
            mtb_telefone.Enabled = false;
            mtb_cpf.Enabled = false;

            btn_inserir.Enabled = false;
            btn_alterar.Enabled = false;
            btn_excluir.Enabled = false;
            btn_limpar.Enabled = false;
            
        }
        private void HabilitaCampos()
        {
            tb_codigo.Enabled = true;
            tb_nome.Enabled =  true;
            tb_endereco.Enabled = true;
            tb_email.Enabled = true;
            rb_masculino.Enabled = true;
            rb_feminino.Enabled = true;
            tb_bairro.Enabled = true;
            mtb_telefone.Enabled = true;
            mtb_cpf.Enabled = true;

            btn_inserir.Enabled = true;
            btn_alterar.Enabled = true;
            btn_excluir.Enabled = true;
            btn_limpar.Enabled = true;

        }

        private void VisualizarCampos()
        {
            
            tb_nome.ReadOnly = true;
            tb_endereco.ReadOnly = true;
            tb_email.ReadOnly = true;
            rb_masculino.Visible = true;
            rb_feminino.Visible = true;
            tb_bairro.Enabled = true;
            mtb_telefone.ReadOnly = true;
            mtb_cpf.ReadOnly = true;
        }

        public void LimparCampos()
        {
            tb_codigo.Text = "";
            tb_nome.Text = "";
            tb_endereco.Text = "";
            tb_email.Text = "";
            rb_masculino.Checked = false;
            rb_feminino.Checked = false;
            tb_bairro.Text = "";
            mtb_telefone.Text = "";
            mtb_cpf.Text = "";
            mtb_consulta.Text = "";
        }

        private void Main_Load(object sender, EventArgs e)
        {
            DesabilitaCampos(); //Método para desabilitar campos
         //   conexao.Open();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            HabilitaCampos();
            btn_novo.Enabled = false;
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {

            if (mtb_telefone.Text.Length != 11)
            {
                MessageBox.Show("O numero de telefone deve conter 11 dígitos, incluindo o DDD \n Formato - (xx)xxxxx-xxxx", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }

            else if (mtb_cpf.Text.Length != 11)
            {
                MessageBox.Show("O numero do CPF deve conter 11 dígitos \n Formato - xxx.xxx.xxx-xx", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (tb_nome.Text == "" || tb_endereco.Text == "" || tb_bairro.Text == "")
            {
                if(tb_nome.Text == "")
                {
                    tb_nome.Focus();
                }

                if (tb_endereco.Text == "")
                {
                    tb_endereco.Focus();
                }

                if(tb_bairro.Text == "")
                {
                    tb_bairro.Focus();
                }

                MessageBox.Show("Todos os campos devem ser preenchidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

          //  else if (!rb_masculino.Checked || !rb_feminino.Checked) 
        //    {
         //       MessageBox.Show("Marque a opção do item (Sexo) ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }


            else
            {
                string sexo;
                if (rb_masculino.Checked)
                {
                    sexo = "Masculino";
                }
                else
                {
                    sexo = "Feminino";
                }



                try
                {
                    conexao.Open();
                    string comando = "SELECT CPF FROM TBL_CLIENTE WHERE CPF = " + mtb_cpf.Text;
                    cm.Connection = conexao;
                    cm.CommandText = comando;
                    dt = cm.ExecuteReader();
                    
                    if (dt.HasRows)
                    {
                        MessageBox.Show("CPF EXISTENTE!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        mtb_cpf.Text = "";
                        mtb_cpf.Select();
                        conexao.Close();
                    }

                    else
                    {
                        if (!dt.IsClosed) { dt.Close(); }
                        comando = "INSERT INTO TBL_CLIENTE" +
                                        "(NOME,SEXO,ENDERECO,BAIRRO,EMAIL,TELEFONE,CPF) " +
                                        "VALUES" +
                                        "(@NOME,@SEXO,@ENDERECO,@BAIRRO,@EMAIL,@TELEFONE,@CPF)";

                        cm.Parameters.Add("@NOME", SqlDbType.VarChar).Value = tb_nome.Text;
                        cm.Parameters.Add("@SEXO", SqlDbType.VarChar).Value = sexo;
                        cm.Parameters.Add("@ENDERECO", SqlDbType.VarChar).Value = tb_endereco.Text;
                        cm.Parameters.Add("@BAIRRO", SqlDbType.VarChar).Value = tb_bairro.Text;
                        cm.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = tb_email.Text;
                        cm.Parameters.Add("@TELEFONE", SqlDbType.Char).Value = mtb_telefone.Text;
                        cm.Parameters.Add("@CPF", SqlDbType.Char).Value = mtb_cpf.Text;
                        cm.Connection = conexao;
                        cm.CommandText = comando;

                        cm.ExecuteNonQuery();

                        MessageBox.Show("DADOS CADASTRADOS!", "Cliente Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimparCampos();
                        DesabilitaCampos();
                        cm.Parameters.Clear();
                        btn_novo.Enabled = true;
                        conexao.Close();

                    }

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    conexao.Close();
                }
            }
            
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            conexao.Open();
            var resposta = DialogResult; 
             resposta = MessageBox.Show("Tem certeza que deseja excluir este cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(resposta == DialogResult.Yes)
            {
                try
                {
                    string comando = "DELETE FROM TBL_CLIENTE WHERE COD_CLIENTE =" + tb_codigo.Text;
                    cm.Connection = conexao;
                    cm.CommandText = comando;
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Cliente excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                    conexao.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    conexao.Close();
                }
            }

            conexao.Close();
            

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            DesabilitaCampos(); 
            btn_novo.Enabled = true;
            mtb_consulta.Select();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                string comando = "SELECT * FROM TBL_CLIENTE WHERE CPF =" + mtb_consulta.Text;
                cm.Connection = conexao;
                cm.CommandText = comando;
                dt = cm.ExecuteReader(); //aqui fica as linhas do bd
                if (!dt.HasRows)
                {
                    MessageBox.Show("NÃO EXISTE USUÁRIO COM ESTE CPF", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mtb_consulta.Text = "";
                    conexao.Close();
                    
                }

                else
                {
                    dt.Read(); //pega a linha inteira e deixa no modo editavel para que eu possa desmembrar
                    tb_codigo.Text = dt["COD_CLIENTE"].ToString();
                    tb_nome.Text = dt["NOME"].ToString();
                    string sexo = dt["SEXO"].ToString();
                    if (sexo == "Masculino")
                    {
                        rb_masculino.Checked = true;
                    }
                    else
                    {
                        rb_feminino.Checked = true;
                    }
                    tb_endereco.Text = dt["ENDERECO"].ToString();
                    tb_bairro.Text = dt["BAIRRO"].ToString();
                    tb_email.Text = dt["EMAIL"].ToString();
                    mtb_telefone.Text = dt["TELEFONE"].ToString();
                    mtb_cpf.Text = dt["CPF"].ToString();

                   // VisualizarCampos();
                   
                    HabilitaCampos();
                    

                    if (!dt.IsClosed) { dt.Close(); }

                    conexao.Close();

                }
            }

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                conexao.Close();
            }
        }
        }
    }
