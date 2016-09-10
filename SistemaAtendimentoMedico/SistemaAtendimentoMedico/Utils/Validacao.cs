using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public static double ValidarDecimal(this string txt)
        {
            try
            {
                return Convert.ToDouble(txt);
            }
            catch (Exception)
            {
                throw new Exception("Informe um número válido.");
            }
        }

        public static double ValidarPorcentagemDecimal(this string txt)
        {
            try
            {
                double n = Convert.ToDouble(txt);
                if (n < 0 || n > 100) throw new Exception();
                return n;
            }
            catch (Exception)
            {
                throw new Exception("Informe uma porcentagem válida. O número deve estar entre 0 e 100.");
            }
        }

        public static int ValidarItemSelecionado(this ComboBox cb, string informacao)
        {
            try
            {
                return Convert.ToInt32(cb.SelectedValue.ToString());
            }
            catch (Exception)
            {
                throw new Exception("Selecione um(a) " + informacao);
            }
        }
    }
}
