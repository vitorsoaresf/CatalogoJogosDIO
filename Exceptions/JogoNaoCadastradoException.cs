using System;

namespace catalogo_jogos_DIO.Exceptions
{
  public class JogoNaoCadastradoException : Exception
  {
    public JogoNaoCadastradoException()
        : base("Este jogo não está cadastrado")
    { }
  }
}
