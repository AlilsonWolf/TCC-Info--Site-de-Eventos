using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventHub.Models;

    [Table("CronogramaEvento")]
   
    public class CronogramaEvento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required(ErrorMessage ="Por Favor Informe a data do evento!")]
        [Display(Name ="Data do Evento")]
        public DateTime DataEvento { get; set; }

        [Required(ErrorMessage ="Por favor Informe o nome do artista")]
        [StringLength(100)]
        public string NomeArtista { get; set; }

        [Required(ErrorMessage ="Por favor insira uma breve Descrição sobre o artista")]
        [StringLength(200)]
        public string DescricaoArtista { get; set; }

        [ForeignKey("EventoId")]
        public  Evento Evento { get; set; }

         [ForeignKey("ArtistaId")]
        public Artistas Artistas { get; set; }
        public int EventoId { get; set; }

       
        public int ArtistaId { get; set; }

    }