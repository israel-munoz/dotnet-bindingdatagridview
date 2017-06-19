namespace BindingDataGridView.Models
{
    /// <summary>
    /// Clase Productos
    /// </summary>
    internal class Product
    {
        /// <summary>
        /// Nombre del producto
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Cantidad
        /// </summary>
        public int Quantity { get; set; }
        /// <summary>
        /// Precio
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Porcentaje de impuestos
        /// </summary>
        public decimal Tax { get; private set; }
        /// <summary>
        /// Porcentaje de descuento
        /// </summary>
        public decimal Discount { get; set; }
        /// <summary>
        /// Costo total
        /// </summary>
        public decimal Total
        {
            get
            {
                var t = (Quantity * (Price * (1 + (Tax / 100))));
                return t - (t * (Discount / 100));
            }
        }

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public Product()
        {
            Name = "";
            Quantity = 0;
            Price = 0;
            Tax = 16;
            Discount = 0;
        }
    }
}