using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class DALContato
    {
        private Conexao objConexao;
        
        public DALContato(Conexao conexao)
        {
            objConexao = conexao;

        }

        public void Incluir(Contato contato)
        {
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = objConexao.Connection;
            cmd.CommandText =   "INSERT INTO CONTATO(" +
                                "con_nome, con_email, con_fone, " +
                                "con_rua, con_bairro, con_cidade, " +
                                "con_estado, con_cep) " +
                                "VALUES (@nome, @email, @fone, " +
                                "@rua, @bairro, @cidade, " +
                                "@estado, @cep) " +
                                "RETURNING con_cod;";
            
            cmd.Parameters.AddWithValue("@nome", contato.Nome);
            cmd.Parameters.AddWithValue("@email", contato.Email);
            cmd.Parameters.AddWithValue("@fone", contato.Telefone);
            cmd.Parameters.AddWithValue("@rua", contato.Rua);
            cmd.Parameters.AddWithValue("@bairro", contato.Bairro);
            cmd.Parameters.AddWithValue("@cidade", contato.Cidade);
            cmd.Parameters.AddWithValue("@estado", contato.Estado);
            cmd.Parameters.AddWithValue("@cep", contato.Cep);

            objConexao.Conectar();

            contato.Codigo = Convert.ToInt32(cmd.ExecuteScalar());

            objConexao.Desconectar();
        }

        public void Alterar(Contato contato)
        {
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = objConexao.Connection;
            cmd.CommandText = "UPDATE CONTATO SET " +
                              "con_nome = @nome, con_email = @email, con_fone = @fone, " +
                              "con_rua = @rua, con_bairro = @bairro, con_cidade = @cidade, " +
                              "con_estado = @estado, con_cep = @cep " +
                              "WHERE con_cod = @codigo;";

            cmd.Parameters.AddWithValue("@codigo", contato.Codigo);
            cmd.Parameters.AddWithValue("@nome", contato.Nome);
            cmd.Parameters.AddWithValue("@email", contato.Email);
            cmd.Parameters.AddWithValue("@fone", contato.Telefone);
            cmd.Parameters.AddWithValue("@rua", contato.Rua);
            cmd.Parameters.AddWithValue("@bairro", contato.Bairro);
            cmd.Parameters.AddWithValue("@cidade", contato.Cidade);
            cmd.Parameters.AddWithValue("@estado", contato.Estado);
            cmd.Parameters.AddWithValue("@cep", contato.Cep);
            objConexao.Conectar();
            cmd.ExecuteNonQuery();
            objConexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = objConexao.Connection;
            
            cmd.CommandText = "DELETE FROM CONTATO WHERE con_cod = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            
            objConexao.Conectar();
            cmd.ExecuteNonQuery();
            objConexao.Desconectar();
        }

    }
}
