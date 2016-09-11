using SistemaAtendimentoMedico.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAtendimentoMedico.Data
{
    public class AgendamentoDao : Dao<Agendamento>
    {
        public override void Delete(string ID)
        {
            try
            {
                OpenConnection();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "DELETE FROM Agendamento WHERE ID=@ID";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally { CloseConnection(); }
        }

        public override void Insert(Agendamento Agendamento)
        {
            try
            {
                OpenConnection();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO Agendamento " +
                    "(IDPaciente,IDMedico,DataConsulta,IDTipoConsulta,IDConvenio) " +
                    "VALUES (@IDPaciente,@IDMedico,@DataConsulta,@IDTipoConsulta,@IDConvenio)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IDPaciente", Agendamento.IDPaciente);
                cmd.Parameters.AddWithValue("@IDMedico", Agendamento.IDMedico);
                cmd.Parameters.AddWithValue("@DataConsulta", Agendamento.DataConsulta);
                cmd.Parameters.AddWithValue("@IDTipoConsulta", Agendamento.IDTipoConsulta);
                cmd.Parameters.AddWithValue("@IDConvenio", Agendamento.IDConvenio);
                cmd.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally { CloseConnection(); }
        }

        public override List<Agendamento> Select(List<Tuple<string, object, string>> whereParameters)
        {
            List<Agendamento> Agendamentos = new List<Agendamento>();
            List<string> lstParameters = new List<string>();

            try
            {
                OpenConnection();
                cmd.CommandText = "SELECT * FROM Agendamento";
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
                    Agendamento p = new Agendamento();
                    p.ID = Convert.ToInt32(reader["ID"]);
                    p.IDPaciente = Convert.ToInt32(reader["IDPaciente"]);
                    p.IDMedico = Convert.ToInt32(reader["IDMedico"]);
                    p.DataConsulta = Convert.ToDateTime(reader["DataConsulta"].ToString());
                    p.IDTipoConsulta = Convert.ToInt32(reader["IDTipoConsulta"]);
                    p.IDConvenio = Convert.ToInt32(reader["IDConvenio"]);
                    Agendamentos.Add(p);
                }
            }
            catch (Exception) { throw; }
            finally
            { CloseConnection(); }

            return Agendamentos;
        }

        public override void Update(Agendamento Agendamento)
        {
            try
            {
                OpenConnection();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "UPDATE Agendamento SET " +
                    "IDPaciente=@IDPaciente,IDMedico=@IDMedico,DataConsulta=@DataConsulta," +
                    "IDConvenio=@IDConvenio WHERE ID=@ID";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IDPaciente", Agendamento.IDPaciente);
                cmd.Parameters.AddWithValue("@IDMedico", Agendamento.IDMedico);
                cmd.Parameters.AddWithValue("@DataConsulta", Agendamento.DataConsulta);
                cmd.Parameters.AddWithValue("@IDTipoConsulta", Agendamento.IDTipoConsulta);
                cmd.Parameters.AddWithValue("@IDConvenio", Agendamento.IDConvenio);
                cmd.Parameters.AddWithValue("@ID", Agendamento.ID);
                cmd.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally { CloseConnection(); }
        }
    }
}
