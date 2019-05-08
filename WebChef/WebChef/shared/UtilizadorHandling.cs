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
        private readonly ReceitaUtilizadorContext _contextRU;

        public UtilizadorHandling(UtilizadorContext context, ReceitaUtilizadorContext contextRU)
        {
            _context = context;
            _contextRU = contextRU;
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

        public int getUtilizadorLoggedIn(string email)
        {
            return _context.utilizador.Where(u => u.email == email).FirstOrDefault().id_utilizador;
        }


        public void AddReceitaFavorita(ReceitaUtilizador ru)
        {
            _contextRU.receitaUtilizador.Add(ru);
            _contextRU.SaveChanges();
        }

        public void RmReceitaFavorita(int idReceita, int idUtilizador) {

            ReceitaUtilizador rU = _contextRU.receitaUtilizador.Where(ru => ru.id_receita == idReceita && ru.id_utilizador == idUtilizador).FirstOrDefault();
            _contextRU.receitaUtilizador.Remove(rU);
            _contextRU.SaveChanges();
        }
    }
}
