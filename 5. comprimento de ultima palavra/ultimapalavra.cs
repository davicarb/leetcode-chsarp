public class Solution
{
  public int LengthOfLastWord(string s)
  {
    int quantidadeChar = 0;
    {
      int ponteiroString = s.Length - 1;

      bool achouLetra = false;
      bool achouEspaco = false;

      while (!achouEspaco)
      {
        if (s[ponteiroString] != ' ')
        {
          achouLetra = true;
          quantidadeChar++;
        }
        if (s[ponteiroString] == ' ')
        {
          if (achouLetra)
          {
            achouEspaco = true;
            return quantidadeChar;
          }
        }

        ponteiroString--;

        if (ponteiroString < 0)
        {
          return quantidadeChar;
        }
      }
    }
    return quantidadeChar;
  }
}

// esse foi um dos primeiros exercícios do leetcode que consegui fazer
// a lógica 100% por conta própria. é um marco na minha jornada no leet
// code e em lógica algorítmica!