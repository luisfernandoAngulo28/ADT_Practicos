/*************************************************************
Institución:    Universidad Gabriel Rene Moreno
Carrera:        Ingenieria  en Redes y Telecomunicaciones
Materia:        Estructura de Datos I
Descripción:    Implementacion del TAD cade
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
    public class clsCade
    {
        char[] Cadena=new char[100];
        int cima;

        public int Cima
        {
            get { return cima; }
            set { cima = value; }
        }

        public clsCade() {
            cima=-1;
         }

        public clsCade(string Cadena) {
            cima = Convert.ToUInt16(Cadena.Length);
            for (int i = 0; i <= cima; i++) {
                this.Cadena[i] = Cadena[i];
            }
        }

        public void setCadena(string Cad) {      //meter
            cima =Convert.ToUInt16(Cad.Length);
            for (int i = 0; i <= cima-1; i++) {
                this.Cadena[i] = Cad[i];
            }
        }

        public string getCadena() {         //sacar
            string cad=" ";
            for (int i = 0; i <= cima-1; i++) {
                cad = cad + Cadena[i];
            }
            return cad;
        }
        public void BorrarCade(clsCade c)
        {
              c.cima = -1;
        }

        public Boolean Vacia(clsCade c)
        {
            if (c.cima == -1) 
            {
                return true;
            }else return false;
        }
        public void SetChar(char ch)
        {
            Cadena[cima] = ch;
        }

        public char GetChar(int i) 
        {

            if (i <= cima)
                return Cadena[i];


            else  throw new ArgumentException ("Posicion no valida");
            
        }

      

        public ushort longitud(string cadena){
            return Convert.ToUInt16(cadena.Length);
        }
      
        
        public void AddChar(char n) {
            cima++;
            Cadena[cima] = n;
        }
       

        public void ConMayus() {
            for (int i = 0; i <= cima;i++ )
            {
                Cadena[i] = char.ToUpper(Cadena[i]);
            }
        }

        public void ConMinus()
        {
            for (int i = 0; i <= cima; i++)
            {
                Cadena[i] = char.ToLower(Cadena[i]);
            }
        }

        public void DeleChar(clsCade a ,char n)
        {
            for(int i =0;i<=a.cima;i++)
            {
                if(n == a.Cadena[i])
                {
                    a.DeleChar(a,n);
                }
            }
             cima--;
         }
    
         

        public int ContarPalabras(clsCade c) 
        {
            int cant = 0;

            if (Vacia(c)==false)
            {
                for (int i = 0; i <= c.cima; i++)
                {
                    if (Convert.ToInt32(GetChar(i)) == Convert.ToInt32(' '))
                    {
                        cant++;
                    }

                }
                 cant++;
            }
            else { cant=0;
            }
            return cant;
        }
     

        public void InvertirCad()
        {
           char Aux;
            int f=0;
            for (int i = cima; i>=0; i--)
            {
                Aux = Cadena[f];
                Cadena[f] = Cadena[i];
               Cadena[i] = Aux;
                f++;
                
            }
         }

       public void invertirCad(string s)
        {
           
    int n = longitud(s) ;
    if( n > 0 ) {
    char x = s[n];
    s.Remove(n,1);
    invertirCad( s);
    s.Insert( 1,Convert.ToString( x) );
  
      }
  }

      

        public Boolean SeEncChr(char ch)
        {
            Boolean se=false;
            for (int i = 0; i <= cima; i++)
            {
                if (Convert.ToInt32(Cadena[i]) == Convert.ToInt32(ch))
                {
                    
                    i = cima++;
                    se = true;
                }
                
            }
            return se;
        }

        public int NrVcChr(char ch)
        {
            int nve = 0;
            for (int i = 0; i <= cima; i++)
            {
                if (Convert.ToInt32(Cadena[i]) == Convert.ToInt32(ch))
                {
                    nve++;
                }
            }
            return nve; 
        }

        
    }
}
