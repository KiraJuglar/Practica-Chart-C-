using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Chart
{
    
    class Burbuja
    {
        private int[] conjunto;

        public Burbuja(int[] conjunto)
        {
            this.conjunto = conjunto;
        }

        public void Ordenar()
        {
            int aux = 0;
            for(int i = 0; i < conjunto.Length; i++)
            {
                for (int j = 1; j < conjunto.Length; j++)
                {
                    if(conjunto[j - 1] < conjunto[j])
                    {
                        aux = conjunto[j];
                        conjunto[j] = conjunto[j - 1];
                        conjunto[j - 1] = aux;

                    }
                }
            }
        }

        public int[] Conjunto
        {
            get { return conjunto; }
        }
    }
}
