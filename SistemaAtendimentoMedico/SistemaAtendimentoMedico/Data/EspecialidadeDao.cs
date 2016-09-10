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

        public override void Insert(Especialidade Especialidade)
        {
            try
            {
                OpenConnection();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO Especialidade " +
                    "(Nome,ValorConsulta,RemuneracaoConvenio,RemuneracaoParticular) " +
                    "VALUES (@Nome,@ValorConsulta,@RemuneracaoConvenio,@RemuneracaoParticular)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nome", Especialidade.Nome);
                cmd.Parameters.AddWithValue("@ValorConsulta", Especialidade.ValorConsulta);
                cmd.Parameters.AddWithValue("@RemuneracaoConvenio", Especialidade.RemuneracaoConvenio);
                cmd.Parameters.AddWithValue("@RemuneracaoParticular", Especialidade.RemuneracaoParticular);
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
                    p.Nome = reader["Nome"].ToString();
                    p.ValorConsulta = Convert.ToDouble(reader["ValorConsulta"]);
                    p.RemuneracaoConvenio = Convert.ToDouble(reader["RemuneracaoConvenio"]);
                    p.RemuneracaoParticular = Convert.ToDouble(reader["RemuneracaoParticular"]);
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
                    "Nome=@Nome,ValorConsulta=@ValorConsulta," +
                    "RemuneracaoConvenio=@RemuneracaoConvenio," +
                    "RemuneracaoParticular=@RemuneracaoParticular " +
                    "WHERE ID=@ID";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nome", Especialidade.Nome);
                cmd.Parameters.AddWithValue("@ValorConsulta", Especialidade.ValorConsulta);
                cmd.Parameters.AddWithValue("@RemuneracaoConvenio", Especialidade.RemuneracaoConvenio);
                cmd.Parameters.AddWithValue("@RemuneracaoParticular", Especialidade.RemuneracaoParticular);
                cmd.Parameters.AddWithValue("@ID", Especialidade.ID);
                cmd.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally { CloseConnection(); }
        }
    }
}
