using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebChef.Models;
using WebChef.shared;

namespace WebChef.shared
{
    public class ReceitaHandling
    {
        private readonly ReceitaContext _context;
        public ReceitaHandling(ReceitaContext context)
        {
            _context = context;
        }

        public Receita[] getReceitas()
        {
            return _context.receita.ToArray();
        }
        
    }
}
