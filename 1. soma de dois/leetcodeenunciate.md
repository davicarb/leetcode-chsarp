LEETCODE PROBLEM LINK: https://leetcode.com/problems/two-sum/description/

Dado um array de inteiros nums e um inteiro target, retorne os índices dos dois números de forma que a soma deles seja igual a target .

Você pode assumir que cada entrada terá exatamente uma solução e que não poderá usar o mesmo elemento duas vezes.

Você pode retornar a resposta em qualquer ordem.

Exemplo 1:

Entrada: nums = [2,7,11,15], target = 9
 Saída: [0,1]
 Explicação: Como nums[0] + nums[1] == 9, retornamos [0, 1].
Exemplo 2:

Entrada: nums = [3,2,4], target = 6
 Saída: [1,2]
Exemplo 3:

Entrada: nums = [3,3], target = 6
 Saída: [0,1]
 

Restrições:

2 <= nums.length <= 104
-109 <= nums[i] <= 109
-109 <= target <= 109
Só existe uma resposta válida.
 

Pergunta complementar:  Você consegue pensar em um algoritmo com complexidade de tempo menor que O(n)?O(n2) 