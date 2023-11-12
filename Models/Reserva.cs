using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MVCBasico_ReservaJuego.Models
{
    public class Reserva
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdReserva { get; set; }
        public Juego IdJuego { get; set; }
        public Cliente NroCliente { get; set; }
    }
  
}
