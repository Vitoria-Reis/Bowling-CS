# Bowling-CS

<h5> Para que serve a aplicacao ?
  
O jogo de boliche é composto de dez lances, em cada um deles, todo jogador tem direito a dois arremessos por vez, a menos que consiga derrubar todos os pinos na primeira jogada, conseguindo um strike. Se conseguir derrubar os dez pinos em duas jogadas ele consegue um Spare. Caso ele nao consiga derrubar os dez pinos nas duas rodadas do frame, e somada a pontuacao feita nas duas jogadas.

# Cada frame pontuaremos da seguinte maneira:

Se strike -> 10 + bola A + bola B (Proximas bolas jogadas)

Se spare -> 2 + 8 (2 jogadas na rodada) + bola A (Proximas bolas jogadas)

Se frame sem derrubar os 10 pinos -> 3 + 5 (Soma da rodada do frame)

Se strike no Frame 10
mais 2 Frames de bonus
Frame 11 + Frame 12

Se spare no Frame 10
mais 1 Frame de bonus
Frame 11 <h5>
  
  # To do list 
  
  -[X] Criar um arquivo Readme.md
  
  -[X] Logica para calcular as pontuacoes
  
  -[X] Logica para pontuacao extra
  
  -[ ] Interface Web
