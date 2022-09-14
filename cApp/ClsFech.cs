/*************************************************************
Institución:    Universidad Gabriel Rene Moreno
Carrera:        Ingenieria  en Redes y Telecomunicaciones
Materia:        Estructura de Datos I
Descripción:    Implementacion del TAD Fecha
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
   public class ClsFech
   {
       
        int[] numero ={1, 2, 3, 4, 5, 6, 7, 8, 9, 0  };
        byte dd;
        byte mm;
        ushort yy;
       
        public byte mes
       {   get { return mm; }
           set {if(value>0 && value <=12) mm = value; }
       }

        public byte dia
       {   get { return dd; }
           set { if (value > 0 && value <= CantDiaenFecha(yy,mm)) dd = value; }
       }

        public ushort año
       {   get { return yy; }
           set {if(value>=0 && value<=9999) yy = value; }
       }

        public ClsFech() {//constructor de oficio
            dd = (byte)DateTime.Now.Day;
            mm = (byte)DateTime.Now.Month;
            yy = (UInt16)DateTime.Now.Year;
        }

        public ClsFech(byte dd,byte mm,ushort yy){ //constructor parametrizado
            if (dd > 0 && dd <=CantDiaenFecha(yy,mm)  && mm > 0 && mm <= 12 && yy >= 0 && yy <= 9999)
            {   this.yy = yy;
                this.dd = dd;
                this.mm = mm;
            }
            else throw new ArgumentException("Fecha No Valida");
        }

        public ClsFech(ClsFech f) {//constructor de copia
            if (f.dia > 0 && f.dia <= f.CantDiaenFecha(f.año,f.mes) && f.mes > 0 && f.mes <= 12 && f.año >= 0 && f.año <= 9999)
            {   this.dd = f.dd;
                this.mm = f.mm;
                this.yy = f.yy;
            }
            else throw new ArgumentException("Fecha No Valida");
        }

        public override string ToString()
        {
            string cad = "";
            if (this.dd < 10)
                cad = cad + "0" + this.dia + "/";
            else cad = cad + this.dd+"/";
            if (this.mm < 10)
                cad = cad + "0" + this.mm + "/";
            else cad = cad + this.mm + "/";
            if (this.yy < 10)
                cad = cad + "000" + this.yy;
            else
            {
                if (this.yy < 100)
                    cad = cad + "00" + this.yy;
                else
                {
                    if (this.yy < 1000)
                        cad = cad + "0" + this.yy;
                    else cad = cad + this.yy;
                }     
                 
            }

           
            return cad;
        }

        public byte CantDiaenFecha(ushort yy, byte mm)
        {   byte dd=0;
        if (mm > 0 && mm <= 12 && yy >= 0 && yy <= 9998)
        {
            if (mm == 1 || mm == 3 || mm == 5 || mm == 7 || mm == 8 || mm == 10 || mm == 12)
            { dd = 31; }
            if (mm == 4 || mm == 6 || mm == 9 || mm == 11)
            { dd = 30; }
            if (mm == 2)
            {
                if (EsBisiesto(yy))
                    dd = 29;
                else dd = 28;
            }
        }
        else
        {
            throw new ArgumentException("La Fecha Ingresada es Invalida");
        }
            return dd;
        }

        public string GetFecha(ClsFech c)
        {   string fecha;
        if (c.dia < 10)
            fecha = "0" + c.dia;
        else fecha =""+c.dia;
        
        if (c.mes < 10)
            fecha = fecha + "0" + c.mes;
        else fecha = fecha + c.mes;

        if (c.año < 10)
            fecha = fecha + "000" + c.año;
        else
        {
            if (c.año < 100)
                fecha = fecha + "00" + c.año;
            else
            {
                if (c.año < 1000)
                    fecha = fecha + "0" + c.año;
                else fecha = fecha + c.año;
            }
        }
            return Convert.ToString(fecha);
        }

        public ClsFech FechActual()
        {ClsFech c = new ClsFech();
            c.año =(UInt16)DateTime.Now.Year;
            c.mes =(byte) DateTime.Now.Month;
            c.dia =(byte) DateTime.Now.Day;
        
        
        return c;
        }

        public int edad(ClsFech f) 
        {
          int  r = DateTime.Now.Year - f.yy;
          return r;
        }
       
        public uint FecToMile(ClsFech A)
        {
            return Convert.ToUInt32(A.año / 1000); 
        }

        public uint FecToSig(ClsFech A)
        {
            return Convert.ToUInt32(A.año/100); 
        }

        public uint FecToDec(ClsFech A)
        {
            return Convert.ToUInt32(A.año / 10); 
        }

        public uint FecToSem(ClsFech A)
        {   uint semes = 0;
            semes =(uint) (semes + (A.año * 2));
            semes =(uint) (semes + (A.mes / 6));
            return semes;
        }

        public uint FecToTrim(ClsFech A)
        {
            uint trimes = 0;
            trimes = (uint)(trimes + (A.año * 4));
            trimes = (uint)(trimes + (A.mes / 3));
            return trimes; 
        }
    }
}
