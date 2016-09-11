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

        public override void Insert(Atendimento Atendimento)
        {
            try
            {
                OpenConnection();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO Atendimento " +
                    "(IDAgendamento,Tratamento,DataFinalizacaoAtendimento) " +
                    "VALUES (@IDAgendamento,@Tratamento,@DataFinalizacaoAtendimento)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IDAgendamento", Atendimento.IDAgendamento);
                cmd.Parameters.AddWithValue("@Tratamento", Atendimento.Tratamento);
                cmd.Parameters.AddWithValue("@DataFinalizacaoAtendimento", DBNull.Value);
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
                    p.IDAgendamento = Convert.ToInt32(reader["IDAgendamento"]);
                    p.Tratamento = reader["Tratamento"].ToString();
                    if (reader["DataFinalizacaoAtendimento"] == DBNull.Value)
                        p.DataFinalizacaoAtendimento = null;
                    else
                        p.DataFinalizacaoAtendimento = Convert.ToDateTime(
                            reader["DataFinalizacaoAtendimento"].ToString());
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
                    "IDAgendamento=@IDAgendamento,Tratamento=@Tratamento," +
                    "DataFinalizacaoAtendimento=@DataFinalizacaoAtendimento " +
                    "WHERE ID=@ID";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IDAgendamento", Atendimento.IDAgendamento);
                cmd.Parameters.AddWithValue("@Tratamento", Atendimento.Tratamento);
                cmd.Parameters.AddWithValue("@DataFinalizacaoAtendimento",
                    Atendimento.DataFinalizacaoAtendimento);
                cmd.Parameters.AddWithValue("@ID", Atendimento.ID);
                cmd.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally { CloseConnection(); }
        }
    }
}
