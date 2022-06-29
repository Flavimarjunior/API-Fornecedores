/* using Microsoft.EntityFrameWorkCore;
using System;
using System Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro de Fornecedores.Data
{

    public class BancoContext : Dbcontext 
    {
        public BancoContext(DBcontextOptions<BancoContext> options) base(options)
        {
        }

        public DbSet<FornecedoresModel> Fornecedores { get; set; }
    }
}*/