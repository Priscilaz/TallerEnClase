using Microsoft.CodeAnalysis.CSharp.Syntax;
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
        [VerificarRango]
        public decimal Precio { get; set; }

        
        //Se relaciona con una lista de objetos de 
        public List<Promo>? Promo { get; set; }
    }
    public class VerificarRango : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            decimal valor = (decimal)value;
            if(valor < 20)
            {
                return true;
            }
            else
            {
                return false;
            }

            //Priscila
            
        }
    }
}
