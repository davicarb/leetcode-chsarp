https://leetcode.com/problems/concatenation-of-array/description/?envType=problem-list-v2&envId=dsa-linear-shoal-array-i

Dado um array de inteiros numsde comprimento n, você deseja criar um array ans de comprimento 2n onde:
ans[i] == nums[i]
ans[i + n] == nums[i]

para 0 <= i < n
( indexado a partir de 0 ).

Especificamente, ans trata-se da concatenação de duas matrizes num.

Retorne o array ans.


Exemplo 1:

Entrada: nums = [1,2,1]
 Saída: [1,2,1,1,2,1]
 Explicação: O array ans é formado da seguinte maneira:
- ans = [nums[0],nums[1],nums[2],nums[0],nums[1],nums[2]]
- ans = [1,2,1,1,2,1]
Exemplo 2:

Entrada: nums = [1,3,2,1]
 Saída: [1,3,2,1,1,3,2,1]
 Explicação: O array ans é formado da seguinte maneira:
- ans = [nums[0],nums[1],nums[2],nums[3],nums[0],nums[1],nums[2],nums[3]]
- ans = [1,3,2,1,1,3,2,1]
 

Restrições:

n == nums.length
1 <= n <= 1000
1 <= nums[i] <= 1000