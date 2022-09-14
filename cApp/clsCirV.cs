/*************************************************************
Institución:    Universidad Gabriel Rene Moreno
Carrera:        Ingenieria  en Redes y Telecomunicaciones
Materia:        Estructura de Datos I
Descripción:    Implementacion del TAD CirV
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
   public class clsCirV
    {
        double radio;
         double ancho;
     

        public double Radio
        {
            get { return radio; }
            set { radio = value; }
        }
        public double Ancho
        {
            get { return ancho; }
            set { ancho = value; }
        }
        public clsCirV()
        {
            radio = 0;
        }
        public clsCirV(double radio)// constructor x parametro
        {
            if (radio >= 0) {
                this.radio = radio;
            
            }
        }
        public clsCirV(clsCirV c) {// constructor de copia

            this.radio = c.radio;
        }
         public double getdiametro(double radio)
        {
            return 2 * radio;
         }
         public double area(double radio)
         {
             return Math.PI * Math.Pow(radio, 2);
         }
         public double Perimetro(double radio) 
         {
             return 2 * Math.PI * radio;
         }
 
    }
}
