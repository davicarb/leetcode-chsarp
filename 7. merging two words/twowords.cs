public class Solution
{
  public string MergeAlternately(string word1, string word2)
  {
    // word1: abc
    // word2: de

    //stringReturn: adbec

    StringBuilder mergedString = new StringBuilder();

    for (int i = 0; i < word1.Length || i < word2.Length; i++)
    {
        if (i < word1.Length) mergedString.Append(word1[i]);
        if (i < word2.Length) mergedString.Append(word2[i]);
    }
    return mergedString.ToString();
  }
}