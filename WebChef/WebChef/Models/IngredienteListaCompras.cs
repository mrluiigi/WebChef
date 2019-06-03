using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebChef.Models
{
    public class IngredienteListaCompras : IEquatable<IngredienteListaCompras>
    {

        public string designacao { set; get; }

  
        public string imagem { set; get; }


        public string quantidade { set; get; }

        public bool Equals(IngredienteListaCompras ing)
        {
            if (ing == null) return false;
            return (this.designacao.Equals(ing.designacao));
        }

    }
}
