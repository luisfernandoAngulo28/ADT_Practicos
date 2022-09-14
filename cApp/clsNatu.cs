/*************************************************************
Institución:    Universidad Gabriel Rene Moreno
Carrera:        Ingenieria  en Redes y Telecomunicaciones
Materia:        Estructura de Datos I
Descripción:    Implementacion del TAD Natural
Creador:        Ricardo Vargas Méndez
Lenguaje:       C#
Herramienta:     Visual Studio 2019 - Windows Aplications
*************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cApp
{
    public class clsNatu
    {

        public int Cero()
        {
            return 0;
        }
        public bool esCero(int x)
        {
            if (x == 0)
            {
                return true;
            }
            return false;
        }

        public int Sucesor(int x)
        {
            x = x + 1;
            return x;
        }

        public int Predecesor(int x)
        {
            if (esCero(x) == true)
                return x;

            if (esCero(x) == false)
            {
                x = x - 1;
            }
            return x;
        }

        public bool Igual(int x, int y)
        {
            if (x == y)
                return true;

            return false;
        }

        public int Suma(int a, int b)
        {

            int s = 0;
            if (a < 0 || b < 0)
            {
                throw new Exception("Error numero invalido");
            }
            else
            {
                s = a + b;
            }
            return s;
        }
        public int Resta(int a, int b)
        {
            int r = 0;
            if (a < 0 || b < 0)
            {
                throw new Exception("Error numero invalido");
            }
            else
            {
                if (a > b)
                {
                    r = a - b;
                }
                else
                {
                    r = b - a;
                }
            }
            return r;
        }
        public int multiplicar(int a, int b)
        {
            int m = 0;
            if (a < 0 || b < 0)
            {
                throw new Exception("Error numero invalido");
            }
            else
            {
                m = a * b;
            }
            return m;
        }
    }
}