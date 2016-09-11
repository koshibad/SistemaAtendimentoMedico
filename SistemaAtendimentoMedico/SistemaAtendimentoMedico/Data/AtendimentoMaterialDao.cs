using SistemaAtendimentoMedico.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAtendimentoMedico.Data
{
    public class AtendimentoMaterialDao : Dao<AtendimentoMaterial>
    {
        public override void Delete(string ID)
        {
            try
            {
                OpenConnection();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "DELETE FROM AtendimentoMaterial WHERE ID=@ID";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally { CloseConnection(); }
        }

        public override void Insert(AtendimentoMaterial AtendimentoMaterial)
        {
            try
            {
                OpenConnection();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO AtendimentoMaterial " +
                    "(IDAtendimento,IDMaterial,Quantidade) " +
                    "VALUES (@IDAtendimento,@IDMaterial,@Quantidade)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IDAtendimento", AtendimentoMaterial.IDAtendimento);
                cmd.Parameters.AddWithValue("@IDMaterial", AtendimentoMaterial.IDMaterial);
                cmd.Parameters.AddWithValue("@Quantidade", AtendimentoMaterial.Quantidade);
                cmd.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally { CloseConnection(); }
        }

        public override List<AtendimentoMaterial> Select(List<Tuple<string, object, string>> whereParameters)
        {
            List<AtendimentoMaterial> AtendimentoMaterials = new List<AtendimentoMaterial>();
            List<string> lstParameters = new List<string>();

            try
            {
                OpenConnection();
                cmd.CommandText = "SELECT * FROM AtendimentoMaterial";
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
                    AtendimentoMaterial p = new AtendimentoMaterial();
                    p.ID = Convert.ToInt32(reader["ID"]);
                    p.IDAtendimento = Convert.ToInt32(reader["IDAtendimento"]);
                    p.IDMaterial = Convert.ToInt32(reader["IDMaterial"]);
                    p.Quantidade = Convert.ToDouble(reader["Quantidade"]);
                    p.Novo = AtendimentoMaterial.eNovo.nao;
                    AtendimentoMaterials.Add(p);
                }
            }
            catch (Exception) { throw; }
            finally
            { CloseConnection(); }

            return AtendimentoMaterials;
        }

        public override void Update(AtendimentoMaterial AtendimentoMaterial)
        {
            try
            {
                OpenConnection();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "UPDATE AtendimentoMaterial SET " +
                    "Quantidade=@Quantidade WHERE ID=@ID";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Quantidade", AtendimentoMaterial.Quantidade);
                cmd.Parameters.AddWithValue("@ID", AtendimentoMaterial.ID);
                cmd.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally { CloseConnection(); }
        }
    }
}
