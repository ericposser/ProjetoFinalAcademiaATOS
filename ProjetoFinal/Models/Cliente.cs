using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinal.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Column("id")]
        [Display(Name = "Código")]
        public int id { get; set; }

        [Column("cpf")]
        [Display(Name = "CPF")]
        [Required(ErrorMessage = "Digite um CPF valido!")]
        public string cpf { get; set; }
        
        [Column("nome")]
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Digite um nome valido!")]
        public string nome { get; set; }

        [Column("telefone")]
        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "Digite um telefone valido!")]
        public string telefone { get; set; }

        [Column("dataNasci")]
        [Display(Name = "Data de nascimento")]
        [Required(ErrorMessage = "Digite uma data valida!")]
        public string dataNasci { get; set; }

    }
}
