using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAtendimentoMedico.Data
{
    interface IDao<T>
    {
        void Insert(T item);
        void Update(T item);
        void Delete(string key);
        List<T> Select(List<Tuple<string, object, string>> whereParameters);
    }
}
