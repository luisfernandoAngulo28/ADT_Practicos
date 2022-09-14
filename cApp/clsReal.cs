/*************************************************************
Institución:    Universidad Gabriel Rene Moreno
Carrera:        Ingenieria  en Redes y Telecomunicaciones
Materia:        Estructura de Datos I
Descripción:    Implementacion del TAD Real
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
    public class clsReal
    {
        public double cero() 
        {
            return 0;
        }
        public bool esCero(double x)
        {
            if (x == 0)
            {
                return true;
            }
            return false;
        }
        public double suma(double n, double m) 
        {
            double s = 0;
            return (s = n + m);
        }

        public bool SonIguales(double n, double m)
        {
            if (n == m)
            {
                return true;
            }
            else return false;
        }
        public double resta(double n, double m) 
        {
            double r = 0;
            return (r = n - m);
        }
        public double multiplicacion(double n, double m) 
        {
            double mult = 0;
            return (mult = n * m);
        }
        public double division(double a, double b) 
        {
            double d = 0;
            return (d = a / b);
        }
         public double Potencia(double n, byte exp)
       {
       return Math.Pow(n, exp);
       }

       public double Raiz(double n ,double exp)
      {
       if (n >= 0)
       {
           return Math.Pow(n, (1 / exp));
       }
       else {  throw new Exception ("Numero o Base  no valida");
           }
      }
       public double Logaritmo(double n,byte Base)
       {
           if (n > 0 && Base > 0)
           {
               return Math.Log(n, Base);
           }
           else   throw new Exception("Número o potencia no Valida");
       }
       public Boolean EsNegativo(double n)
       {
           if (n >= 0)
               return false;
           else return true;
       }
       

      
       
      
  
    }
}
