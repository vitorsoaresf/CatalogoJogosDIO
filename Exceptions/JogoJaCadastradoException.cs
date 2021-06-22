using System;

namespace catalogo_jogos_DIO.Exceptions
{
  public class JogoJaCadastradoException : Exception
  {
    public JogoJaCadastradoException()
        : base("Este já jogo está cadastrado")
    { }
  }
}
