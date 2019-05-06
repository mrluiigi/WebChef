using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebChef.Models;
using WebChef.shared;

namespace WebChef.shared
{
    public class UtilizadorHandling
    {
        private readonly UtilizadorContext _context;

        public UtilizadorHandling(UtilizadorContext context)
        {
            _context = context;
        }

        public Utilizador[] getUtilizadores()
        {
            return _context.utilizador.ToArray();
        }

        public bool registarUtilizador(Utilizador user)
        {
            user.password = MyHelpers.HashPassword(user.password);
            if(!_context.utilizador.Any(u => u.email == user.email)){
                _context.utilizador.Add(user);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public bool validateUser(Utilizador user)
        {
            user.password = MyHelpers.HashPassword(user.password);
            var returnedUser = _context.utilizador.Where(b => b.email == user.email && b.password == user.password).FirstOrDefault();

            if (returnedUser == null)
            {
                return false;
            }
            return true;
        }



    }
}
