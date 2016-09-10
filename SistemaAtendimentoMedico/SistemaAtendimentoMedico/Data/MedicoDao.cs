using SistemaAtendimentoMedico.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAtendimentoMedico.Data
{
    public class MedicoDao : Dao<Medico>
    {
        public override void Delete(string ID)
        {
            try
            {
                OpenConnection();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "DELETE FROM Medico WHERE ID=@ID";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally { CloseConnection(); }
        }

        public override void Insert(Medico Medico)
        {
            try
            {
                OpenConnection();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO Medico " +
                    "(CPF,Nome,UF,Municipio,CEP,Logradouro,Numero,Complemento,Bairro," +
                    "Telefone,Celular,Email,DataNascimento,IDEspecialidade) " +
                    "VALUES (@CPF,@Nome,@UF,@Municipio,@CEP,@Logradouro,@Numero,@Complemento,@Bairro,"
                    + "@Telefone,@Celular,@Email,@DataNascimento,@IDEspecialidade)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@CPF", Medico.CPF);
                cmd.Parameters.AddWithValue("@Nome", Medico.Nome);
                cmd.Parameters.AddWithValue("@UF", Medico.UF);
                cmd.Parameters.AddWithValue("@Municipio", Medico.Municipio);
                cmd.Parameters.AddWithValue("@CEP", Medico.CEP);
                cmd.Parameters.AddWithValue("@Logradouro", Medico.Logradouro);
                cmd.Parameters.AddWithValue("@Numero", Medico.Numero);
                cmd.Parameters.AddWithValue("@Complemento", Medico.Complemento);
                cmd.Parameters.AddWithValue("@Bairro", Medico.Bairro);
                cmd.Parameters.AddWithValue("@Telefone", Medico.Telefone);
                cmd.Parameters.AddWithValue("@Celular", Medico.Celular);
                cmd.Parameters.AddWithValue("@Email", Medico.Email);
                cmd.Parameters.AddWithValue("@DataNascimento", Medico.DataNascimento.ToShortDateString());
                cmd.Parameters.AddWithValue("@IDEspecialidade", Medico.IDEspecialidade);
                cmd.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally { CloseConnection(); }
        }

        public override List<Medico> Select(List<Tuple<string, object, string>> whereParameters)
        {
            List<Medico> Medicos = new List<Medico>();
            List<string> lstParameters = new List<string>();

            try
            {
                OpenConnection();
                cmd.CommandText = "SELECT * FROM Medico";
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
                    Medico p = new Medico();
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
                    p.IDEspecialidade = Convert.ToInt32(reader["IDEspecialidade"]);
                    Medicos.Add(p);
                }
            }
            catch (Exception) { throw; }
            finally
            { CloseConnection(); }

            return Medicos;
        }

        public override void Update(Medico Medico)
        {
            try
            {
                OpenConnection();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "UPDATE Medico SET " +
                    "CPF=@CPF,Nome=@Nome,UF=@UF,Municipio=@Municipio,CEP=@CEP,Logradouro=@Logradouro,Numero=@Numero," +
                    "Complemento=@Complemento,Bairro=@Bairro,Telefone=@Telefone,Celular=@Celular,Email=@Email," +
                    "DataNascimento=@DataNascimento,IDEspecialidade=@IDEspecialidade WHERE ID=@ID";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@CPF", Medico.CPF);
                cmd.Parameters.AddWithValue("@Nome", Medico.Nome);
                cmd.Parameters.AddWithValue("@UF", Medico.UF);
                cmd.Parameters.AddWithValue("@Municipio", Medico.Municipio);
                cmd.Parameters.AddWithValue("@CEP", Medico.CEP);
                cmd.Parameters.AddWithValue("@Logradouro", Medico.Logradouro);
                cmd.Parameters.AddWithValue("@Numero", Medico.Numero);
                cmd.Parameters.AddWithValue("@Complemento", Medico.Complemento);
                cmd.Parameters.AddWithValue("@Bairro", Medico.Bairro);
                cmd.Parameters.AddWithValue("@Telefone", Medico.Telefone);
                cmd.Parameters.AddWithValue("@Celular", Medico.Celular);
                cmd.Parameters.AddWithValue("@Email", Medico.Email);
                cmd.Parameters.AddWithValue("@DataNascimento", Medico.DataNascimento.ToShortDateString());
                cmd.Parameters.AddWithValue("@IDEspecialidade", Medico.IDEspecialidade);
                cmd.Parameters.AddWithValue("@ID", Medico.ID);
                cmd.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally { CloseConnection(); }
        }
    }
}