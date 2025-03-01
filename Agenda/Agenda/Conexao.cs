using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Conexao
    {
        private string _connectionString;
        private NpgsqlConnection _connection;

        public Conexao(string dadosConexao)
        {
            this._connection = new NpgsqlConnection();
            this._connectionString = dadosConexao;
            this._connection.ConnectionString = dadosConexao;
        }

        public String connectionString
        {
            get { return this.connectionString; }
            set { this._connectionString = value; }
        }

        public NpgsqlConnection Connection
        {
            get { return this._connection; }
            set { this._connection = value; }
        }

        public void Conectar()
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                    MessageBox.Show("Conexão aberta com sucesso.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir a conexão: {ex.Message}");
            }
        }

        public void Desconectar()
        {
            try
            {
                if (_connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                    MessageBox.Show("Conexão fechada com sucesso.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao fechar a conexão: {ex.Message}");
            }
        }

        public NpgsqlConnection GetConnection()
        {
            return _connection;
        }
    }
}
