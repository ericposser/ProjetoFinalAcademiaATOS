using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinal.Models
{
    [Table("Veiculo")]
    public class Veiculo
    {
        [Column("id")]
        [Display(Name = "Código")]
        public int id { get; set; }

        [Column("placa")]
        [Display(Name = "Placa")]
        [Required(ErrorMessage = "Digite uma placa valida!")]
        public string placa { get; set; }

        [Column("modelo")]
        [Display(Name = "Modelo")]
        [Required(ErrorMessage = "Digite um modelo valido!")]
        public string modelo { get; set; }

        [Column("marca")]
        [Display(Name = "Marca")]
        [Required(ErrorMessage = "Digite uma marca valida!")]
        public string marca { get; set; }

        [Column("cor")]
        [Display(Name = "Cor")]
        [Required(ErrorMessage = "Digite uma cor valida!")]
        public string cor { get; set; }

        [Column("carroceria")]
        [Display(Name = "Carroceria")]
        [Required(ErrorMessage = "Digite uma carroceria valida!")]
        public string carroceria { get; set; }

        [Column("valor")]
        [Display(Name = "Valor")]
        [Required(ErrorMessage = "Digite um preço valido!")]
        public float valor { get; set; }

    }
}
