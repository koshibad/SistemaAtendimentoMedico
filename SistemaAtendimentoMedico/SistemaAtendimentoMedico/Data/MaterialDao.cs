using SistemaAtendimentoMedico.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAtendimentoMedico.Data
{
    public class MaterialDao : Dao<Material>
    {
        public override void Delete(string ID)
        {
            try
            {
                try
                {
                    OpenConnection();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "DELETE FROM Material WHERE ID=@ID";
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

        public override void Insert(Material Material)
        {
            try
            {
                OpenConnection();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO Material " +
                    "(CPF,Nome,UF,Municipio,CEP,Logradouro,Numero,Complemento,Bairro,Telefone,Celular,Email,DataNascimento) " +
                    "VALUES (@CPF,@Nome,@UF,@Municipio,@CEP,@Logradouro,@Numero,@Complemento,@Bairro,@Telefone,@Celular,@Email,@DataNascimento)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@CPF", Material.CPF);
                cmd.Parameters.AddWithValue("@Nome", Material.Nome);
                cmd.Parameters.AddWithValue("@UF", Material.UF);
                cmd.Parameters.AddWithValue("@Municipio", Material.Municipio);
                cmd.Parameters.AddWithValue("@CEP", Material.CEP);
                cmd.Parameters.AddWithValue("@Logradouro", Material.Logradouro);
                cmd.Parameters.AddWithValue("@Numero", Material.Numero);
                cmd.Parameters.AddWithValue("@Complemento", Material.Complemento);
                cmd.Parameters.AddWithValue("@Bairro", Material.Bairro);
                cmd.Parameters.AddWithValue("@Telefone", Material.Telefone);
                cmd.Parameters.AddWithValue("@Celular", Material.Celular);
                cmd.Parameters.AddWithValue("@Email", Material.Email);
                cmd.Parameters.AddWithValue("@DataNascimento", Material.DataNascimento.ToShortDateString());
                cmd.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally { CloseConnection(); }
        }

        public override List<Material> Select(List<Tuple<string, object, string>> whereParameters)
        {
            List<Material> Materials = new List<Material>();
            List<string> lstParameters = new List<string>();

            try
            {
                OpenConnection();
                cmd.CommandText = "SELECT * FROM Material";
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
                    Material p = new Material();
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
                    Materials.Add(p);
                }
            }
            catch (Exception) { throw; }
            finally
            { CloseConnection(); }

            return Materials;
        }

        public override void Update(Material Material)
        {
            try
            {
                OpenConnection();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "UPDATE Material SET " +
                    "CPF=@CPF,Nome=@Nome,UF=@UF,Municipio=@Municipio,CEP=@CEP,Logradouro=@Logradouro,Numero=@Numero," +
                    "Complemento=@Complemento,Bairro=@Bairro,Telefone=@Telefone,Celular=@Celular,Email=@Email," +
                    "DataNascimento=@DataNascimento WHERE ID=@ID";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@CPF", Material.CPF);
                cmd.Parameters.AddWithValue("@Nome", Material.Nome);
                cmd.Parameters.AddWithValue("@UF", Material.UF);
                cmd.Parameters.AddWithValue("@Municipio", Material.Municipio);
                cmd.Parameters.AddWithValue("@CEP", Material.CEP);
                cmd.Parameters.AddWithValue("@Logradouro", Material.Logradouro);
                cmd.Parameters.AddWithValue("@Numero", Material.Numero);
                cmd.Parameters.AddWithValue("@Complemento", Material.Complemento);
                cmd.Parameters.AddWithValue("@Bairro", Material.Bairro);
                cmd.Parameters.AddWithValue("@Telefone", Material.Telefone);
                cmd.Parameters.AddWithValue("@Celular", Material.Celular);
                cmd.Parameters.AddWithValue("@Email", Material.Email);
                cmd.Parameters.AddWithValue("@DataNascimento", Material.DataNascimento.ToShortDateString());
                cmd.Parameters.AddWithValue("@ID", Material.ID);
                cmd.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally { CloseConnection(); }
        }
    }
}
