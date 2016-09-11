using SistemaAtendimentoMedico.View;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAtendimentoMedico
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            readTxtConnectionString();
            Application.Run(new FrmPrincipal());
        }

        private static void readTxtConnectionString()
        {
            string sql = "";
            using (StreamReader reader = new StreamReader(Path.GetFullPath("BancoDeDados\\ConnectionString.txt")))
            {
                while (reader.Peek() >= 0)
                    sql += reader.ReadLine();
            }

            if (String.IsNullOrEmpty(sql))
                Utils.Util.sqlConnection = @"Persist Security Info=True;
                                         User ID = sa;
                                         Initial Catalog = AtendimentoMedico;
                                         Data Source =.";

            Utils.Util.sqlConnection = sql;
        }
    }
}
