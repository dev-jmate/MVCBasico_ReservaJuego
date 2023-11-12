using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
namespace MVCBasico_ReservaJuego.Models
{
    public class Manual:Juego
    {
        public const int TIEMPO_JUEGO_MAX = 60;
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TiempoJuegoReservado { get; set; }
    }
}
