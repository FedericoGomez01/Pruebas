using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Correspondencia
    {
        private List<string> nombre;
        private List<string> cuenta;
        private List<string> saldo;

        public Correspondencia()
        {
            nombre = new List<string>();
            cuenta = new List<string>();
            saldo = new List<string>();
        }

        public List<string> Nombre
        {
            get { return this.nombre; }
            set
            {
                if(value != null)
                {
                    this.nombre = value;
                }
            }
        }

        public List<string> Cuenta
        {
            get { return this.cuenta; }
            set
            {
                if (value != null)
                {
                    this.cuenta = value;
                }
            }
        }

        public List<string> Saldo
        {
            get { return this.saldo; }
            set
            {
                if (value != null)
                {
                    this.saldo = value;
                }
            }
        }

        public bool ObtenerInfo(string n, string auxNombre, string auxCuenta, string auxSaldo)
        {
            bool exito = false;
            for (int i =0; i <= nombre.Count; i++)
            {
                if(n == nombre[i])
                {
                    auxNombre = this.Nombre[i];
                    auxCuenta = this.Cuenta[i];
                    auxSaldo = this.Saldo[i];
                    exito = true;
                }
            }
            return exito;
        }

    }
}
