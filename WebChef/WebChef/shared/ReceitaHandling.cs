﻿using System;
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
        private readonly IngredientePreferidoUtilizadorContext _contextIPU;
        private readonly EmentaSemanalContext _contextEmentaSemanal;


        public ReceitaHandling(ReceitaContext context, ReceitaUtilizadorContext contextRU, ReceitaPassoContext contextRP, PassoContext contextPasso, 
                                AcaoContext contextAcao, IngredienteContext contextIngrediente, PassoIngredienteContext contextPassoIngrediente, 
                                ReceitaIngredienteContext contextRI, IngredientePreferidoUtilizadorContext contextIPU, EmentaSemanalContext contextES)
        {
            _context = context;
            _contextRU = contextRU;
            _contextRP = contextRP;
            _contextPasso = contextPasso;
            _contextAcao = contextAcao;
            _contextIngrediente = contextIngrediente;
            _contextPassoIngrediente = contextPassoIngrediente;
            _contextReceitaIngrediente = contextRI;
            _contextIPU = contextIPU;
            _contextEmentaSemanal = contextES;
        }

        public Receita[] getReceitas()
        {
            return _context.receita.ToArray();
        }

        public Receita[] getReceitasComIngrediente(int idIngrediente)
        {
            ReceitaIngrediente[] ri = _contextReceitaIngrediente.receitaIngrediente.Where(i => i.id_ingrediente == idIngrediente).ToArray();
            Receita[] res = new Receita[ri.Length];
            for(int i = 0; i < ri.Length; i++)
            {
                Receita r = _context.receita.Where(receita => receita.id_receita == ri[i].id_receita).FirstOrDefault();
                res[i] = r;
            }
            return res;
        }

        public ReceitaUtilizador getReceitaUtilizador(int idReceita, int idUtilizador)
        {
            return _contextRU.receitaUtilizador.Where(ru => ru.id_receita == idReceita && ru.id_utilizador == idUtilizador).FirstOrDefault();
        }

        public Ingrediente[] getIngredientes()
        {
            return _contextIngrediente.ingrediente.ToArray();
        }

        public Acao[] getAcoes()
        {
            return _contextAcao.acao.ToArray();
        }


        public Receita[] getReceitasFavoritas(int idUtilizador)
        {
            ReceitaUtilizador[] ru = _contextRU.receitaUtilizador.Where(r => r.id_utilizador == idUtilizador && r.favorita == "S").ToArray();
            if (ru != null)
            {
                Receita[] res = new Receita[ru.Length];
                for (int i = 0; i < ru.Length; i++)
                {
                    res[i] = _context.receita.Where(r => r.id_receita == ru[i].id_receita).FirstOrDefault();
                }
                return res;
            }
            else
            {
                return null;
            }
        }


        public Receita[] getHistorico(int idUtilizador)
        {
            ReceitaUtilizador[] ru = _contextRU.receitaUtilizador.Where(r => r.id_utilizador == idUtilizador).ToArray();
            if (ru != null)
            {
                Receita[] res = new Receita[ru.Length];
                for (int i = 0; i < ru.Length; i++)
                {
                    res[i] = _context.receita.Where(r => r.id_receita == ru[i].id_receita).FirstOrDefault();
                    res[i].receitaUtilizador = ru[i];
                }
                return res;
            }
            else
            {
                return null;
            }
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


        public Receita[] getReceitasSugeridas(int idUtilizador)
        {
            //Vai buscar todas as receitas
            List<Receita> receitas = _context.receita.ToList();

            //ingredientes preferidos
            IngredientePreferidoUtilizador[] preferidos = _contextIPU.ingredientePreferidoUtilizador.Where(i => i.id_utilizador == idUtilizador && i.favorito == "S").ToArray();
            //Ingredientes a evitar do utilizador em sessão
            IngredientePreferidoUtilizador[] aEvitar = _contextIPU.ingredientePreferidoUtilizador.Where(i => i.id_utilizador == idUtilizador && i.favorito == "N").ToArray();

            List<int> ids = new List<int>();

            //percorre todas as receitas
            for (int i = 0; i < receitas.Count; i++)
            {
                //todos os ingredientes de uma receita
                ReceitaIngrediente[] ri = _contextReceitaIngrediente.receitaIngrediente.Where(ring => ring.id_receita == receitas[i].id_receita).ToArray();
                //percorre todos os ingredientes da receita
                for (int j = 0; j < ri.Length; j++)
                {
                    //percorre os ingredientes preferidos
                    for (int k = 0; k < preferidos.Length; k++)
                    {
                        if (ri[j].id_ingrediente == preferidos[k].id_ingrediente)
                        {
                            //Adiciona se tiver ingrediente preferido
                            ids.Add(receitas[i].id_receita);
                        }
                    }
                }
                for (int j = 0; j < ri.Length; j++)
                {
                    //percorre os ingredientes a evitar
                    for (int k = 0; k < aEvitar.Length; k++)
                    {
                        //se esse ingrediente for um a Evitar
                        if (ri[j].id_ingrediente == aEvitar[k].id_ingrediente)
                        {
                            // retira-o
                            ids.RemoveAll(r => r == receitas[i].id_receita);
                        }
                    }
                }
            }
            ids = ids.Distinct().ToList();
            Receita[] res = new Receita[ids.Count];
            for(int i = 0; i < ids.Count; i++)
            {
                res[i] = _context.receita.Where(x => x.id_receita == ids[i]).FirstOrDefault();
            }
            return res;
        }

        public Ingrediente GetIngrediente(int idIngrediente)
        {
            Ingrediente i = _contextIngrediente.ingrediente.Where(ing => ing.id_ingrediente == idIngrediente).FirstOrDefault();
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
            return _contextEmentaSemanal.ementaSemanal.Any(es => es.id_receita == idReceita && es.id_utilizador == idUtilizador && es.dia_da_semana != null);
        }

        public void addReceitaEmenta(int idReceita, int idUtilizador, string text)
        {
            
            EmentaSemanal es = _contextEmentaSemanal.ementaSemanal.Where(ru => ru.id_receita == idReceita && ru.id_utilizador == idUtilizador && ru.dia_da_semana == text).FirstOrDefault();
            if (es == null)
            {
                EmentaSemanal e = new EmentaSemanal();
                e.id_receita = idReceita;
                e.id_utilizador = idUtilizador;
                e.dia_da_semana = text;
                _contextEmentaSemanal.ementaSemanal.Add(e);
                _contextEmentaSemanal.SaveChanges();
            }
        }

        public EmentaSemanal[] getDiasEmenta(int idReceita, int idUtilizador)
        {
            return _contextEmentaSemanal.ementaSemanal.Where(ru => ru.id_receita == idReceita && ru.id_utilizador == idUtilizador).ToArray();
        }

        public EmentaSemanal[] getEmentaSemanal(int idUtilizador)
        {
            return _contextEmentaSemanal.ementaSemanal.Where(ru => ru.id_utilizador == idUtilizador).ToArray();
        }

        public EmentaSemanal[] getReceitasEmenta(int idUtilizador)
        {
            EmentaSemanal[] ementa = _contextEmentaSemanal.ementaSemanal.Where(ru => ru.id_utilizador == idUtilizador).ToArray();
            for(int i = 0; i < ementa.Length; i++)
            {
                ementa[i].receita = _context.receita.Where(r => r.id_receita == ementa[i].id_receita).FirstOrDefault();
            }
            return ementa;
        }


        public Receita[] getReceitasPorCategoria(string categoria)
        {
            return _context.receita.Where(x => x.categoria == categoria).ToArray();
        }


        public void rmReceitaEmenta(int idReceita, int idUtilizador, string text)
        {
            EmentaSemanal r = _contextEmentaSemanal.ementaSemanal.Where(ru => ru.id_receita == idReceita &&
                                                                        ru.id_utilizador == idUtilizador &&
                                                                        ru.dia_da_semana == text).FirstOrDefault();
            if (r != null) {
                _contextEmentaSemanal.Remove(r);
                _contextEmentaSemanal.SaveChanges();
            }
        }


        public IngredienteListaCompras[] calculaListaCompras(int idUtilizador)
        {
            List<IngredienteListaCompras> lista = new List<IngredienteListaCompras>();
            EmentaSemanal[] es = getEmentaSemanal(idUtilizador);
            int indice = 0;
            string quantidade;

            for (int i = 0; i < es.Length; i++)
            {
                Receita r = getReceita(es[i].id_receita);
                for (int j = 0; j < r.ingredientes.Length; j++)
                {

                    IngredienteListaCompras ilc = new IngredienteListaCompras();
                    ilc.designacao = r.ingredientes[j].designacao;
                    ilc.imagem = r.ingredientes[j].imagem;
                    ilc.quantidade = r.ingredientes[j].quantidade;

                    if (lista.Contains(ilc))
                    {
                        indice = lista.IndexOf(ilc);
                        quantidade = lista[indice].quantidade;
                        lista[indice].quantidade = quantidade + "; " + ilc.quantidade;
                    }
                    else
                    {
                        lista.Add(ilc);
                    }

                }
            }

            return lista.ToArray();
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



        public int registarReceita(Receita receita)
        {
            _context.receita.Add(receita);
            _context.SaveChanges();
            return receita.id_receita;
        }
        
        public void addReceitaIngrediente(ReceitaIngrediente pi)
        {
            ReceitaIngrediente p = _contextReceitaIngrediente.receitaIngrediente.Where(ping => ping.id_receita == pi.id_receita && ping.id_ingrediente == pi.id_ingrediente).FirstOrDefault();
            if (p != null)
            {

            }
            else
            {
                _contextReceitaIngrediente.receitaIngrediente.Add(pi);
                _contextReceitaIngrediente.SaveChanges();
            }
        }

        public void addPassoIngrediente(PassoIngrediente pi)
        {
            PassoIngrediente p = _contextPassoIngrediente.passoIngrediente.Where(ping => ping.id_passo == pi.id_passo && ping.id_ingrediente == pi.id_ingrediente).FirstOrDefault();
            if (p != null)
            {

            }
            else
            {
                _contextPassoIngrediente.passoIngrediente.Add(pi);
                _contextPassoIngrediente.SaveChanges();
            }
        }

        public int registarPasso(Passo p, int idReceita, int numero)
        {
            _contextPasso.passo.Add(p);
            _contextPasso.SaveChanges();
            ReceitaPasso rp = new ReceitaPasso();
            rp.id_receita = idReceita;
            rp.id_passo = p.id_passo;
            rp.numero = numero;
            _contextRP.receitaPasso.Add(rp);
            _contextRP.SaveChanges();
            return p.id_passo;
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

        public void adicionarAvaliacao(int receitaID, int userID, int classificacao, string dificuldade, string anotacao)
        {
            ReceitaUtilizador r = _contextRU.receitaUtilizador.Where(ru => ru.id_receita == receitaID && ru.id_utilizador == userID).FirstOrDefault();
            if (r != null)
            {
                r.classificacao = classificacao;
                r.avaliacao_dificuldade = dificuldade;
                r.anotacao = anotacao;
                r.data_realizacao = DateTime.Now;
                _contextRU.SaveChanges();
            }
            else
            {
                ReceitaUtilizador ru = new ReceitaUtilizador();
                ru.id_receita = receitaID;
                ru.id_utilizador = userID;
                ru.avaliacao_dificuldade = dificuldade;
                ru.classificacao = classificacao;
                ru.data_realizacao = DateTime.Now;
                ru.anotacao = anotacao;
                _contextRU.receitaUtilizador.Add(ru);
                _contextRU.SaveChanges();
            }
        }


        public void setTimeInicio(int idReceita, int idUtilizador)
        {
            ReceitaUtilizador ru = _contextRU.receitaUtilizador.Where(r => r.id_receita == idReceita && r.id_utilizador == idUtilizador).FirstOrDefault();
            if (ru != null)
            {
                if (ru.timeInicio == null)
                {
                    ru.timeInicio = DateTime.Now.TimeOfDay;
                    _contextRU.SaveChanges();
                }
            }
            else
            {
                ReceitaUtilizador r = new ReceitaUtilizador();
                r.id_receita = idReceita;
                r.id_utilizador = idUtilizador;
                r.timeInicio = DateTime.Now.TimeOfDay;
                _contextRU.receitaUtilizador.Add(r);
                _contextRU.SaveChanges();
            }
            
        }

        // É chamada quando utilizador conclui confeção da receita
        public void setDuracao(int idReceita, int idUtilizador)
        {
            ReceitaUtilizador ru = _contextRU.receitaUtilizador.Where(r => r.id_receita == idReceita && r.id_utilizador == idUtilizador).FirstOrDefault();
            if (ru != null)
            {
                ru.duracao = DateTime.Now.TimeOfDay - ru.timeInicio;
                ru.timeInicio = null;
                _contextRU.SaveChanges();
            }
            else
            {
                ReceitaUtilizador r = new ReceitaUtilizador();
                r.id_receita = idReceita;
                r.id_utilizador = idUtilizador;
                _contextRU.receitaUtilizador.Add(r);
                _contextRU.SaveChanges();
            }
        }



        public void IngredienteAPreferido(int idIngrediente, int idUtilizador)
        {
            IngredientePreferidoUtilizador ipu = _contextIPU.ingredientePreferidoUtilizador.Where(i => i.id_ingrediente == idIngrediente && i.id_utilizador == idUtilizador).FirstOrDefault();
            if (ipu != null)
            {
                ipu.favorito = "S";
                _contextIPU.SaveChanges();
            }
            else
            {
                IngredientePreferidoUtilizador i = new IngredientePreferidoUtilizador();
                i.id_ingrediente = idIngrediente;
                i.id_utilizador = idUtilizador;
                i.favorito = "S";
                _contextIPU.ingredientePreferidoUtilizador.Add(i);
                _contextIPU.SaveChanges();
            }
        }

        public void IngredienteAEvitar(int idIngrediente, int idUtilizador)
        {
            IngredientePreferidoUtilizador ipu = _contextIPU.ingredientePreferidoUtilizador.Where(i => i.id_ingrediente == idIngrediente && i.id_utilizador == idUtilizador).FirstOrDefault();
            if (ipu != null)
            {
                ipu.favorito = "N";
                _contextIPU.SaveChanges();
            }
            else
            {
                IngredientePreferidoUtilizador i = new IngredientePreferidoUtilizador();
                i.id_ingrediente = idIngrediente;
                i.id_utilizador = idUtilizador;
                i.favorito = "N";
                _contextIPU.ingredientePreferidoUtilizador.Add(i);
                _contextIPU.SaveChanges();
            }
        }

        public void Remover(int idIngrediente, int idUtilizador)
        {
            IngredientePreferidoUtilizador ipu = _contextIPU.ingredientePreferidoUtilizador.Where(i => i.id_ingrediente == idIngrediente && i.id_utilizador == idUtilizador).FirstOrDefault();
            if (ipu != null)
            {
                ipu.favorito = null;
                _contextIPU.SaveChanges();
            }
        }

        public Ingrediente[] getPreferencias(int idUtilizador)
        {
            IngredientePreferidoUtilizador[] ipu = _contextIPU.ingredientePreferidoUtilizador.Where(i => i.id_utilizador == idUtilizador).ToArray();
            Ingrediente[] res = new Ingrediente[ipu.Length];
            for(int i = 0; i < ipu.Length; i++)
            {
                res[i] = _contextIngrediente.ingrediente.Where(ing => ing.id_ingrediente == ipu[i].id_ingrediente).FirstOrDefault();
                res[i].favorito = ipu[i].favorito;
            }
            return res;
        }




    }
}
