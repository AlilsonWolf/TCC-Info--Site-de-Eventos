using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventHub.Models;

    [Table("Artista")]

    public class Artistas
    {
     [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage ="Por Favor Insira o nome do Artista")]
        [StringLength(100)]
        public string Nome { get; set; }
        
        [Required(ErrorMessage ="Insira o gênero Musical")]
        [StringLength(30,ErrorMessage ="O Tamanho maximo é de 30 caracteres")]
        public string GeneroMusical { get; set; }

        [StringLength(250)]
        public string CanalYouTube{ get; set; }
    }

