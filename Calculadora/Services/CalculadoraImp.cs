using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        private List<string> listaHistorico;
        private string data;

        public CalculadoraImp(string data)
        {
            listaHistorico = new List<string>();
            this.data = data;
        }

        public int somar(int var1, int var2)
        {
            int res = var1 + var2;
            listaHistorico.Insert(0, "Res: " + res + " - data: " + data);
            return res;
            
        }

        public int subtrair(int var1, int var2)
        {
            int res = var1 - var2;
            listaHistorico.Insert(0, "Res: " + res + " - data: " + data);
            return res;
        }

        public int multiplicar(int var1, int var2)
        {
            int res = var1 * var2;
            listaHistorico.Insert(0, "Res: " + res + " - data: " + data);
            return res;
        }

        public int dividir(int var1, int var2)
        {
            int res = var1 / var2;
            listaHistorico.Insert(0, "Res: " + res + " - data: " + data);
            return res;
        }

        public List<string> historico()
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count -3);
            return listaHistorico;
        }
    }
}

