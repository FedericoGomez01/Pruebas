﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Entidades.TP3
{
    public class GestorDeArchivos : ICargarGuardar 
    {
        private string path;
        //private Cochera cochera;
        public GestorDeArchivos(string path)
        {
            this.path = path;
        }
        public string Leer()
        {
            try
            {
                using (StreamReader sr = new StreamReader(this.path))
                { 
                    return sr.ReadToEnd();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Guardar( string archivo)
        {
            try
            {
                using(StreamWriter sw = new StreamWriter(this.path))
                {
                    for (int i = 0; i < archivo.Length; i++)
                    {
                        sw.WriteLine();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        //public void GuardarComo(string archivo)
        //{
        //    try
        //    {
                
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
    }
}
