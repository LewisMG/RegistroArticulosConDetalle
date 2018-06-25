using RegistroArticulosConDetalle.BLL;
using RegistroArticulosConDetalle.DAL;
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
    public partial class rCotizaciones : Form
    {
        public rCotizaciones()
        {
            InitializeComponent();
            LlenarComboBox();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private Cotizaciones LlenaClase()
        {
            Cotizaciones cotizacion = new Cotizaciones();

            cotizacion.CotizacionId = Convert.ToInt32(CotizacionIdnumericUpDown.Value);
            cotizacion.Fecha = fechaDateTimePicker.Value;
            cotizacion.Comentario = ObservaciontextBox.Text;

            //Agregar cada linea del Grid al detalle
            foreach (DataGridViewRow item in CotizaciondataGridView.Rows)
            {
                cotizacion.AgregarDetalle(
                    ToInt(item.Cells["id"].Value),
                    ToInt(item.Cells["CotizacionId"].Value),
                    ToInt(item.Cells["PersonaId"].Value),
                    ToInt(item.Cells["ArticuloId"].Value),
                    ToInt(item.Cells["Cantidad"].Value),
                    ToInt(item.Cells["Precio"].Value),
                    ToInt(item.Cells["Importe"].Value)
                  );
            }
            return cotizacion;
        }
        private bool HayErrores()
        {
            bool HayErrores = false;

            if (String.IsNullOrWhiteSpace(ObservaciontextBox.Text))
            {
                GeneralerrorProvider.SetError(ObservaciontextBox,
                    "No debes dejar el Comentario vacio");
                HayErrores = true;
            }

            if (String.IsNullOrWhiteSpace(CanttextBox.Text))
            {
                GeneralerrorProvider.SetError(CanttextBox,
                    "Debes introducir una cantidad");
                HayErrores = true;
            }

            if (String.IsNullOrWhiteSpace(PreciotextBox.Text))
            {
                GeneralerrorProvider.SetError(PreciotextBox,
                    "Debes introducir un precio");
                HayErrores = true;
            }

            if (String.IsNullOrWhiteSpace(ImportetextBox.Text))
            {
                GeneralerrorProvider.SetError(ImportetextBox,
                    "Debes introducir un importe");
                HayErrores = true;
            }

            if (CotizaciondataGridView.RowCount == 0)
            {
                GeneralerrorProvider.SetError(CotizaciondataGridView,
                    "Es obligatorio este campo");
                HayErrores = true;
            }

            return HayErrores;
        }

        private int ToInt(object valor)
        {
            int retorno = 0;

            int.TryParse(valor.ToString(), out retorno);

            return retorno;
        }

        private void LlenarCampos(Cotizaciones cotizacion)
        {
            CotizacionIdnumericUpDown.Value = cotizacion.CotizacionId;
            fechaDateTimePicker.Value = cotizacion.Fecha;
            ObservaciontextBox.Text = cotizacion.Comentario;

            //Cargar el detalle al Grid
            CotizaciondataGridView.DataSource = cotizacion.Detalle;

            //Ocultar columnas
            CotizaciondataGridView.Columns["Id"].Visible = false;
            CotizaciondataGridView.Columns["CotizacionId"].Visible = false;
        }

        private void PreciotextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(PreciotextBox.Text) != 0)
                {
                    TotalnumericUpDown.Value += Convert.ToInt32(PreciotextBox.Text);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void LlenarComboBox()
        {
            Repositorio<Personas> repositorio = new Repositorio<Personas>(new Contexto());
            Repositorio<Articulos> repositori = new Repositorio<Articulos>(new Contexto());
            PersonacomboBox.DataSource = repositorio.GetList(c => true);
            PersonacomboBox.ValueMember = "PersonaId";
            PersonacomboBox.DisplayMember = "Nombres";

            ArticulocomboBox.DataSource = repositori.GetList(c => true);
            ArticulocomboBox.ValueMember = "ArticuloId";
            ArticulocomboBox.DisplayMember = "Descripcion";
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(CotizacionIdnumericUpDown.Value);
            Cotizaciones Cotizacion = CotizacionesBLL.Buscar(id);

            if (Cotizacion != null)
            {
                LlenarCampos(Cotizacion);
            }
            else
                MessageBox.Show("No se encontro!", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            List<DetalleCotizacion> detalle = new List<DetalleCotizacion>();

            if (CotizaciondataGridView.DataSource != null)
            {
                detalle = (List<DetalleCotizacion>)CotizaciondataGridView.DataSource;
            }

            //Agregar un nuevo detalle con los datos introducidos.
            detalle.Add(
                new DetalleCotizacion(
                    id: 0,
                    cotizacioId: (int)CotizacionIdnumericUpDown.Value,
                    personaId: (int)PersonacomboBox.SelectedValue,
                    articuloId: (int)ArticulocomboBox.SelectedValue,
                    cantidad: (int)Convert.ToInt32(CanttextBox.Text),
                    precio: (int)Convert.ToInt32(PreciotextBox.Text),
                    importe: (int)Convert.ToInt32(ImportetextBox.Text)

                ));

            //Cargar el detalle al Grid
            CotizaciondataGridView.DataSource = null;
            CotizaciondataGridView.DataSource = detalle;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            CotizacionIdnumericUpDown.Value = 0;
            fechaDateTimePicker.Value = DateTime.Now;
            ObservaciontextBox.Clear();
            CanttextBox.Clear();
            PreciotextBox.Clear();
            ImportetextBox.Clear();
            TotalnumericUpDown.Value = 0;

            CotizaciondataGridView.DataSource = null;
            GeneralerrorProvider.Clear();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Cotizaciones cotizacion;
            bool Paso = false;

            if (HayErrores())
            {
                MessageBox.Show("Favor revisar todos los campos", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cotizacion = LlenaClase();

            //Determinar si es Guardar o Modificar
            if (CotizacionIdnumericUpDown.Value == 0)
                Paso = CotizacionesBLL.Guardar(cotizacion);
            else
                //validar que exista.
                Paso = CotizacionesBLL.Modificar(cotizacion);

            //Informar el resultado
            if (Paso)
            {
                BtnNuevo.PerformClick();
                MessageBox.Show("Guardado!!", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se pudo guardar!!", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(CotizacionIdnumericUpDown.Value);

            //validar que exista
            if (CotizacionesBLL.Eliminar(id))
                MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo eliminar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
