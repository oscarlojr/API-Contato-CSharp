using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Contato.Entities;
using Microsoft.EntityFrameworkCore;

namespace API_Contato.Context
{
    public class AgendaContext(DbContextOptions<AgendaContext> options) : DbContext(options)
    {
        public DbSet<Contato> Contatos { get; set; }
    }
}

//05