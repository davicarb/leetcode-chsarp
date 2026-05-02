using System.IO.Pipelines;

public class Solution
{
  public int RomanToInt(string s)
  {
    
    Dictionary<char, int> numeros = new Dictionary<char, int>();
    numeros.Add('I', 1);
    numeros.Add('V', 5);
    numeros.Add('X', 10);
    numeros.Add('L', 50);
    numeros.Add('C', 100);
    numeros.Add('D', 500);
    numeros.Add('M', 1000);

    int result = 0;

    for (int i = 0; i < s.Length - 1; i++)
    {
      if (numeros[s[i]] < numeros[s[i + 1]])
      {
        result = result - numeros[s[i]];
      }
      
      else if (numeros[s[i]] == numeros[s[i + 1]])
      {
        result = result + numeros[s[i]];
      }
      else if (numeros[s[i]] > numeros[s[i + 1]])
      {
        result = result + numeros[s[i]];
      }
    }
    result = result + numeros[s[s.Length -1]];
    return result;
  }
}