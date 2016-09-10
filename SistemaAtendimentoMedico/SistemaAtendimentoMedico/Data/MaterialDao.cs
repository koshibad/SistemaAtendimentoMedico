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

        public override void Insert(Material Material)
        {
            try
            {
                OpenConnection();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO Material " +
                    "(Nome,IDCategoria,IDFinalidade,IDFabricante,ValorUnitario) " +
                    "VALUES (@Nome,@IDCategoria,@IDFinalidade,@IDFabricante,@ValorUnitario)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nome", Material.Nome);
                cmd.Parameters.AddWithValue("@IDCategoria", Material.IDCategoria);
                cmd.Parameters.AddWithValue("@IDFinalidade", Material.IDFinalidade);
                cmd.Parameters.AddWithValue("@IDFabricante", Material.IDFabricante);
                cmd.Parameters.AddWithValue("@ValorUnitario", Material.ValorUnitario);
                cmd.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally { CloseConnection(); }
        }

        public override List<Material> Select(List<Tuple<string, object, string>> whereParameters)
        {
            List<Material> Materiais = new List<Material>();
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
                    p.Nome = reader["Nome"].ToString();
                    p.IDCategoria = Convert.ToInt32(reader["IDCategoria"]);
                    p.IDFinalidade = Convert.ToInt32(reader["IDFinalidade"]);
                    p.IDFabricante = Convert.ToInt32(reader["IDFabricante"]);
                    p.ValorUnitario = Convert.ToDouble(reader["ValorUnitario"]);
                    Materiais.Add(p);
                }
            }
            catch (Exception) { throw; }
            finally
            { CloseConnection(); }

            return Materiais;
        }

        public override void Update(Material Material)
        {
            try
            {
                OpenConnection();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "UPDATE Material SET " +
                    "Nome=@Nome,IDCategoria=@IDCategoria,IDFinalidade=@IDFinalidade," +
                    "IDFabricante=@IDFabricante,ValorUnitario=@ValorUnitario WHERE ID=@ID";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nome", Material.Nome);
                cmd.Parameters.AddWithValue("@IDCategoria", Material.IDCategoria);
                cmd.Parameters.AddWithValue("@IDFinalidade", Material.IDFinalidade);
                cmd.Parameters.AddWithValue("@IDFabricante", Material.IDFabricante);
                cmd.Parameters.AddWithValue("@ValorUnitario", Material.ValorUnitario);
                cmd.Parameters.AddWithValue("@ID", Material.ID);
                cmd.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally { CloseConnection(); }
        }

        public List<Categoria> SelectCategoria(List<Tuple<string, object, string>> whereParameters)
        {
            List<Categoria> Categorias = new List<Categoria>();
            List<string> lstParameters = new List<string>();

            try
            {
                OpenConnection();
                cmd.CommandText = "SELECT * FROM Categoria";
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
                    Categoria p = new Categoria();
                    p.ID = Convert.ToInt32(reader["ID"]);
                    p.Nome = reader["Nome"].ToString();
                    Categorias.Add(p);
                }
            }
            catch (Exception) { throw; }
            finally
            { CloseConnection(); }

            return Categorias;
        }

        public List<Finalidade> SelectFinalidade(List<Tuple<string, object, string>> whereParameters)
        {
            List<Finalidade> Finalidades = new List<Finalidade>();
            List<string> lstParameters = new List<string>();

            try
            {
                OpenConnection();
                cmd.CommandText = "SELECT * FROM Finalidade";
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
                    Finalidade p = new Finalidade();
                    p.ID = Convert.ToInt32(reader["ID"]);
                    p.Nome = reader["Nome"].ToString();
                    p.IDCategoria = Convert.ToInt32(reader["IDCategoria"]);
                    Finalidades.Add(p);
                }
            }
            catch (Exception) { throw; }
            finally
            { CloseConnection(); }

            return Finalidades;
        }

        public List<Fabricante> SelectFabricante(List<Tuple<string, object, string>> whereParameters)
        {
            List<Fabricante> Fabricantes = new List<Fabricante>();
            List<string> lstParameters = new List<string>();

            try
            {
                OpenConnection();
                cmd.CommandText = "SELECT * FROM Fabricante";
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
                    Fabricante p = new Fabricante();
                    p.ID = Convert.ToInt32(reader["ID"]);
                    p.Nome = reader["Nome"].ToString();
                    Fabricantes.Add(p);
                }
            }
            catch (Exception) { throw; }
            finally
            { CloseConnection(); }

            return Fabricantes;
        }
    }
}
