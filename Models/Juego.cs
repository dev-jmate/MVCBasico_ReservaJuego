
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MVCBasico_ReservaJuego.Models
{
    public abstract class Juego
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string NombreJuego { get; set; }
        public int EdadJugadores { get; set; }
        public int CantJugadoresMin { get; set; }
        public int CantJugadoresMax { get; set; }
        [EnumDataType(typeof(Categoria))]
        public Categoria Categoria { get; set; }
        [EnumDataType(typeof(Dificultad))]
        public Dificultad Dificultad { get; set; }
    }
}
