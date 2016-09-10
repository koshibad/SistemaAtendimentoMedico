using SistemaAtendimentoMedico.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAtendimentoMedico.Data
{
    public class AtendimentoDao : Dao<Atendimento>
    {
        public override void Delete(string ID)
        {
            try
            {
                try
                {
                    OpenConnection();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "DELETE FROM Atendimento WHERE ID=@ID";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception) { throw; }
                finally { CloseConnection(); }
            }
            catch (Exception) { throw; }
            finally { CloseConnection(); }
        }

        public override void Insert(Atendimento Atendimento)
        {
            try
            {
                OpenConnection();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO Atendimento " +
                    "(CPF,Nome,UF,Municipio,CEP,Logradouro,Numero,Complemento,Bairro,Telefone,Celular,Email,DataNascimento) " +
                    "VALUES (@CPF,@Nome,@UF,@Municipio,@CEP,@Logradouro,@Numero,@Complemento,@Bairro,@Telefone,@Celular,@Email,@DataNascimento)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@CPF", Atendimento.CPF);
                cmd.Parameters.AddWithValue("@Nome", Atendimento.Nome);
                cmd.Parameters.AddWithValue("@UF", Atendimento.UF);
                cmd.Parameters.AddWithValue("@Municipio", Atendimento.Municipio);
                cmd.Parameters.AddWithValue("@CEP", Atendimento.CEP);
                cmd.Parameters.AddWithValue("@Logradouro", Atendimento.Logradouro);
                cmd.Parameters.AddWithValue("@Numero", Atendimento.Numero);
                cmd.Parameters.AddWithValue("@Complemento", Atendimento.Complemento);
                cmd.Parameters.AddWithValue("@Bairro", Atendimento.Bairro);
                cmd.Parameters.AddWithValue("@Telefone", Atendimento.Telefone);
                cmd.Parameters.AddWithValue("@Celular", Atendimento.Celular);
                cmd.Parameters.AddWithValue("@Email", Atendimento.Email);
                cmd.Parameters.AddWithValue("@DataNascimento", Atendimento.DataNascimento.ToShortDateString());
                cmd.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally { CloseConnection(); }
        }

        public override List<Atendimento> Select(List<Tuple<string, object, string>> whereParameters)
        {
            List<Atendimento> Atendimentos = new List<Atendimento>();
            List<string> lstParameters = new List<string>();

            try
            {
                OpenConnection();
                cmd.CommandText = "SELECT * FROM Atendimento";
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
                    Atendimento p = new Atendimento();
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
                    Atendimentos.Add(p);
                }
            }
            catch (Exception) { throw; }
            finally
            { CloseConnection(); }

            return Atendimentos;
        }

        public override void Update(Atendimento Atendimento)
        {
            try
            {
                OpenConnection();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "UPDATE Atendimento SET " +
                    "CPF=@CPF,Nome=@Nome,UF=@UF,Municipio=@Municipio,CEP=@CEP,Logradouro=@Logradouro,Numero=@Numero," +
                    "Complemento=@Complemento,Bairro=@Bairro,Telefone=@Telefone,Celular=@Celular,Email=@Email," +
                    "DataNascimento=@DataNascimento WHERE ID=@ID";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@CPF", Atendimento.CPF);
                cmd.Parameters.AddWithValue("@Nome", Atendimento.Nome);
                cmd.Parameters.AddWithValue("@UF", Atendimento.UF);
                cmd.Parameters.AddWithValue("@Municipio", Atendimento.Municipio);
                cmd.Parameters.AddWithValue("@CEP", Atendimento.CEP);
                cmd.Parameters.AddWithValue("@Logradouro", Atendimento.Logradouro);
                cmd.Parameters.AddWithValue("@Numero", Atendimento.Numero);
                cmd.Parameters.AddWithValue("@Complemento", Atendimento.Complemento);
                cmd.Parameters.AddWithValue("@Bairro", Atendimento.Bairro);
                cmd.Parameters.AddWithValue("@Telefone", Atendimento.Telefone);
                cmd.Parameters.AddWithValue("@Celular", Atendimento.Celular);
                cmd.Parameters.AddWithValue("@Email", Atendimento.Email);
                cmd.Parameters.AddWithValue("@DataNascimento", Atendimento.DataNascimento.ToShortDateString());
                cmd.Parameters.AddWithValue("@ID", Atendimento.ID);
                cmd.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally { CloseConnection(); }
        }
    }
}
