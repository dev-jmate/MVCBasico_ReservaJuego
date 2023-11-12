using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCBasico_ReservaJuego.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore.Design;

namespace MVCBasico_ReservaJuego.Context
{
    public class ClienteDatabaseContext:DbContext
    {
        public ClienteDatabaseContext(DbContextOptions<ClienteDatabaseContext> options):base(options)
        {
        }
        //Esto es lo que quiero mapear a la BD
        //El DbSet será una tabla de base de datos
        public DbSet<Cliente> Clientes { get; set; }
        //Esto es lo que quiero mapear a la BD
        //El DbSet será una tabla de base de datos
        public DbSet<MVCBasico_ReservaJuego.Models.Reserva>? Reserva { get; set; }

   
    }

}

