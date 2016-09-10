using SistemaAtendimentoMedico.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAtendimentoMedico.Data
{
    public class PacienteDao : Dao<Paciente>
    {
        public override void Delete(string ID)
        {
            try
            {
                try
                {
                    OpenConnection();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "DELETE FROM Paciente WHERE ID=@ID";
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

        public override void Insert(Paciente paciente)
        {
            try
            {
                OpenConnection();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO Paciente " +
                    "(CPF,Nome,UF,Municipio,CEP,Logradouro,Numero,Complemento,Bairro,Telefone,Celular,Email,DataNascimento) " +
                    "VALUES (@CPF,@Nome,@UF,@Municipio,@CEP,@Logradouro,@Numero,@Complemento,@Bairro,@Telefone,@Celular,@Email,@DataNascimento)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@CPF", paciente.CPF);
                cmd.Parameters.AddWithValue("@Nome", paciente.Nome);
                cmd.Parameters.AddWithValue("@UF", paciente.UF);
                cmd.Parameters.AddWithValue("@Municipio", paciente.Municipio);
                cmd.Parameters.AddWithValue("@CEP", paciente.CEP);
                cmd.Parameters.AddWithValue("@Logradouro", paciente.Logradouro);
                cmd.Parameters.AddWithValue("@Numero", paciente.Numero);
                cmd.Parameters.AddWithValue("@Complemento", paciente.Complemento);
                cmd.Parameters.AddWithValue("@Bairro", paciente.Bairro);
                cmd.Parameters.AddWithValue("@Telefone", paciente.Telefone);
                cmd.Parameters.AddWithValue("@Celular", paciente.Celular);
                cmd.Parameters.AddWithValue("@Email", paciente.Email);
                cmd.Parameters.AddWithValue("@DataNascimento", paciente.DataNascimento.ToShortDateString());
                cmd.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally { CloseConnection(); }
        }

        public override List<Paciente> Select(List<Tuple<string, object, string>> whereParameters)
        {
            List<Paciente> pacientes = new List<Paciente>();
            List<string> lstParameters = new List<string>();

            try
            {
                OpenConnection();
                cmd.CommandText = "SELECT * FROM Paciente";
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
                    Paciente p = new Paciente();
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
                    pacientes.Add(p);
                }
            }
            catch (Exception) { throw; }
            finally
            { CloseConnection(); }

            return pacientes;
        }

        public override void Update(Paciente paciente)
        {
            try
            {
                OpenConnection();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "UPDATE Paciente SET " +
                    "CPF=@CPF,Nome=@Nome,UF=@UF,Municipio=@Municipio,CEP=@CEP,Logradouro=@Logradouro,Numero=@Numero," +
                    "Complemento=@Complemento,Bairro=@Bairro,Telefone=@Telefone,Celular=@Celular,Email=@Email," +
                    "DataNascimento=@DataNascimento WHERE ID=@ID";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@CPF", paciente.CPF);
                cmd.Parameters.AddWithValue("@Nome", paciente.Nome);
                cmd.Parameters.AddWithValue("@UF", paciente.UF);
                cmd.Parameters.AddWithValue("@Municipio", paciente.Municipio);
                cmd.Parameters.AddWithValue("@CEP", paciente.CEP);
                cmd.Parameters.AddWithValue("@Logradouro", paciente.Logradouro);
                cmd.Parameters.AddWithValue("@Numero", paciente.Numero);
                cmd.Parameters.AddWithValue("@Complemento", paciente.Complemento);
                cmd.Parameters.AddWithValue("@Bairro", paciente.Bairro);
                cmd.Parameters.AddWithValue("@Telefone", paciente.Telefone);
                cmd.Parameters.AddWithValue("@Celular", paciente.Celular);
                cmd.Parameters.AddWithValue("@Email", paciente.Email);
                cmd.Parameters.AddWithValue("@DataNascimento", paciente.DataNascimento.ToShortDateString());
                cmd.Parameters.AddWithValue("@ID", paciente.ID);
                cmd.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally { CloseConnection(); }
        }
    }
}
