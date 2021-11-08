using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using Entidades.TP3;

namespace Gomez.Federico.TP3
{
    public partial class FormInformacion : Form
    {
        private FormaBuscados formBuscados;
        private FormAgregar formAgregar;
        private Cochera cochera;


        public FormInformacion()
        {
            InitializeComponent();
            cochera = new Cochera();
            this.ActualizarLista();
        }


        public void CargarInformacion(string informacion)
        {
            this.rtbInformacion.Text = informacion;
        }
        public void ActualizarInformacion()
        {
            if(this.cochera.Vehiculos.Count != 0)
            {
                foreach (Vehiculo v in this.cochera.Vehiculos)
                {
                    this.rtbInformacion.Text += JsonSerializer.Serialize(v);
                }
            }else
            {
                this.rtbInformacion.Text = string.Empty;
            }

        }

        public void AgregarVehiculo(Vehiculo vehiculo)
        {

            this.cochera += vehiculo;
            this.rtbInformacion.Text += JsonSerializer.Serialize(vehiculo);
        }

        public string RetornarInformacion()
        {
            return this.rtbInformacion.Text;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            formAgregar = new FormAgregar(AgregarVehiculo, EliminarVehiculo, BuscarVehiculo);
            this.formAgregar.Show();
        }

        public void EliminarVehiculo(Vehiculo vehiculo)
        {
            foreach (Vehiculo v in this.cochera.Vehiculos)
            {
                if(v == vehiculo)
                {
                    this.cochera.Vehiculos.Remove(v);
                    this.ActualizarInformacion();
                    break;
                }
            }

        }
        public Vehiculo BuscarVehiculo(string patente)
        {
            foreach (Vehiculo v in this.cochera.Vehiculos)
            {
                if(v.Patente == patente)
                {
                    return v;
                }
            }
            return null;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            formBuscados = new FormaBuscados();
            foreach (Vehiculo v in this.cochera.Vehiculos)
            {
                if (v.Nombre == this.txtNombreBusqueda.Text)
                {
                    formBuscados.MostrarVehiculos(v);
                }
            }
            formBuscados.Show();

        }

        public void ActualizarLista()
        {
            if(this.rtbInformacion.Text != null)
            {
                Cochera cocheraAux = new Cochera();
                cocheraAux.Vehiculos = JsonSerializer.Deserialize<List<Vehiculo>>(this.rtbInformacion.Text);
                this.cochera = cocheraAux;
            }
        }
    }
}
