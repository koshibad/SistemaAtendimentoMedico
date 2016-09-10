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

        public override void Insert(Convenio Convenio)
        {
            try
            {
                OpenConnection();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO Convenio " +
                    "(CNPJ,RegistroANS,UF,RazaoSocial,NomeFantasia,Telefone,Email) " +
                    "VALUES (@CNPJ,@RegistroANS,@UF,@RazaoSocial,@NomeFantasia,@Telefone,@Email)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@CNPJ", Convenio.CNPJ);
                cmd.Parameters.AddWithValue("@RegistroANS", Convenio.RegistroANS);
                cmd.Parameters.AddWithValue("@UF", Convenio.UF);
                cmd.Parameters.AddWithValue("@RazaoSocial", Convenio.RazaoSocial);
                cmd.Parameters.AddWithValue("@NomeFantasia", Convenio.NomeFantasia);
                cmd.Parameters.AddWithValue("@Telefone", Convenio.Telefone);
                cmd.Parameters.AddWithValue("@Email", Convenio.Email);
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
                    p.CNPJ = reader["CNPJ"].ToString();
                    p.RegistroANS = Convert.ToInt32(reader["RegistroANS"]);
                    p.UF = reader["UF"].ToString();
                    p.NomeFantasia = reader["NomeFantasia"].ToString();
                    p.RazaoSocial = reader["RazaoSocial"].ToString();
                    p.Telefone = reader["Telefone"].ToString();
                    p.Email = reader["Email"].ToString();
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
                    "CNPJ=@CNPJ,RegistroANS=@RegistroANS,UF=@UF,RazaoSocial=@RazaoSocial," +
                    "NomeFantasia=@NomeFantasia,Telefone=@Telefone,Email=@Email " +
                    "WHERE ID=@ID";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@CNPJ", Convenio.CNPJ);
                cmd.Parameters.AddWithValue("@RegistroANS", Convenio.RegistroANS);
                cmd.Parameters.AddWithValue("@UF", Convenio.UF);
                cmd.Parameters.AddWithValue("@RazaoSocial", Convenio.RazaoSocial);
                cmd.Parameters.AddWithValue("@NomeFantasia", Convenio.NomeFantasia);
                cmd.Parameters.AddWithValue("@Telefone", Convenio.Telefone);
                cmd.Parameters.AddWithValue("@Email", Convenio.Email);
                cmd.Parameters.AddWithValue("@ID", Convenio.ID);
                cmd.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally { CloseConnection(); }
        }
    }
}
