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
    public partial class rArticulos : Form
    {
        public rArticulos()
        {
            InitializeComponent();
        }

        private Articulos LlenarClase()
        {

            Articulos articulo = new Articulos();

            articulo.ArticuloId = Convert.ToInt32(ArticuloIdnumericUpDown.Value);
            articulo.Descripcion = DescripciontextBox.Text;
            articulo.Precio = Convert.ToInt32(PrecionumericUpDown.Value);
            articulo.FechaVencimiento = FVdateTimePicker.Value;
            articulo.Existencia = Convert.ToInt32(ExistencianumericUpDown.Value);
            articulo.CantCotizada = Convert.ToInt32(CCnumericUpDown.Value);

            return articulo;
        }

        private void LimpiarCampos()
        {
            ArticuloIdnumericUpDown.Value = 0;
            DescripciontextBox.Clear();
            PrecionumericUpDown.Value = 0;
            ExistencianumericUpDown.Value = 0;
            CCnumericUpDown.Value = 0;
        }

        private bool Validar(int validar)
        {

            bool paso = false;
            if (validar == 1 && ArticuloIdnumericUpDown.Value == 0)
            {
                GeneralerrorProvider.SetError(ArticuloIdnumericUpDown, "Ingrese un ID");
                paso = true;

            }
            if (validar == 2 && DescripciontextBox.Text == string.Empty)
            {
                GeneralerrorProvider.SetError(DescripciontextBox, "Ingrese una descripcion");
                paso = true;
            }
            if (validar == 2 && PrecionumericUpDown.Value == 0)
            {

                GeneralerrorProvider.SetError(PrecionumericUpDown, "Ingrese un precio");
                paso = true;
            }
            if(validar == 2 && ExistencianumericUpDown.Value == 0)
            {
                GeneralerrorProvider.SetError(ExistencianumericUpDown, "Ingrese la Existencia del Articulo");
                paso = true;
            }
            if (validar == 2 && CCnumericUpDown.Value == 0)
            {

                GeneralerrorProvider.SetError(CCnumericUpDown, "Ingrese la cantidad cotizada");
                paso = true;
            }
            return paso;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            GeneralerrorProvider.Clear();

            if (Validar(1))
            {
                MessageBox.Show("Ingrese un ID");
                return;
            }

            int id = Convert.ToInt32(ArticuloIdnumericUpDown.Value);
            Articulos articulo = ArticulosBLL.Buscar(id);

            if (articulo != null)
            {
                DescripciontextBox.Text = articulo.Descripcion;
                PrecionumericUpDown.Value = articulo.Precio;
                ExistencianumericUpDown.Value = articulo.Existencia;
                CCnumericUpDown.Value = articulo.CantCotizada;
                FVdateTimePicker.Text = articulo.FechaVencimiento.ToString();
            }
            else
                MessageBox.Show("No se encontro", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            GeneralerrorProvider.Clear();
            LimpiarCampos();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar(2))
            {
                MessageBox.Show("LLenar los campos marcados");
                return;
            }

            GeneralerrorProvider.Clear();


            if (ArticuloIdnumericUpDown.Value == 0)
            {
                if (ArticulosBLL.Guardar(LlenarClase()))
                {
                    LimpiarCampos();
                    MessageBox.Show("Guardado!!", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (ArticulosBLL.Modificar(LlenarClase()))
                {
                    MessageBox.Show("Guardado!!", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                    MessageBox.Show("No se pudo guardar!!", "Fallo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Para limpiar los campos
            LimpiarCampos();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            GeneralerrorProvider.Clear();

            if (Validar(1))
            {
                MessageBox.Show("Ingrese un ID");
                return;
            }

            int id = Convert.ToInt32(ArticuloIdnumericUpDown.Value);

            if (BLL.ArticulosBLL.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo eliminar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //Para limpiar los campos
            LimpiarCampos();
        }
    }
}
