using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CaracteresConsecutivos 
    {

        public string Consecutivos(string s, int r)
        {
            if (r != 0 && s != null)
            {
                int acumulador = 0;
                string copia = "";
                for (int i = 0; i <= s.Length-1; i++)
                {
                    if(i != s.Length-1)
                    {
                        if (s[i] == s[i + 1])
                        {
                            acumulador++;
                            copia = agregarAString(copia, r, acumulador, s[i]);
                        }
                        else
                        {
                            acumulador++;
                            copia = agregarAString(copia, r, acumulador, s[i]);
                            acumulador = 0;
                        }
                    }
                    else
                    {
                        if (s[i] == s[i - 1])
                        {
                            acumulador++;
                            copia = agregarAString(copia, r, acumulador, s[i]);
                        }
                        else
                        {
                            acumulador++;
                            copia = agregarAString(copia, r, acumulador, s[i]);
                            acumulador = 0;
                        }
                    }
                }
                return copia;
            }
            return "Texto o numero no ingresado";
        }

        private string agregarAString(string copia, int r, int acumulador, char s)
        {
            if (acumulador <= r)
            {
                copia += s;
            }
            return copia;
        }
    }
}
