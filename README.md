# Proposta

  Criar um meio do pecuarista fazer uma projeção do processo que se chama Pastejo
Rotacionado, que basicamente é: permitir movimentar o gado entre áreas diferentes da fazenda
que geram ganho de peso diferenciados aos animais.

# Ambiente
  Necessário instalar o SDK .NET 5.0 e utilizar uma IDE compatível de preferência o Visual Studio que já vem com o ambiente pré-configurado.

# Tecnologias utilizadas
  Foi criado utilizando Visual Studio e a linguagem C#, todas as bibliotecas são padrões do core da linguagem.

# Como funciona
  O usuário pode cadastrar o brinco do boi e o nome da área e os nomes são únicos, uma mensagem de erro irá aparecer se tentar adicionar um já existente.

  O usuário também poderá listar todos os bois cadastrados e poderá filtrar somente os que já estiverem dentro das áreas, além de poder consultar o boi individualmente utilizando o nome do brinco como parâmetro.

  Para mudar ou cadastrar o boi em alguma área é necessário informar um nome de brinco e de área já existente, se não irá retornar uma mensagem de erro indicando que o valor é
inválido.

# Adendos

  Os métodos foram inseridos dentro do main, uma possível melhoria futura seria colocar o padrão ViewModel para que as duas listas possam compartilhar o mesmo valor e inserir os métodos nas suas respectivas classes, devido a um bug não foi possível implementar essa etapa.

# Conclusão

  O desafio foi bem interessante e serviu como um grande aprendizado, desde já agradeço.






