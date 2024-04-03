using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventHub.Models
{
    [Table("Eventos")]
    public class Evento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required(ErrorMessage ="Por Favor Insira o Nome Do Evento!")]
        [StringLength(255,ErrorMessage ="O tamanho maximo do titulo é de 255 caracteres")]
        public string Titulo { get; set; }

        [Required(ErrorMessage ="Insira a descrição sobre o Evento")]
        [StringLength(999,ErrorMessage ="O tamanho maximo da descrição é até de 999 caracteres")]
        public string Descricao { get; set; }

        [Required(ErrorMessage ="Por Favor insira a Data do Evento")]
        [Display(Name ="Data do Evento")]
        public DateTime DataEvento { get; set; }

        [Required(ErrorMessage ="Por favor Insira a localização")]
        [StringLength(255,ErrorMessage ="O Tamanho maximo da Localização é de 255 carateres")]
        public string Localizacao { get; set; }

        [Required(ErrorMessage ="Por favor Insira o video")]
        [StringLength(300)]
        public string LinkVideo { get; set; }

        // Adicione a propriedade CronogramaEvento para representar a relação um-para-muitos
        public List<CronogramaEvento> CronogramaEvento { get; set; }
    }
}
