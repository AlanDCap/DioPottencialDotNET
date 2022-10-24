using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseGenerica
{
    internal class MeuArray<T>
    {
        private static int capacidade = 10;
        private int contador = 0;
        private T[] arr = new T[capacidade];

        public void AdicionarElementoArray(T elemento)
        {
            if (contador +1 < 11)
            {
                arr[contador] = elemento;
            }
            contador++;
        }
        
        public T this[int index]
        {
            get { return arr[index]; }
            set { arr[index] = value; }
        }
    }
}
