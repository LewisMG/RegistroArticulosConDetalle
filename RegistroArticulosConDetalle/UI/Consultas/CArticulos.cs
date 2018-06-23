using RegistroArticulosConDetalle.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace RegistroArticulosConDetalle.UI.Consultas
{
    public partial class CArticulos : Form
    {
        public CArticulos()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            //Inicializando el filtro en True
            Expression<Func<Articulos, bool>> filtro = x => true;

            int id, precio;
            switch (FiltrocomboBox.SelectedIndex)
            {
                case 0://ID
                    id = Convert.ToInt32(CriteriotextBox.Text);
                    filtro = x => x.ArticuloId == id
                    && (x.FechaVencimiento >= DesdedateTimePicker.Value && x.FechaVencimiento <= HastadateTimePicker.Value);
                    break;
                case 1:// Descripcion
                    filtro = x => x.Descripcion.Contains(CriteriotextBox.Text)
                    && (x.FechaVencimiento >= DesdedateTimePicker.Value && x.FechaVencimiento <= HastadateTimePicker.Value);
                    break;
                case 2:// Precio
                    precio = Convert.ToInt32(CriteriotextBox.Text);
                    filtro = x => x.Precio == precio
                    && (x.FechaVencimiento >= DesdedateTimePicker.Value && x.FechaVencimiento <= HastadateTimePicker.Value);
                    break;
                case 3:// Cantidad cotizada
                    filtro = x => x.CantCotizada.Equals(CriteriotextBox.Text)
                    && (x.FechaVencimiento >= DesdedateTimePicker.Value && x.FechaVencimiento <= HastadateTimePicker.Value);
                    break;
            }
            ConsultadataGridView.DataSource = BLL.ArticulosBLL.GetList(filtro);
        }
    }
}
