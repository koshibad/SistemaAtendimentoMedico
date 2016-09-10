using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAtendimentoMedico.Data
{
    public abstract class Dao<T> : IDao<T>
    {
        //private String url = @"Data Source=.\SQLEXPRESS;
        //                      AttachDbFilename=C:\Users\Diogo\Desktop\SistemaAtendimentoMedico\BancoDeDados\AtendimentoMedico.mdf;
        //                      Integrated Security=True;
        //                      Connect Timeout=30;
        //                      User Instance=True";

        private String url = @"Persist Security Info=True;
                               User ID=sa;
                               Password=0000;
                               Initial Catalog=AtendimentoMedico;
                               Data Source=.";

        protected SqlConnection cn;
        protected SqlCommand cmd;
        protected SqlDataReader reader;
        protected SqlDataAdapter da;

        public Dao()
        {
            cn = new SqlConnection();
            cmd = new SqlCommand();
            da = new SqlDataAdapter();
            cmd.Connection = cn;
        }

        protected void OpenConnection()
        {
            try
            {
                cn.ConnectionString = url;
                cn.Open();
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void CloseConnection()
        {
            if (cn.State == System.Data.ConnectionState.Open)
                cn.Close();
        }

        public abstract void Delete(string key);
        public abstract void Insert(T item);
        public abstract List<T> Select(List<Tuple<string, object, string>> whereParameters);
        public abstract void Update(T item);
    }
}
