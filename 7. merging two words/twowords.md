https://leetcode.com/problems/merge-strings-alternately/description/?envType=study-plan-v2&envId=leetcode-75

Você recebe duas strings, word1 e word2. Combine as strings adicionando letras em ordem alternada, começando com word1. Se uma string for mais longa que a outra, anexe as letras adicionais ao final da string resultante.

Retorne a string mesclada.

Exemplo 1:

Entrada: palavra1 = "abc", palavra2 = "pqr"
 Saída: "apbqcr"
 Explicação:  A string resultante será mesclada da seguinte forma: 
palavra1: abc 
palavra2: pqr 
mesclada: apbqcr
Exemplo 2:

Entrada: palavra1 = "ab", palavra2 = "pqrs"
 Saída: "apbqrs"
 Explicação:  Observe que, como a palavra2 é mais longa, "rs" é adicionado ao final. 
palavra1: ab 
palavra2: pqrs 
mescladas: apbqrs
Exemplo 3:

Entrada: palavra1 = "abcd", palavra2 = "pq"
 Saída: "apbqcd"
 Explicação:  Observe que, como a palavra1 é mais longa, "cd" é adicionado ao final. 
palavra1: abcd 
palavra2: pq 
mescladas: apbqcd
 

Restrições:

1 <= word1.length, word2.length <= 100
word1e word2são compostas por letras minúsculas do alfabeto inglês.