namespace PriscilaZuniga_Web_CodeFirst.Models
{
    public class Promo
    {
        public int PromoID { get; set; }

        public string? Descripcion { get; set; }
        public DateTime FechaPromo { get; set; }

        //nombre de la clave primaria de la clase
        //Esto es una clave foranea
        public int BurgerID { get; set; }
        //Propiedades de navegacion
        public Burger? Burger { get; set;}

    }
}
