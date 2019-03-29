using Repositorio.AcessoBanco.Repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorio.AcessoBanco.Repositorios.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IJogadorRepository Jogadores { get; }

        int Commit();
    }
}
