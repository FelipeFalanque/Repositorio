using Repositorio.AcessoBanco.Contextos;
using Repositorio.AcessoBanco.Entidades;
using Repositorio.AcessoBanco.Repositorios.Interfaces;
using Repositorio.AcessoBanco.Repositorios.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorio.AcessoBanco.Repositorios.Entidades
{
    public class JogadorRepository : Repository<Jogador>, IJogadorRepository
    {
        public JogadorRepository(ContextoAcessoBanco context) : base(context)
        {

        }

        public Jogador getJogadorComTime(int? id)
        {
            return new Jogador();
            //return ContextoAcessoBanco.Jogadores.Include(a => a.ArtistaDetalhes).SingleOrDefault(a => a.ArtistaId == id);
        }

        public ContextoAcessoBanco ContextoAcessoBanco
        {
            get { return Context as ContextoAcessoBanco; }
        }
    }
}
