/*************************************************************
Institución:    Universidad Gabriel Rene Moreno
Carrera:        Ingenieria  en Redes y Telecomunicaciones
Materia:        Estructura de Datos I
Descripción:    Implementacion del TAD Agenda utilizando Arreglos.
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
     public class clsAgen
    {
         //lo mas nuevo 
        int Maxfil = 50;
        int MaxCol = 50;

        string[,] Matriz;
        string[] vectorD;
        int dim = 50;


        public clsAgen()
        {
            Matriz = new String[Maxfil, MaxCol];
            vectorD = new String[dim];
            dim = 0;
            Maxfil = 0;

        }
        public int get_dim()
        {

            return this.dim;
        }
        public void Add_contacto(string nombre, string ci, string dir, string cel)
        {

            dim = get_dim() + 5;
            for (int i = 0; i < 4; i++)
            {


            }




        }
        public void cargar(string nombre, string dir, string cel, string otros)
        {
            Maxfil = contador() - 1;
            //   MaxCol=col;
            for (int c = 0; c < 4; c++)
            {
                if (c == 0) { Matriz[Maxfil, c] = nombre; }
                if (c == 1) { Matriz[Maxfil, c] = dir; }
                if (c == 2) { Matriz[Maxfil, c] = cel; }
                if (c == 3) { Matriz[Maxfil, c] = otros; }

            }

        }
        public string mostrar_agenda()
        {
            string s = "";
            Maxfil = contador() - 1;
            for (int f = 0; f < Maxfil; f++)
            {

                for (int c = 0; c < 4; c++)
                {

                    s = s + " |" + Convert.ToString(Matriz[f, c]);
                }
                s = s + "\n";


            }


            return s;

        }
        public int contador()
        {
            this.Maxfil++;
            return this.Maxfil;

        }
        //buscador de persona  por Ci
        public string buscar_per(string nombre)
        {
            string s = "";
            bool b = false;
            int j = 0;
            int i = 0;
            while ((i < Maxfil) && (b == false))
            {
                j = 0;
                while ((j < 4) && (b == false))
                {
                    if (Matriz[i, j] == nombre)
                    {
                        s = s + "NOMBRE    "+Matriz[i, 0] + "/ DIRECCION       " + Matriz[i, 1] + "/ Nro CELULAR    " + Matriz[i, 2] + "/  OTROS" + Matriz[i, 3];
                        b = true;
                    }
                    j++;

                }
                i++;
            }

            return s;
        }

    }
}
