# Dependências

Deve ser instalado o *.net core versão 3.1*

# Compilando/Executando

Para compilar basta utilizar o Visual Studio 2019 (versão mais recente)

# Testando

Foi adicionado ao projeto a inteface descritiva Swagger, para testar basta executar os endpoints a partir do próprio Swagger.

# Premissas de implementação

## Persistência de dados utilizando arquivos e não banco

A implementação de persistência dos dados por arquivo é mais do que suficiente para suportar a demanda, não sendo
necessário implementação de camada de banco.

## Implementação do Sagger

Para facilitar o teste dos endpoints na implementação, o Sagger é satisfatório para esta tarefa.