https://leetcode.com/problems/roman-to-integer/description/

Os numerais romanos são representados por sete símbolos diferentes:  I, V, X, L, C, De M.

       Valor do símbolo
Eu 1
V 5
X 10
L 50
C 100
D 500
M 1000
Por exemplo,  2é escrito como II em numeral romano, apenas dois uns somados. 12é escrito como  XII, que é simplesmente X + II. O número 27é escrito como XXVII, que é XX + V + II.

Os numerais romanos são geralmente escritos do maior para o menor, da esquerda para a direita. No entanto, o numeral para quatro não é 1. IIIIEm vez disso, o número quatro é escrito como IV4. Como o 1 vem antes do 5, subtraímos 1 do 5, resultando em 4. O mesmo princípio se aplica ao número nove, que é escrito como IX9. Existem seis casos em que a subtração é usada:

Ipode ser colocado antes de V(5) e X(10) para formar 4 e 9. 
Xpode ser colocado antes de L(50) e C(100) para formar 40 e 90. 
Cpode ser colocado antes de D(500) e M(1000) para formar 400 e 900.
Dado um numeral romano, converta-o em um número inteiro.