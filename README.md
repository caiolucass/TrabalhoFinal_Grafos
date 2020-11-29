<h2 align="center">:book: PONTIFÍCIA UNIVERSIDADE CATÓLICA DE MINAS GERAIS:book:</h2>
<h3 align="center">Curso de Graduação em Sistemas De Informação </h3>
<h5 align="center">Integrantes: Caio Lucas Ferreira dos Santos / Wernen Rodrigues Maciel</h5>
<h3 align="center">Trabalho Prático interdisciplinar de Algoritmos em Grafos – 5º Período </h3>
 
 <h3 align=>1. Introdução</h3>
  <h4>Vértices: Professores e Disciplinas Arestas: Horários</h4>
  
Esse trabalho apresentado pela matéria de "Algoritmos em grafos" tem como objetivo utilizando a teoria de grafos aplicada durante o semestre, a solução do problema de um Sistema de Gestão de Horários de disciplinas entre professores, horários as disciplinas. Alocando assim, os
professores às suas disciplinas de forma a maximizar o número de disciplinas em paralelo sem que haja qualquer conflito entre horários, professores e disciplinas. 

### 2. Problema 

Considere que você seja o responsável para montar o horário do curso de Sistemas de Informação –São  Gabriel(noite) da  PUC  Minas.  O  problema  consiste  em  alocar  os professores às suas disciplinas de forma a maximizar o número de disciplinas em paralelo. Considere  que  alguns  professores  possam  ministrar  diversas  disciplinas,  e  que  por  dia, possamos ter 2horários de alocação.Além disso, lembre-se que disciplinas do mesmo período não podem ser alocadaspara o mesmo horário e que uma disciplina só pode ser ministrada por um professor. 

### 4. Desenvolvimento

Algoritmo Kruskal: Foi selecionado o algoritmo de kruskal, para descobrir a forma mais eficiente de conexão entre professores e as disciplinas, para assim podermos encontrar a AGM(Árvore Geradora Mínima) do grafo. Encontrando assim as conexões necessárias para que o grafo esteja conexo utilizando a menor quantidade de conexões possível.

### 5. Solução adotada / Heurística

Este algoritmo foi desenvolvido seguindo as heurística: 
- 1°: Ordenar as arestas por custo em ordem crescente.
- 2°: Salvar o resultado da ordenação utilizando um Arraylist.
- 3°: Selecionar a primeira aresta da estrutura (grafo) montado.
- 4°: Verificar se cada um dos vértices conectados pelo vértice adjacente não esteja na solução adotada. 
- 5°: Adicionar a aresta na solução adotada.
- 6°: Retornar ao 2° passo, repetindo assim "n-1 vezes". Com isso conseguimos obter a AGM(Árvore Geradora Míńima), com n vértices e n-1 arestas, selecionando assim o conjunto de arestas com o menor custo.

### 6. Resultados

### 7. Conclusão
Concluímos que algoritmo em grafos são muito importantes para solucionar problemas que constituem alocação de dados, e problemas de rotas no mundo real. Exemplos
bem aplicados de grafos são o Google maps, IFood, Uber e entre outras ferramentas.

