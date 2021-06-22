using catalogo_jogos_DIO.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace catalogo_jogos_DIO.Repositories
{
  public interface IJogoRepository : IDisposable
  {
    Task<List<Jogo>> Obter(int pagina, int quantidade);
    Task<Jogo> Obter(Guid id);
    Task<List<Jogo>> Obter(string nome, string produtora);
    Task Inserir(Jogo jogo);
    Task Atualizar(Jogo jogo);
    Task Remover(Guid id);
  }
}
