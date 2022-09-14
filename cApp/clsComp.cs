/*************************************************************
Institución:    Universidad Gabriel Rene Moreno
Carrera:        Ingenieria  en Redes y Telecomunicaciones
Materia:        Estructura de Datos I
Descripción:    Implementacion del TAD Comp
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
    public class clsComp
    {
        double PartReal;
        double PartImag;


        public clsComp()
        {
            PartReal = 0;
            PartImag = 0;
        }

        public clsComp(double real, double imaginario)
        {
            this.PartReal = real;
            this.PartImag = imaginario;
        }

        public clsComp conjugar(double real ,double imaginario)
        {
            this.PartReal = real;
            this.PartImag = imaginario;
            return new clsComp(this.PartReal, this.PartImag);
        }

        public  clsComp sumar(clsComp C1, clsComp C2)
        {
            return new clsComp(C1.PartReal + C2.PartReal, C1.PartImag + C2.PartImag);
        }

        public  clsComp Multiplicar(clsComp C1, clsComp C2)
        {
            //return new clsComp(C1.PartReal * C2.PartReal - C1.PartImag * C2.PartImag, C1.PartImag * C2.PartReal + C1.PartReal * C2.PartImag);
            return new clsComp(C1.PartReal * C2.PartReal, C1.PartImag * C2.PartImag);
        }

        public  clsComp Dividir(clsComp C1, clsComp C2)
        {
            return new clsComp((((C1.PartReal * C2.PartReal) + (C1.PartImag * C2.PartImag)) / ((Math.Pow(C2.PartReal, 2)) + (Math.Pow(C2.PartImag, 2)))),

                               (((C1.PartImag * C2.PartReal) - (C1.PartReal * C2.PartImag)) / ((Math.Pow(C2.PartReal, 2)) + (Math.Pow(C2.PartImag, 2)))));
        }

        public  clsComp Restar(clsComp C1, clsComp C2)
        {
            return new clsComp(C1.PartReal - C2.PartReal, C1.PartImag - C2.PartImag);
        }

        public  double Mod(clsComp C1)
        {
            return (Math.Sqrt(Math.Pow(C1.PartReal, 2) + Math.Pow(C1.PartImag, 2)));

        }
        public string Imprimir()
        {
            string salida = "";
            double i=this.PartReal;
            double j=this.PartImag;
            if(PartReal<=i && PartImag<=j)
            {
                salida += "( " + PartReal.ToString()+";"+ PartImag.ToString() + " i)";
            }
            return salida;
        }
        
    }
}

