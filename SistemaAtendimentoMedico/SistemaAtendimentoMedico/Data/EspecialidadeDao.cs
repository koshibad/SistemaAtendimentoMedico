using SistemaAtendimentoMedico.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAtendimentoMedico.Data
{
    public class EspecialidadeDao : Dao<Especialidade>
    {
        public override void Delete(string ID)
        {
            try
            {
                try
                {
                    OpenConnection();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "DELETE FROM Especialidade WHERE ID=@ID";
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

        public override void Insert(Especialidade Especialidade)
        {
            try
            {
                OpenConnection();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO Especialidade " +
                    "(CPF,Nome,UF,Municipio,CEP,Logradouro,Numero,Complemento,Bairro,Telefone,Celular,Email,DataNascimento) " +
                    "VALUES (@CPF,@Nome,@UF,@Municipio,@CEP,@Logradouro,@Numero,@Complemento,@Bairro,@Telefone,@Celular,@Email,@DataNascimento)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@CPF", Especialidade.CPF);
                cmd.Parameters.AddWithValue("@Nome", Especialidade.Nome);
                cmd.Parameters.AddWithValue("@UF", Especialidade.UF);
                cmd.Parameters.AddWithValue("@Municipio", Especialidade.Municipio);
                cmd.Parameters.AddWithValue("@CEP", Especialidade.CEP);
                cmd.Parameters.AddWithValue("@Logradouro", Especialidade.Logradouro);
                cmd.Parameters.AddWithValue("@Numero", Especialidade.Numero);
                cmd.Parameters.AddWithValue("@Complemento", Especialidade.Complemento);
                cmd.Parameters.AddWithValue("@Bairro", Especialidade.Bairro);
                cmd.Parameters.AddWithValue("@Telefone", Especialidade.Telefone);
                cmd.Parameters.AddWithValue("@Celular", Especialidade.Celular);
                cmd.Parameters.AddWithValue("@Email", Especialidade.Email);
                cmd.Parameters.AddWithValue("@DataNascimento", Especialidade.DataNascimento.ToShortDateString());
                cmd.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally { CloseConnection(); }
        }

        public override List<Especialidade> Select(List<Tuple<string, object, string>> whereParameters)
        {
            List<Especialidade> Especialidades = new List<Especialidade>();
            List<string> lstParameters = new List<string>();

            try
            {
                OpenConnection();
                cmd.CommandText = "SELECT * FROM Especialidade";
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
                    Especialidade p = new Especialidade();
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
                    Especialidades.Add(p);
                }
            }
            catch (Exception) { throw; }
            finally
            { CloseConnection(); }

            return Especialidades;
        }

        public override void Update(Especialidade Especialidade)
        {
            try
            {
                OpenConnection();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "UPDATE Especialidade SET " +
                    "CPF=@CPF,Nome=@Nome,UF=@UF,Municipio=@Municipio,CEP=@CEP,Logradouro=@Logradouro,Numero=@Numero," +
                    "Complemento=@Complemento,Bairro=@Bairro,Telefone=@Telefone,Celular=@Celular,Email=@Email," +
                    "DataNascimento=@DataNascimento WHERE ID=@ID";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@CPF", Especialidade.CPF);
                cmd.Parameters.AddWithValue("@Nome", Especialidade.Nome);
                cmd.Parameters.AddWithValue("@UF", Especialidade.UF);
                cmd.Parameters.AddWithValue("@Municipio", Especialidade.Municipio);
                cmd.Parameters.AddWithValue("@CEP", Especialidade.CEP);
                cmd.Parameters.AddWithValue("@Logradouro", Especialidade.Logradouro);
                cmd.Parameters.AddWithValue("@Numero", Especialidade.Numero);
                cmd.Parameters.AddWithValue("@Complemento", Especialidade.Complemento);
                cmd.Parameters.AddWithValue("@Bairro", Especialidade.Bairro);
                cmd.Parameters.AddWithValue("@Telefone", Especialidade.Telefone);
                cmd.Parameters.AddWithValue("@Celular", Especialidade.Celular);
                cmd.Parameters.AddWithValue("@Email", Especialidade.Email);
                cmd.Parameters.AddWithValue("@DataNascimento", Especialidade.DataNascimento.ToShortDateString());
                cmd.Parameters.AddWithValue("@ID", Especialidade.ID);
                cmd.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally { CloseConnection(); }
        }
    }
}
