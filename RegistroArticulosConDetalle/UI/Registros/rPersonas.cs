using RegistroArticulosConDetalle.BLL;
using RegistroArticulosConDetalle.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RegistroArticulosConDetalle.UI.Registros
{
    public partial class rPersonas : Form
    {
        public rPersonas()
        {
            InitializeComponent();
        }

        private Personas LlenaClase()
        {
            Personas persona = new Personas();

            persona.PersonaId = Convert.ToInt32(PersonaIdnumericUpDown.Value);
            persona.Fecha = FechadateTimePicker.Value;
            persona.Nombres = NombretextBox.Text;
            persona.Cedula = CedulamaskedTextBox.Text;
            persona.Direccion = DirecciontextBox.Text;
            persona.Telefono = TelefonomaskedTextBox.Text;

            return persona;
        }

        private void LimpiarCampos()
        {
            PersonaIdnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            NombretextBox.Clear();
            CedulamaskedTextBox.Clear();
            DirecciontextBox.Clear();
            TelefonomaskedTextBox.Clear();
            GeneralerrorProvider.Clear();
        }

        private bool Validar()
        {
            bool HayErrores = false;

            if (String.IsNullOrWhiteSpace(TelefonomaskedTextBox.Text))
            {
                GeneralerrorProvider.SetError(TelefonomaskedTextBox,
                    "No debes dejar el telefono vacio");
                HayErrores = true;
            }
            if (String.IsNullOrWhiteSpace(NombretextBox.Text))
            {
                GeneralerrorProvider.SetError(NombretextBox,
                     "No debes dejar el nombre vacio");
                HayErrores = true;
            }
            if (String.IsNullOrWhiteSpace(DirecciontextBox.Text))
            {

                GeneralerrorProvider.SetError(DirecciontextBox,
                    "No debes dejar la direccion vacia");
                HayErrores = true;
            }
            if (String.IsNullOrWhiteSpace(CedulamaskedTextBox.Text))
            {

                GeneralerrorProvider.SetError(CedulamaskedTextBox,
                    "No debes dejar la cedula vacia");
                HayErrores = true;
            }

            return HayErrores;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(PersonaIdnumericUpDown.Value);
            Personas persona = PersonasBLL.Buscar(id);

            if (persona != null)
            {
                FechadateTimePicker.Value = persona.Fecha;
                NombretextBox.Text = persona.Nombres;
                CedulamaskedTextBox.Text = persona.Cedula;
                DirecciontextBox.Text = persona.Direccion;
                TelefonomaskedTextBox.Text = persona.Telefono;
            }
            else
                MessageBox.Show("No se encontro!", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Personas persona;
            bool Paso = false;

            persona = LlenaClase();

            //Determinar si es Guardar o Modificar
            if (PersonaIdnumericUpDown.Value == 0)
                Paso = PersonasBLL.Guardar(persona);
            else
                //todo: validar que exista.
                Paso = PersonasBLL.Modificar(persona);

            //Informar el resultado
            if (Paso)
                MessageBox.Show("Guardado!!", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo guardar!!", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            //Para Luego que guarden algo los campos se limpien
            LimpiarCampos();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(PersonaIdnumericUpDown.Value);

            //validar que exista
            if (BLL.PersonasBLL.Eliminar(id))
                MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo eliminar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //Para Luego que guarden algo los campos se limpien
            LimpiarCampos();
        }
    }
}
