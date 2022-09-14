/*************************************************************
Institución:    Universidad Gabriel Rene Moreno
Carrera:        Ingenieria  en Redes y Telecomunicaciones
Materia:        Estructura de Datos I
Descripción:    Implementacion del TAD Hora
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
    public class clsHora
    {
       int Hor, Min, Seg;
       public clsHora()
       {
           Hor = Min = Seg = 0;
       }

       public clsHora(int hor, int min, int seg)
       {
           if (hor >= 0 && hor < 24 && min >= 0 && min < 60 && seg >= 0 && seg < 60)
           {
               Hor = hor;
               Min = min;
               Seg = seg;
           }
       }

       public clsHora(clsHora Hora)
       {
           Hor = Hora.Hor;
           Min = Hora.Min;
           Seg = Hora.Seg;
       }

        public int Seg1
        {
            get { return Seg; }
            set { if (value > 0 && value <= 59)Seg = value; }
        }

        public int Min1
        {
            get { return Min; }
            set { if (value > 0 && value <= 59)Min = value; }
        }

        public int Hor1
        {
            get { return Hor; }
            set { if (value > 0 && value <= 23) Hor = value; }
        }

        public override string ToString()
        {
            string cad = "";
            if (Hor < 10)
              { cad = "0" + Hor + ":"; }
                else cad = Hor + ":";
            if (Min < 10)
                { cad =cad+ "0" + Min + ":"; }
               else cad =cad+ Min + ":";
            if (Seg < 10)
               { cad = cad+"0" + Seg; }
               else cad = cad+Seg;
            
        return cad;
        }
        public clsHora HorActual()
        {
            clsHora c = new clsHora();
            c.Hor = (int)DateTime.Now.Hour;
            c.Min = (int)DateTime.Now.Minute;
            c.Seg = (int)DateTime.Now.Second;


            return c;
        }




        public void incremen() {
            Seg = (Seg + 1) % 60;
            if (Seg == 0) {
                Min = (Min + 1) % 60;
                if (Min == 0) {
                    Hor=(Hor + 1) % 24;
                }
            }

        }

        public int HraSeg(clsHora H1)
        {
            int h = H1.Hor;
            return h * 3600;
        }

        public int MinSeg(clsHora H2)
        {
            int m = H2.Min;
            return m * 60;
        }

    
        public int totalhor(clsHora h) 
        {
            int t = HraSeg(h) + MinSeg(h) + h.Seg1;
            return t;
        }

     
        public double CantSegMin(clsHora H1)
        {
            double s = H1.Seg;
            // return Convert.ToInt32(s/ 60);
            return (s / 60);
        }
        public int CantHoraMin(clsHora H2)
        {
            int h = H2.Hor;
            // return Convert.ToInt32(h / 3600);
            return h * 60;
        }

        public double totalhoraMin(clsHora t) 
        {
            double r = CantHoraMin(t) + t.Min1 + CantSegMin(t);
            return r;
        }

//---------------------------------------------------
      
        
    }
}
