public class Solution
{
  public bool IsPalindrome(int x)
  {
    string s = x.ToString();
    int esquerda = 0;
    int direita = s.Length - 1;

    while (esquerda < direita)
    {
      if (s[esquerda] != s[direita])
      {
        return false;
      }
      esquerda++;
      direita--;
    }
    return true;
  }
}