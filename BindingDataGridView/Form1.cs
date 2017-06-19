using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BindingDataGridView.Models;

namespace BindingDataGridView
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Constructor de la forma
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            bindingSource1.DataSource = new List<Product>();
        }

        /// <summary>
        /// Evento de error en el DataGridView
        /// </summary>
        /// <param name="sender">Objeto que dispara el evento</param>
        /// <param name="e">Argumentos del evento</param>
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show(this, e.Exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Clic al botón para mostrar el producto
        /// </summary>
        /// <param name="sender">Objeto que dispara el evento</param>
        /// <param name="e">Argumentos del evento</param>
        private void buttonCurrent_Click(object sender, EventArgs e)
        {
            if (bindingSource1.Current != null)
            {
                var prod = bindingSource1.Current as Product;
                MessageBox.Show(String.Format(
                    "Nombre: {0} \n" +
                    "Cantidad: {1} \n" +
                    "Precio: {2} \n" +
                    "IVA: %{3:0.00} \n" +
                    "Descuento: %{4:0.00} \n" +
                    "Total: {5:C}",
                    prod.Name,
                    prod.Quantity,
                    prod.Price,
                    prod.Tax,
                    prod.Discount,
                    prod.Total));
            }
            else
            {
                MessageBox.Show("No hay producto seleccionado");
            }
        }
    }
}