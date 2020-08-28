# Depend�ncias

Deve ser instalado o *.net core vers�o 3.1*

# Compilando/Executando

Para compilar basta utilizar o Visual Studio 2019 (vers�o mais recente)

# Testando

Foi adicionado ao projeto a inteface descritiva Swagger, para testar basta executar os endpoints a partir do pr�prio Swagger.

# Premissas de implementa��o

## Persist�ncia de dados utilizando arquivos e n�o banco

A implementa��o de persist�ncia dos dados por arquivo � mais do que suficiente para suportar a demanda, n�o sendo
necess�rio implementa��o de camada de banco.

## Implementa��o do Sagger

Para facilitar o teste dos endpoints na implementa��o, o Sagger � satisfat�rio para esta tarefa.