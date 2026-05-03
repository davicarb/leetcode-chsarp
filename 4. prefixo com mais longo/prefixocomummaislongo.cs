public class Solution
{
  public string LongestCommonPrefix(string[] strs)
  {
    string prefixoComum = "";

    for (int j = 0; j < strs[0].Length; j++)
    {
      for (int i = 0; i < strs.Length; i++)
      {
        if (strs[i].Length <= j)
        {
          return prefixoComum; 
        }
        if (strs[i][j] != strs[0][j])
        {
          return prefixoComum;
        }
      }
      prefixoComum = prefixoComum + strs[0][j];
    }
    return prefixoComum;
  }
}

// esse foi difícil de entender, mas consegui com ajuda de pesquisas.
// a lógica é: ele compara o caractere na posição J em todas as strings do array.
// se houver caractere igual em todas, ele acumula o prefixoComum (o caractere
// que está em commum em todas as strings).
// se ele encontrar diferença, ele retorna o prefixoComum;
// se não houver nenhum caractere igual, ele só pula direto pro final, retornando
// a string vazia declarada antes (sem prefixo comum).