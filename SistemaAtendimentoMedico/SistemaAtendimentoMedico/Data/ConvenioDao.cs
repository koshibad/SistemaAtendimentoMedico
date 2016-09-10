using SistemaAtendimentoMedico.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAtendimentoMedico.Data
{
    public class ConvenioDao : Dao<Convenio>
    {
        public override void Delete(string ID)
        {
            try
            {
                try
                {
                    OpenConnection();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "DELETE FROM Convenio WHERE ID=@ID";
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

        public override void Insert(Convenio Convenio)
        {
            try
            {
                OpenConnection();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO Convenio " +
                    "(CPF,Nome,UF,Municipio,CEP,Logradouro,Numero,Complemento,Bairro,Telefone,Celular,Email,DataNascimento) " +
                    "VALUES (@CPF,@Nome,@UF,@Municipio,@CEP,@Logradouro,@Numero,@Complemento,@Bairro,@Telefone,@Celular,@Email,@DataNascimento)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@CPF", Convenio.CPF);
                cmd.Parameters.AddWithValue("@Nome", Convenio.Nome);
                cmd.Parameters.AddWithValue("@UF", Convenio.UF);
                cmd.Parameters.AddWithValue("@Municipio", Convenio.Municipio);
                cmd.Parameters.AddWithValue("@CEP", Convenio.CEP);
                cmd.Parameters.AddWithValue("@Logradouro", Convenio.Logradouro);
                cmd.Parameters.AddWithValue("@Numero", Convenio.Numero);
                cmd.Parameters.AddWithValue("@Complemento", Convenio.Complemento);
                cmd.Parameters.AddWithValue("@Bairro", Convenio.Bairro);
                cmd.Parameters.AddWithValue("@Telefone", Convenio.Telefone);
                cmd.Parameters.AddWithValue("@Celular", Convenio.Celular);
                cmd.Parameters.AddWithValue("@Email", Convenio.Email);
                cmd.Parameters.AddWithValue("@DataNascimento", Convenio.DataNascimento.ToShortDateString());
                cmd.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally { CloseConnection(); }
        }

        public override List<Convenio> Select(List<Tuple<string, object, string>> whereParameters)
        {
            List<Convenio> Convenios = new List<Convenio>();
            List<string> lstParameters = new List<string>();

            try
            {
                OpenConnection();
                cmd.CommandText = "SELECT * FROM Convenio";
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
                    Convenio p = new Convenio();
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
                    Convenios.Add(p);
                }
            }
            catch (Exception) { throw; }
            finally
            { CloseConnection(); }

            return Convenios;
        }

        public override void Update(Convenio Convenio)
        {
            try
            {
                OpenConnection();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "UPDATE Convenio SET " +
                    "CPF=@CPF,Nome=@Nome,UF=@UF,Municipio=@Municipio,CEP=@CEP,Logradouro=@Logradouro,Numero=@Numero," +
                    "Complemento=@Complemento,Bairro=@Bairro,Telefone=@Telefone,Celular=@Celular,Email=@Email," +
                    "DataNascimento=@DataNascimento WHERE ID=@ID";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@CPF", Convenio.CPF);
                cmd.Parameters.AddWithValue("@Nome", Convenio.Nome);
                cmd.Parameters.AddWithValue("@UF", Convenio.UF);
                cmd.Parameters.AddWithValue("@Municipio", Convenio.Municipio);
                cmd.Parameters.AddWithValue("@CEP", Convenio.CEP);
                cmd.Parameters.AddWithValue("@Logradouro", Convenio.Logradouro);
                cmd.Parameters.AddWithValue("@Numero", Convenio.Numero);
                cmd.Parameters.AddWithValue("@Complemento", Convenio.Complemento);
                cmd.Parameters.AddWithValue("@Bairro", Convenio.Bairro);
                cmd.Parameters.AddWithValue("@Telefone", Convenio.Telefone);
                cmd.Parameters.AddWithValue("@Celular", Convenio.Celular);
                cmd.Parameters.AddWithValue("@Email", Convenio.Email);
                cmd.Parameters.AddWithValue("@DataNascimento", Convenio.DataNascimento.ToShortDateString());
                cmd.Parameters.AddWithValue("@ID", Convenio.ID);
                cmd.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally { CloseConnection(); }
        }
    }
}
