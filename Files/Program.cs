using System;
using System.IO;

namespace Files
{
    class Archivos
    {
        public Archivos(string path1, string path2,string path3)
        {
            this.path1 = path1;
            this.path2 = path2;
            this.path3 = path3;
        }
        public string path1{get;}
        public string path2{get;}
        public string path3{get;private set;}
        public void Escribir()
            {
                StreamReader archivo1  = new StreamReader(this.path1);
                StreamReader archivo2  = new StreamReader(this.path2);
                StreamWriter archivo3 = new StreamWriter(this.path3, true);
                string linea1 = archivo1.ReadLine();
                string linea2 = archivo2.ReadLine();
                while (linea1 != null)
                {
                    archivo3.WriteLine(linea1);
                    if (linea2 != null)
                        {
                            archivo3.WriteLine(linea2);
                            linea2 = archivo2.ReadLine();
                        }
                    linea1 = archivo1.ReadLine();
                }
                linea2 = archivo2.ReadLine();
                while (linea2 != null)
                    {
                        archivo3.WriteLine(linea2);
                        linea2 = archivo2.ReadLine();
                    }
            archivo1.Close();
            archivo2.Close();
            archivo3.Close();
            }       
    }
    class programa
        {
           public static void Main()
            {
                Archivos files = new Archivos("NEWS.txt","ejercicio introduccion a programacion.txt","nuevo.txt");
                files.Escribir();
            }
        }
}