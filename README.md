
# Nome

## < Sistema Gerenciador de Disciplinas para Discentes (Shortcut) >

### RESUMO/JUSTIFICATIVA

  Ao reprovar em disciplinas, estar em uma grande divergente da atual ou mesmo questões pessoais não conseguir matricular-se em disciplinas correspondentes a seu período letivo, infelizmente por não ser regular na grade vigente acabam tendo grande dificuldade em qual disciplina escolher e qual terá mais benefício pegando o quanto antes, fazendo escolhas não tão felizes e passando mais tempo para cursar todas as disciplinas, além de incertezas e estresse. 
  
### OBJETIVOS

  Com o desenvolvimento do sistema Sistemas Gerenciador de disciplinas para discentes (Shortcut), os discentes poderão se matricular com maior certeza nas disciplinas, já que o aplicativo gerou as disciplinas mais adequadas para o aluno cursar no momento. O sistema decide baseado nos pré requisitos de cada disciplina, na grade curricular do curso no semestre, nas restrições do aluno e quais ele já realizou.

## FUNCIONALIDADES

- [x] Apresentar os requisitos funcionais
- [x] Apresentar os requisitos não-funcionais
- [x] Indicar os membros da equipe
- [x] Exibir repositório e dicas que são comuns

### REQUISITOS FUNCIONAIS

- Perfis de usuário
- Cadastro de usuário
- Cadastro de Instituição
- Cadastro de curso
- Cadastro de disciplina
- Importação de disciplinas
- Cadastro de turma
- Cadastro de período letivo
- Cadstro de período curricular
- Cadastro de restrições
- Cadastro de disciplinas cursadas
- Listagem de disciplinas cursadas
- Apresentação de tempo de permanência experado no curso

### REQUISITOS FUNCIONAIS FUTUROS

- Importação de turmas ofertadas
- Listagem de turmas ofertadas 
- Geração de Horário
- Apresentação de disciplinas alternativas
- Geração de pdf de horários 
- Geração de alternativas de horários
- Listagem de usuário por tempo mínimo de permanência
- Contagem de usuários por determinada disciplinas

### REQUISITOS NÃO FUNCIONAIS

- Utilizar .NET CORE 3.1+
- Utilizar [EF Core](https://docs.microsoft.com/pt-br/ef/core/) para manipução de dados
- Possuir, pelo menos um, relacionamento 1:1 (um para um)
- Possuir, pelo menos um, relacionamento 1:N (um para muitos)
- Possuir, pelo menos um, relacionamento M:N (muito para muitos)
- Fazer um programa, em C# com Entity Framework, para realizar carga inicial dos dados

## Membros da equipe (Até 3 pessoas. Identificar o líder)

- Rayssa Silva Andrade (líder)
- Eduardo Andrade Santana 
- Diogenes Araujo de Oliveira Junior

## DER

<img alt="DER" src="https://i.postimg.cc/YjKRh6Ld/der.jpg"/>

## PROTÓTIPO

<img alt="PROTOTIPO" src="https://i.postimg.cc/k4h3TrXd/19.png"/>
<img alt="PROTOTIPO" src="https://i.postimg.cc/tJZ0frYn/20.png"/>
<img alt="PROTOTIPO" src="https://i.postimg.cc/NF3hw1HJ/21.png"/>

## Dicas, repositórios e materiais úteis

- https://github.com/CBSIIFSLagarto/2021_1_web2
- Documentação sobre [Diretrizes de design de estrutura] 
- [A collection of awesome **.NET CORE** libraries, tools, frameworks, and software](https://github.com/thangchung/awesome-dotnet-core)
- [A collection of awesome **.NET** libraries, tools, frameworks, and software](https://github.com/quozd/awesome-dotnet) - Referência, pois é para .NET e não .NET CORE

### Gerenciar seu trabalho no GitHub

O github contém várias ferramentas que permitem o gerenciamento projeto, promovendo entre outros recursos a rastreabilidade e o gerenciamento das atividades. Saiba mais nos links abaixo.

- [Gerenciar seu trabalho no GitHub](https://docs.github.com/pt/free-pro-team@latest/github/managing-your-work-on-github)
- [Closing issues using keywords](https://docs.github.com/en/enterprise/2.16/user/github/managing-your-work-on-github/closing-issues-using-keywords)
- [Vinculando uma pull request a um problema](https://docs.github.com/pt/free-pro-team@latest/github/managing-your-work-on-github/linking-a-pull-request-to-an-issue)
- [GitHub: How can I close the two issues with commit message?](https://stackoverflow.com/questions/60027222/github-how-can-i-close-the-two-issues-with-commit-message) 

## Prazo

Data | Descrição
:---:|:---
14/01/2021 | Definição do projeto a ser executado
??/02/2020 | Modelo implementado no EF Core
??/02/2020 | Aplicação que permite a carga incial/teste do modelo implementado com EF Core
??/03/2020 | Entrega de [protótipos](prototipos/prototipos.md) das principais telas do sistema proposto (e que atendam aos itens descritos no REQUISITOS NÃO FUNCIONAIS)

## Project status
Este projeto é um template para a definição da avaliação da disciplina programação web 2, do período de 2021.1 (aulas remotas), do IFS


[Diretrizes de design de estrutura]: https://docs.microsoft.com/pt-br/dotnet/standard/design-guidelines/
