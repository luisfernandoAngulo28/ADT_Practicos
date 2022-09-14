/*************************************************************
Institución:    Universidad Gabriel Rene Moreno
Carrera:        Ingenieria  en Redes y Telecomunicaciones
Materia:        Estructura de Datos I
Descripción:    Implementacion del TAD Conj
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
    public class clsConj
    {
        const int MAX = 100;
        int[] conj;
        int dim;

        public int Dim
        {
            get { return dim; }
            set { dim = value; }
        }

        public clsConj()
        {
            conj = new int[MAX];
            dim = -1;
        }
        public clsConj(clsConj C)
    {
         
           this.conj = C.conj;
            this.dim = C.Dim;
    }

      
        public void añadir(clsConj A, int ele)
        {
            dim++;
            if (A.Esta(A, ele) == false)
            {

                conj[dim] = ele;
            }
            else 
            {
                dim--;
            }
            
        }
        public bool Esta(clsConj B, int c)
        {

            int i = 0;
            while (i <= B.dim && B.conj[i] != c)
            {
                i++;
            }
            if (i <= dim)
                return true;
            else return false;

        }
        public void eliminar(clsConj B1, int c)
        {
            int i = 0;
            while (i <= B1.dim && B1.conj[i] != c)
            {
                i++;
            }
            if (i <= B1.dim)
            {
                for (int j = i; j <= B1.dim; j++)
                {
                    B1.conj[j] = B1.conj[j + 1];

                }
                B1.dim--;
            }

        }
        public void Vaciar(clsConj A)
        {
            A.dim = -1;
        }
        public clsConj Union(clsConj A, clsConj B)
        {
            clsConj C = new clsConj();
            for (int i = 0; i <= A.dim; i++)
            {
                 C.añadir(C, A.conj[i]);
            }
            for (int j = 0; j <= B.dim; j++)
            {
                C.añadir(C, B.conj[j]);
            }
            return C;
        }
        public Boolean igual(clsConj A, clsConj B)
        {
            bool b= false;
            for (int i = 0; i <= A.dim; i++)
            {
                if (Esta(B, A.conj[i]) == false)
                    b= false;
            }
            if (A.dim == B.dim)
            {
                b= true;
            }
            return b;
        }
        public clsConj Interseccion(clsConj A, clsConj B)
        {
            clsConj C = new clsConj(A);
            for (int i = 0; i <= C.dim; i++)
            {
                if (B.Esta(B, C.conj[i]) == false)
                {
                    C.eliminar(C, C.conj[i]);
                   
                }
            }
            return C;
        }
        public byte TotalEl(clsConj B)
        {
            return Convert.ToByte(B.dim + 1);
        }
    }
}
