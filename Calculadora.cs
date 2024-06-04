using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodigoDio
{
    public class Calculadora
    {
        private List<string> _historico;
        private string _data;

        public Calculadora(string data)
        {
            _historico = new List<string>();
            _data = data;
        }

        public int somar(int val1, int val2)
        {   
            int resultado = val1 + val2;
            _historico.Insert(0, "Res" + resultado + " - data: " + _data);
            return resultado;
        }

        public int subtrair(int val1, int val2)
        {
            int resultado = val1 - val2;
            _historico.Insert(0, "Res" + resultado + " - data: " + _data);           
            return resultado;
        }   

        public int multiplicar(int val1, int val2)
        {   
            int resultado = val1 * val2;
            _historico.Insert(0, "Res" + resultado + " - data: " + _data);
            return resultado;
            
        }   

        public int dividir(int val1, int val2)
        {
            int resultado = val1 / val2;
            _historico.Insert(0, "Res" + resultado + " - data: " + _data);
            return resultado;
        } 

        public List<string> historico()
        {     
            _historico.RemoveRange(3, _historico.Count - 3);
            return _historico;
        }     
    }
}