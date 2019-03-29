using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorio.AcessoBanco.Repositorios.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        //IArtistaRepository Artistas { get; }
        //IArtistaDetalheRepository ArtistaDetalhes { get; }
        int Commit();
    }
}
