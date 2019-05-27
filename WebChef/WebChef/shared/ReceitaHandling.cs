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
        private readonly ReceitaUtilizadorContext _contextRU;
        private readonly ReceitaPassoContext _contextRP;
        private readonly PassoContext _contextPasso;
        private readonly AcaoContext _contextAcao;
        private readonly IngredienteContext _contextIngrediente;
        private readonly PassoIngredienteContext _contextPassoIngrediente;
        private readonly ReceitaIngredienteContext _contextReceitaIngrediente;
        private readonly LocalizacaoContext _contextLocalizacao;
        private readonly IngredienteLocalizacaoContext _contextIngredienteLocalizacao;



        public ReceitaHandling(ReceitaContext context, ReceitaUtilizadorContext contextRU, ReceitaPassoContext contextRP, PassoContext contextPasso, 
                                AcaoContext contextAcao, IngredienteContext contextIngrediente, PassoIngredienteContext contextPassoIngrediente, 
                                ReceitaIngredienteContext contextRI, LocalizacaoContext contextLocalizacao, IngredienteLocalizacaoContext contextIngredienteLocalizacao)
        {
            _context = context;
            _contextRU = contextRU;
            _contextRP = contextRP;
            _contextPasso = contextPasso;
            _contextAcao = contextAcao;
            _contextIngrediente = contextIngrediente;
            _contextPassoIngrediente = contextPassoIngrediente;
            _contextReceitaIngrediente = contextRI;
            _contextLocalizacao = contextLocalizacao;
            _contextIngredienteLocalizacao = contextIngredienteLocalizacao;
        }

        public Receita[] getReceitas()
        {
            return _context.receita.ToArray();
        }
        
        public Receita getReceita(int id)
        {
            Receita res = _context.receita.Where(r => r.id_receita == id).FirstOrDefault();
            ReceitaIngrediente[] receitaIng = _contextReceitaIngrediente.receitaIngrediente.Where(ri => ri.id_receita == res.id_receita).ToArray();
            Ingrediente[] ingredientes = new Ingrediente[receitaIng.Length];
            for (int j = 0; j < receitaIng.Length; j++)
            {
                Ingrediente ing = _contextIngrediente.ingrediente.Where(i => i.id_ingrediente == receitaIng[j].id_ingrediente).FirstOrDefault();
                ingredientes[j] = ing;
                ingredientes[j].quantidade = receitaIng[j].quantidade;
            }

            res.ingredientes = ingredientes;
            return res;
        }

        public Ingrediente GetIngrediente(int idIngrediente)
        {
            Ingrediente i = _contextIngrediente.ingrediente.Where(ing => ing.id_ingrediente == idIngrediente).FirstOrDefault();
            IngredienteLocalizacao[] ingLocal = _contextIngredienteLocalizacao.ingredienteLocalizacao.Where(il => il.id_ingrediente == i.id_ingrediente).ToArray();
            Localizacao[] localizacoes = new Localizacao[ingLocal.Length];
            for (int k = 0; k < ingLocal.Length; k++)
            {
                localizacoes[k] = _contextLocalizacao.localizacao.Where(lo => lo.id_localizacao == ingLocal[k].id_localizacao).FirstOrDefault();
            }
            i.localizacoes = localizacoes;
            return i;
        }

        // A função serve para verificar se o utilizador tem a receita como favorita
        public bool TemReceitaFavorita(int idReceita, int idUtilizador)
        {
            return _contextRU.receitaUtilizador.Any(ru => ru.id_receita == idReceita && ru.id_utilizador == idUtilizador && ru.favorita == "S");
        }

        // A função serve para verificar se o utilizador tem a receita na ementa semanal
        public bool TemReceitaNaEmenta(int idReceita, int idUtilizador)
        {
            return _contextRU.receitaUtilizador.Any(ru => ru.id_receita == idReceita && ru.id_utilizador == idUtilizador && ru.dia_da_semana != null && ru.refeicao != null);
        }

        public void addReceitaEmenta(int idReceita, int idUtilizador, string text)
        {
            string diaSemana = text.Substring(0,3);
            string refeicao = text[3].ToString();
            ReceitaUtilizador r = _contextRU.receitaUtilizador.Where(ru => ru.id_receita == idReceita && ru.id_utilizador == idUtilizador).FirstOrDefault();
            if (r != null)
            {
                r.dia_da_semana = diaSemana;
                r.refeicao = refeicao;
                _contextRU.SaveChanges();
            }
            else
            {
                ReceitaUtilizador ru = new ReceitaUtilizador(idReceita, idUtilizador, null, null, null, diaSemana, refeicao, null, null, null);
                _contextRU.receitaUtilizador.Add(ru);
                _contextRU.SaveChanges();
            }
        }

        public ReceitaUtilizador[] getDiasEmenta(int idReceita)
        {
            return _contextRU.receitaUtilizador.Where(ru => ru.id_receita == idReceita).ToArray();
        }


        public void rmReceitaEmenta(int idReceita, int idUtilizador, string text)
        {
            string diaSemana = text.Substring(0, 3);
            string refeicao = text[3].ToString();
            ReceitaUtilizador r = _contextRU.receitaUtilizador.Where(ru => ru.id_receita == idReceita &&
                                                                     ru.id_utilizador == idUtilizador &&
                                                                     ru.dia_da_semana == diaSemana &&
                                                                     ru.refeicao == refeicao).FirstOrDefault();
            if (r != null) {
                r.dia_da_semana = null;
                r.refeicao = null;
                _contextRU.SaveChanges();
            }
        }

     

        public Passo[] GetPassos(int idReceita)
        {
            ReceitaPasso[] receitaPassos = _contextRP.receitaPasso.Where(r => r.id_receita == idReceita).OrderBy(r => r.numero).ToArray();
            List<int> idPassos = new List<int>();

            foreach (ReceitaPasso r in receitaPassos) {
                idPassos.Add(r.id_passo);
            }

            Passo[] passos = new Passo[idPassos.Count];
            for (int i = 0; i < idPassos.Count; i++)
            {
                Passo p = _contextPasso.passo.Where(passo => passo.id_passo == idPassos[i]).FirstOrDefault();
                Acao a = _contextAcao.acao.Where(ac => ac.id_acao == p.id_acao).FirstOrDefault();

                PassoIngrediente[] passoIngredientes = _contextPassoIngrediente.passoIngrediente.Where(pi => pi.id_passo == p.id_passo).ToArray();
                Ingrediente[] ingredientes = new Ingrediente[passoIngredientes.Length];
                for (int j = 0; j < passoIngredientes.Length; j++)
                {
                    ingredientes[j] = _contextIngrediente.ingrediente.Where(ing => ing.id_ingrediente == passoIngredientes[j].id_ingrediente).FirstOrDefault();
                    ingredientes[j].quantidade = passoIngredientes[j].quantidade;
                }
                p.ingredientes = ingredientes;
                p.passosIngrediente = passoIngredientes;
                p.Acao = a;
                passos[i] = p;
            }

            return passos;
        }



        public bool registarReceita(Receita receita)
        {
            _context.receita.Add(receita);
            _context.SaveChanges();
            return true;
        }

        public bool registarIngrediente(Ingrediente ingrediente)
        {
            _contextIngrediente.ingrediente.Add(ingrediente);
            _contextIngrediente.SaveChanges();
            return true;
        }

        public bool registarAcao(Acao acao)
        {
            _contextAcao.acao.Add(acao);
            _contextAcao.SaveChanges();
            return true;
        }

    }
}
