namespace PizzaPlace.Shared
{
    public class Pizza
    {
        public Pizza(int id, string nombre, decimal precio, Picantes picantes)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Precio = precio;
            this.picante = picantes;
        }
        public int Id { get; }
        public string Nombre { get; }
        public decimal Precio { get; }
        public Picantes picante { get; }
    }
}
