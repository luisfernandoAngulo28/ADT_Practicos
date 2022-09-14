/*************************************************************
Institución:    Universidad Gabriel Rene Moreno
Carrera:        Ingenieria  en Redes y Telecomunicaciones
Materia:        Estructura de Datos I
Descripción:    Implementacion del TAD Bolsa
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
    public class clsBols
    {
        char[] Bolsa;
        int cima;

   public int Cima
  {
  get { return cima; }
  set { cima = value; }
  }

    public clsBols()        // constructores
    {
        Bolsa = new char[1000];
        cima = -1;
    }

    public clsBols(clsBols B)
    {
         
           this.Bolsa = B.Bolsa;
            this.cima = B.Cima;
    }

    public void Insertar(clsBols B, char ch)
    {
        cima++;
        if (B.Esta(B, ch) == false)
        {

            Bolsa[cima] =ch;
        }
        else
        {
            cima--;
        }

    } 
       
       

       public void Vaciar(clsBols B)
       {
           B.cima = -1;
       }

        public clsBols Union(clsBols B1, clsBols B2)
       {
           clsBols BR = new clsBols(B1);
           for (int i = 0; i <= B2.cima; i++)
           {
               if (!BR.Esta(B1,B2.Bolsa[i])==true)
               BR.Insertar(BR , B2.Bolsa[i]);
           }
           return BR;
       }

       public bool Esta(clsBols B,char c )
       {
         
           int i=0;
           while(i<=B.cima&& B.Bolsa[i]!=c)
           {
               i++;
           }
           if (i <= cima)
               return true;
           else return false;
           
       }

     

       public clsBols Interseccion(clsBols B1,clsBols B2)
       {
           clsBols BA = new clsBols(B1);

           for (int i = 0; i <= BA.cima; i++)
           {
               if (B2.Esta(B2, BA.Bolsa[i]) == false)
               {
                   BA.eliminar(BA, BA.Bolsa[i]);

               }
           }

               return BA;
       }

       public clsBols InsSR(clsBols B1)
       {
           clsBols BA = new clsBols();
           for (int i = 0; i <= cima; i++)
           {
               if (!B1.Esta(BA, B1.Bolsa[i]))
               {
                   BA.Insertar(BA,B1.Bolsa[i]);
               }

           } 
           return BA;
       }
        
      public clsBols Diferencia(clsBols B1, clsBols B2)
       {
           clsBols BA = new clsBols();
           BA.InsSR(B1);

           for (int i = 0; i <= B2.cima; i++)
           {
               if (BA.Esta(BA, B2.Bolsa[i]))
               {
                   BA.eliminar(BA, B2.Bolsa[i]);
               }
               else BA.Insertar(BA,B2.Bolsa[i]);
           }
           return BA;
       }

      public void eliminar(clsBols B1, char c)
       {
          int i =0;
          while (i <= B1.cima && B1.Bolsa[i] != c)
          {
              i++;
          }
          if (i <= B1.cima)
          {
              for (int j = i; j <= B1.cima; j++)
              {
                  B1.Bolsa[j] = B1.Bolsa[j + 1];

              }
              B1.cima--;
          }

       }

    
    }
}
