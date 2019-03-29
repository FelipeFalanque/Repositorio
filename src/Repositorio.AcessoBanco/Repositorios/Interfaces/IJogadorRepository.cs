using Repositorio.AcessoBanco.Entidades;
using Repositorio.AcessoBanco.Repositorios.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorio.AcessoBanco.Repositorios.Interfaces
{
    public interface IJogadorRepository : IRepository<Jogador>
    {
        Jogador getJogadorComTime(int? id);
    }
}
