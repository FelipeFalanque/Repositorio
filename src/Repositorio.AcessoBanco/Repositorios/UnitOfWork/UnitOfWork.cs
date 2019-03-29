using Repositorio.AcessoBanco.Contextos;
using Repositorio.AcessoBanco.Repositorios.Entidades;
using Repositorio.AcessoBanco.Repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorio.AcessoBanco.Repositorios.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ContextoAcessoBanco _context;

        public UnitOfWork(ContextoAcessoBanco context)
        {
            _context = context;
            // Inicia os repositorys
            Jogadores = new JogadorRepository(_context);
        }

        // Add os repositorys
        public IJogadorRepository Jogadores { get; private set; }

        public int Commit()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
