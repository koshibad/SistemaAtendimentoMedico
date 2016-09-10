using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SistemaAtendimentoMedico.Utils
{
    public static class Validacao
    {
        public static string ValidarEmail(this string txt)
        {
            if (!Regex.IsMatch(txt,
                @"^[a-zA-Z0-9\._\-]+\@+[a-zA-Z0-9\._\-]+\.[a-zA-Z]+$"))
            {
                throw new Exception("Informe um email válido!");
            }
            return txt;
        }

        public static string ValidarTextoVazio(this string txt, string nomeCampo)
        {
            if (String.IsNullOrEmpty(txt.Trim()))
                throw new Exception("Informe um " + nomeCampo);

            return txt;
        }

        public static string ValidarNumeros(this string txt, int quantidadeNecessaria, string informacao, bool obrigatorio = true)
        {
            int count = 0;
            foreach (char i in txt.ToCharArray())
                if (char.IsNumber(i)) count++;

            if (obrigatorio)
            {
                if (count != quantidadeNecessaria)
                    throw new Exception("Informe um(a) " + informacao + " válido(a).");
            }
            else if (count != 0 && count != quantidadeNecessaria)
                throw new Exception("Informe um(a) " + informacao + " válido(a).");

            return txt;
        }

        public static int ValidarNumero(this string txt)
        {
            try
            {
                return Convert.ToInt32(txt);
            }
            catch (Exception)
            {
                throw new Exception("Informe um número válido.");
            }
        }

        public static DateTime ValidarData(this string txt)
        {
            try
            {
                return Convert.ToDateTime(txt);
            }
            catch (Exception)
            {
                throw new Exception("Informe uma data válida.");
            }
        }
    }
}
