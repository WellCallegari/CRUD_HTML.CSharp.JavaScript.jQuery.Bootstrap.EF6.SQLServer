using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeerStore
{
    public partial class Addcliente : Form
    {
        public Addcliente()
        {
            InitializeComponent();

            //focar
            btnnew.Focus();
        }

        SqlConnection sqlCon = null;
        private string strCon = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BeerStore;Data Source=KIESTRO";
        private string strSql = string.Empty;

        private void btnnew_Click(object sender, EventArgs e)           //Botao Novo
        {
            //.Visible = Enabled;
            btnback.Visible = Enabled;
            lblback.Visible = Enabled;
            btnsave.Visible = Enabled;
            lblsave.Visible = Enabled;
            gpcadastro.Visible = Enabled;

            //.Visible = false;
            btnsearch.Visible = false;
            lblsearch.Visible = false;
            txtsearch.Visible = false;
            lblseaex.Visible = false;
            btnnew.Visible = false;
            lblnew.Visible = false;

            //focar
            btnback.Focus();
        }

        private void btnsave_Click(object sender, EventArgs e)          //Botao Save
        {
            strSql = "insert into cadastro (Nome,Email,CPF,RG,Telefone,Celular,Rua,Complemento,Bairro,Cidade) values(@Nome,@Email,@CPF,@RG,@Telefone,@Celular,@Rua,@Complemento,@Bairro,@Cidade)";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

        comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtnome.Text;
        comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = txtemail.Text;
        comando.Parameters.Add("@CPF", SqlDbType.VarChar).Value = txtcpf.Text;
        comando.Parameters.Add("@RG", SqlDbType.VarChar).Value = txtrg.Text;
        comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = txttel.Text;
        comando.Parameters.Add("@Celular", SqlDbType.VarChar).Value = txtcel.Text;
        comando.Parameters.Add("@Rua", SqlDbType.VarChar).Value = txtrua.Text;
        comando.Parameters.Add("@Complemento", SqlDbType.VarChar).Value = txtobs.Text;
        comando.Parameters.Add("@Bairro", SqlDbType.VarChar).Value = txtbairro.Text;
        comando.Parameters.Add("@Cidade", SqlDbType.VarChar).Value = txtcidade.Text;

        try
        {
            sqlCon.Open();

            comando.ExecuteNonQuery();

            MessageBox.Show("Cadastro EFETUADO com sucesso!");
        }


        catch(Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

        finally
        {
            sqlCon.Close();
        }


        //.Visible = Enabled;
        btnnew.Visible = Enabled;
            lblnew.Visible = Enabled;
            btnsearch.Visible = Enabled;
            lblsearch.Visible = Enabled;

            //.Visible = false;
            btnback.Visible = false;
            lblback.Visible = false;
            btnsave.Visible = false;
            lblsave.Visible = false;
            gpcadastro.Visible = false;

            //focar
            btnnew.Focus();
        }

        private void btnedit_Click(object sender, EventArgs e)          //Botao Edit
        {
            strSql = "update cadastro set Nome=@nome, Email=@Email, CPF=@CPF, RG=@RG, Telefone=@Telefone, Celular=@Celular, Rua=@Rua, Complemento=@Complemento, Bairro=@Bairro, Cidade=@Cidade";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtnome.Text;
            comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = txtemail.Text;
            comando.Parameters.Add("@CPF", SqlDbType.VarChar).Value = txtcpf.Text;
            comando.Parameters.Add("@RG", SqlDbType.VarChar).Value = txtrg.Text;
            comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = txttel.Text;
            comando.Parameters.Add("@Celular", SqlDbType.VarChar).Value = txtcel.Text;
            comando.Parameters.Add("@Rua", SqlDbType.VarChar).Value = txtrua.Text;
            comando.Parameters.Add("@Complemento", SqlDbType.VarChar).Value = txtobs.Text;
            comando.Parameters.Add("@Bairro", SqlDbType.VarChar).Value = txtbairro.Text;
            comando.Parameters.Add("@Cidade", SqlDbType.VarChar).Value = txtcidade.Text;

            try
            {
                sqlCon.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("Cadastro EDITADO com sucesso!!");
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlCon.Close();
            }

            //.Visible = Enabled;
            lblseati.Visible = Enabled;

            //.Visible = false;
            btnedit.Visible = false;
            lbledit.Visible = false;
            btndelete.Visible = false;
            lbldelete.Visible = false;
            gpcadastro.Visible = false;

            //Limpar txt
            txtsearch.Clear();
            txtnome.Clear();
            txtemail.Clear();
            txtcpf.Clear();
            txtrg.Clear();
            txttel.Clear();
            txtcel.Clear();
            txtrua.Clear();
            txtobs.Clear();
            txtbairro.Clear();
            txtcidade.Clear();

            //focar
            txtsearch.Focus();
        }

        private void btnsearch_Click(object sender, EventArgs e)            //Botao Pesquisar
        {
            
              //.Visible = Enabled;
              btnback.Visible = Enabled;
              lblback.Visible = Enabled;
              lblseaex.Visible = Enabled;
              txtsearch.Visible = Enabled;
              lblseati.Visible = Enabled;
              btnbuscar.Visible = Enabled;
              lblbuscar.Visible = Enabled;

            //.Visible = false;
            btnnew.Visible = false;
              lblnew.Visible = false;
              btnsearch.Visible = false;
              lblsearch.Visible = false;

              //focar
              txtsearch.Focus();

              //Limpar txt
              txtsearch.Clear();
             
        }

        

        private void btndelete_Click(object sender, EventArgs e)            //Botao Delete
        {
            strSql = "delete from cadastro where Nome=@Nome";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtnome.Text;

            try
            {
                sqlCon.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("Cadastro EXCLUÍDO com sucesso!!");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlCon.Close();
            }


            //.Visible = Enabled;
            lblseati.Visible = Enabled;

            //.Visible = false;
            btndelete.Visible = false;
            lbldelete.Visible = false;
            btnedit.Visible = false;
            lbledit.Visible = false;
            gpcadastro.Visible = false;

            //Limpar txt
            txtsearch.Clear();
            txtnome.Clear();
            txtemail.Clear();
            txtcpf.Clear();
            txtrg.Clear();
            txttel.Clear();
            txtcel.Clear();
            txtrua.Clear();
            txtobs.Clear();
            txtbairro.Clear();
            txtcidade.Clear();

            //focar
            txtsearch.Focus();
        }

        private void btnback_Click(object sender, EventArgs e)          //Botao Voltar
        {
            //.Visible = Enabled;
            btnnew.Visible = Enabled;
            lblnew.Visible = Enabled;
            btnsearch.Visible = Enabled;
            lblsearch.Visible = Enabled;

            //.Visible = false;
            btnsave.Visible = false;
            lblsave.Visible = false;
            btnedit.Visible = false;
            lbledit.Visible = false;
            btnback.Visible = false;
            lblback.Visible = false;
            btndelete.Visible = false;
            lbldelete.Visible = false;
            lblseaex.Visible = false;
            txtsearch.Visible = false;
            lblseati.Visible = false;
            btndelete.Visible = false;
            lbldelete.Visible = false;
            gpcadastro.Visible = false;
            btnbuscar.Visible = false;
            lblbuscar.Visible = false;

            //focar
            btnnew.Focus();

            //Limpar txt
            txtnome.Clear();
            txtemail.Clear();
            txtcpf.Clear();
            txtrg.Clear();
            txttel.Clear();
            txtcel.Clear();
            txtrua.Clear();
            txtobs.Clear();
            txtbairro.Clear();
            txtcidade.Clear();
            
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

            strSql = "select * from cadastro where Nome=@pesquisa";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@pesquisa", SqlDbType.VarChar).Value = txtsearch.Text;

            try
            {
                if (txtsearch.Text == string.Empty)
                {
                    MessageBox.Show("Digite um nome!");
                }

                sqlCon.Open();

                SqlDataReader dr = comando.ExecuteReader();

                if (dr.HasRows == false)
                {
                    throw new Exception("Nome não localizado... Tente outro nome!");
                }

                dr.Read();

                txtnome.Text = Convert.ToString(dr["Nome"]);
                txtemail.Text = Convert.ToString(dr["Email"]);
                txtcpf.Text = Convert.ToString(dr["CPF"]);
                txtrg.Text = Convert.ToString(dr["RG"]);
                txttel.Text = Convert.ToString(dr["Telefone"]);
                txtcel.Text = Convert.ToString(dr["Celular"]);
                txtrua.Text = Convert.ToString(dr["Rua"]);
                txtobs.Text = Convert.ToString(dr["Complemento"]);
                txtbairro.Text = Convert.ToString(dr["Bairro"]);
                txtcidade.Text = Convert.ToString(dr["Cidade"]);


                //.Visible = Enabled;
                btnedit.Visible = Enabled;
                lbledit.Visible = Enabled;
                btndelete.Visible = Enabled;
                lbldelete.Visible = Enabled;
                gpcadastro.Visible = Enabled;

                //.Visible = false;
                lblseati.Visible = false;

                //focar
                btnbuscar.Focus();


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlCon.Close();
            }






        }
    }
}


/* - Comentarios para suporte
            
            btnnew.Visible = Enabled;
            lblnew.Visible = Enabled;
            btnsearch.Visible = Enabled;
            lblsearch.Visible = Enabled;


                //Limpar txt
                txtsearch.Clear();

             //.Visible = Enabled;
          

            //.Visible = false;

    //desabilitarb campo
    nomedobanco.Enabled = false;

    /* - private void txtsearch_KeyPress(object sender, KeyPressEventArgs e) //ao apertar tecla ("enter") fazer...
        {
            if (e.KeyChar == 13) 
            {
                this.AcceptButton = btnbuscar;

                //.Visible = Enabled;
                btnedit.Visible = Enabled;
                lbledit.Visible = Enabled;
                btndelete.Visible = Enabled;
                lbldelete.Visible = Enabled;
                gpcadastro.Visible = Enabled;

                //.Visible = false;
                lblseati.Visible = false;

                //focar
                btnback.Focus();
            }
        } *** Evitar Conflito ***/
