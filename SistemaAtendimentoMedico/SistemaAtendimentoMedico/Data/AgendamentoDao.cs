using SistemaAtendimentoMedico.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAtendimentoMedico.Data
{
    public class AgendamentoDao : Dao<Agendamento>
    {
        public override void Delete(string ID)
        {
            try
            {
                OpenConnection();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "DELETE FROM Agendamento WHERE ID=@ID";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally { CloseConnection(); }
        }

        public override void Insert(Agendamento Agendamento)
        {
            try
            {
                OpenConnection();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO Agendamento " +
                    "(CPF,Nome,UF,Municipio,CEP,Logradouro,Numero,Complemento,Bairro,Telefone,Celular,Email,DataNascimento) " +
                    "VALUES (@CPF,@Nome,@UF,@Municipio,@CEP,@Logradouro,@Numero,@Complemento,@Bairro,@Telefone,@Celular,@Email,@DataNascimento)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@CPF", Agendamento.CPF);
                cmd.Parameters.AddWithValue("@Nome", Agendamento.Nome);
                cmd.Parameters.AddWithValue("@UF", Agendamento.UF);
                cmd.Parameters.AddWithValue("@Municipio", Agendamento.Municipio);
                cmd.Parameters.AddWithValue("@CEP", Agendamento.CEP);
                cmd.Parameters.AddWithValue("@Logradouro", Agendamento.Logradouro);
                cmd.Parameters.AddWithValue("@Numero", Agendamento.Numero);
                cmd.Parameters.AddWithValue("@Complemento", Agendamento.Complemento);
                cmd.Parameters.AddWithValue("@Bairro", Agendamento.Bairro);
                cmd.Parameters.AddWithValue("@Telefone", Agendamento.Telefone);
                cmd.Parameters.AddWithValue("@Celular", Agendamento.Celular);
                cmd.Parameters.AddWithValue("@Email", Agendamento.Email);
                cmd.Parameters.AddWithValue("@DataNascimento", Agendamento.DataNascimento.ToShortDateString());
                cmd.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally { CloseConnection(); }
        }

        public override List<Agendamento> Select(List<Tuple<string, object, string>> whereParameters)
        {
            List<Agendamento> Agendamentos = new List<Agendamento>();
            List<string> lstParameters = new List<string>();

            try
            {
                OpenConnection();
                cmd.CommandText = "SELECT * FROM Agendamento";
                cmd.Parameters.Clear();

                if (whereParameters != null)
                    foreach (var item in whereParameters)
                    {
                        cmd.Parameters.AddWithValue("@" + item.Item1, item.Item2);
                        lstParameters.Add(item.Item1 + item.Item3 + "@" + item.Item1);
                    }

                if (lstParameters.Count > 0)
                    cmd.CommandText += " WHERE " + string.Join(" AND ", lstParameters.ToArray());

                cmd.CommandType = System.Data.CommandType.Text;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Agendamento p = new Agendamento();
                    p.ID = Convert.ToInt32(reader["ID"]);
                    p.CPF = reader["CPF"].ToString();
                    p.Nome = reader["Nome"].ToString();
                    p.UF = reader["UF"].ToString();
                    p.Municipio = reader["Municipio"].ToString();
                    p.CEP = reader["CEP"].ToString();
                    p.Logradouro = reader["Logradouro"].ToString();
                    p.Numero = Convert.ToInt32(reader["Numero"]);
                    p.Complemento = reader["Complemento"].ToString();
                    p.Bairro = reader["Bairro"].ToString();
                    p.Telefone = reader["Telefone"].ToString();
                    p.Celular = reader["Celular"].ToString();
                    p.Email = reader["Email"].ToString();
                    p.DataNascimento = Convert.ToDateTime(reader["DataNascimento"].ToString());
                    Agendamentos.Add(p);
                }
            }
            catch (Exception) { throw; }
            finally
            { CloseConnection(); }

            return Agendamentos;
        }

        public override void Update(Agendamento Agendamento)
        {
            try
            {
                OpenConnection();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "UPDATE Agendamento SET " +
                    "CPF=@CPF,Nome=@Nome,UF=@UF,Municipio=@Municipio,CEP=@CEP,Logradouro=@Logradouro,Numero=@Numero," +
                    "Complemento=@Complemento,Bairro=@Bairro,Telefone=@Telefone,Celular=@Celular,Email=@Email," +
                    "DataNascimento=@DataNascimento WHERE ID=@ID";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@CPF", Agendamento.CPF);
                cmd.Parameters.AddWithValue("@Nome", Agendamento.Nome);
                cmd.Parameters.AddWithValue("@UF", Agendamento.UF);
                cmd.Parameters.AddWithValue("@Municipio", Agendamento.Municipio);
                cmd.Parameters.AddWithValue("@CEP", Agendamento.CEP);
                cmd.Parameters.AddWithValue("@Logradouro", Agendamento.Logradouro);
                cmd.Parameters.AddWithValue("@Numero", Agendamento.Numero);
                cmd.Parameters.AddWithValue("@Complemento", Agendamento.Complemento);
                cmd.Parameters.AddWithValue("@Bairro", Agendamento.Bairro);
                cmd.Parameters.AddWithValue("@Telefone", Agendamento.Telefone);
                cmd.Parameters.AddWithValue("@Celular", Agendamento.Celular);
                cmd.Parameters.AddWithValue("@Email", Agendamento.Email);
                cmd.Parameters.AddWithValue("@DataNascimento", Agendamento.DataNascimento.ToShortDateString());
                cmd.Parameters.AddWithValue("@ID", Agendamento.ID);
                cmd.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally { CloseConnection(); }
        }
    }
}
