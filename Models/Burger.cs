using System.ComponentModel.DataAnnotations;

namespace PriscilaZuniga_Web_CodeFirst.Models
{
    public class Burger
    {
        public int BurgerID { get; set; }
        // ? Especifica que ese atributo puede contener valores nulos
        //[Required es un data annotation que se aplica solo a la linea de abajo]
        [Required (ErrorMessage="El campo nombre es requerido")]
        public string? Name { get; set; }
        public bool WithCheese { get; set;}
        [Range(0.01, 9999.99, ErrorMessage ="Valor fuera de rango")]
        public decimal Precio { get; set; }
    }
}
