# Especificações do Projeto

O problema que se busca resolver com este projeto é o gerenciamento de condomínio, sanando os problemas concernente a portaria, marcação da área de lazer e tudo é necessário para trazer harmonia, confiabilidade, agilidade e imparcialidade.
Objetivos
O objetivo geral deste trabalho é a criação de um portal de gestão de condomínio que apresente ferramentas de fácil uso e que permita o acesso dos condôminos a tudo que é pertinente ao seu apartamento.

Como objetivos específicos, podemos ressaltar:
Fornecer funcionalidades que permitam interagir com a permissão de entrada ao apartamento.
Agendamento a área de lazer, tais como churrasqueira.
Permitir a criação de abertura de chamado concernente a manutenção do apartamento.

## Personas

 **<h3 align="center" >Adriano Ramos</h3 >**
 
 <img align="left" width="180px" height="190px" style="margin:-5px 1em 0 auto" src="img/persona1.png"> **Biografia**: Meu nome é Adriano Ramos, tenho 29 anos e moro sozinho em São Paulo.

**Objetivo**:
Gostaria de uma maior organização nos espaços gourmet do condomínio, para usar a área de churrasco nos finais de semana com meus amigos, sem ter conflitos com outros moradores.

**Frustrações**:
Sinto que o condomínio anda bem desorganizado, isso me deixa insastifeito e tem gerado atrito entre os moradores.

<br />         

**<h3 align="center" >Helena Fernandes</h3 >**
 
 <img align="left" width="180px" height="190px" style="margin:-5px 1em 0 auto" src="img/persona2.jpg"> **Biografia**: Meu nome é Helena, tenho 46 anos e sou mãe solteira.

**Objetivo**:
Quero poder usufruir dos espaços gourmet com meus filhos.

**Frustrações**:
Por conta da desorganização do condomínio os espaços gourmet, piscina, área de churrasqueira, salão de jogos, tenho tido problemas para desfrutar desses espaços com meus filhos, as reservas dos locais raramente estão corretas, é bem comum ter conflitos nas reservas, passo pouco tempo com eles e gostaria de ter certeza que vou poder ter um tempo de lazer a sós com eles. 
<br />         
 
**<h3 align="center" >Firmino Gonçalves</h3 >**
 
 <img align="left" width="180px" height="190px" style="margin:-5px 1em 0 auto" src="img/persona3.jpg"> **Biografia**: Meu nome é Firmino Gonçalves, tenho 56 anos e sou síndico de um grande condomínio na zona sul de São Paulo.

**Objetivo**:
Poder fazer melhor meu trabalho, organizar melhor os espaços gourmet de forma a satisfazer todos os moradores do condomínio.

**Frustrações**:
Falta de uma sistema simples e eficiente para organizar o condomínio, muitos moradores reclamam de conflitos nas reservas dos espaços gourmet, muitas vezes o local já está sendo usado enquanto era reserva de outra pessoa.Por conta do condomío ser bem grande, um grande número de moradores faz uso regular dos espaços gourmet e tenho tido dificuldades nessa questão da organização, um sistema eficiente realmente faz falta.
 
<br />         

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Usuário do sistema  | Registrar minhas tarefas           | Não esquecer de fazê-las               |
|Administrador       | Alterar permissões                 | Permitir que possam administrar contas |

Apresente aqui as histórias de usuário que são relevantes para o projeto de sua solução. As Histórias de Usuário consistem em uma ferramenta poderosa para a compreensão e elicitação dos requisitos funcionais e não funcionais da sua aplicação. Se possível, agrupe as histórias de usuário por contexto, para facilitar consultas recorrentes à essa parte do documento.

> **Links Úteis**:
> - [Histórias de usuários com exemplos e template](https://www.atlassian.com/br/agile/project-management/user-stories)
> - [Como escrever boas histórias de usuário (User Stories)](https://medium.com/vertice/como-escrever-boas-users-stories-hist%C3%B3rias-de-usu%C3%A1rios-b29c75043fac)
> - [User Stories: requisitos que humanos entendem](https://www.luiztools.com.br/post/user-stories-descricao-de-requisitos-que-humanos-entendem/)
> - [Histórias de Usuários: mais exemplos](https://www.reqview.com/doc/user-stories-example.html)
> - [9 Common User Story Mistakes](https://airfocus.com/blog/user-story-mistakes/)

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| Permitir que o usuário cadastre tarefas | ALTA | 
|RF-002| Emitir um relatório de tarefas no mês   | MÉDIA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O sistema deve ser responsivo para rodar em um dispositivos móvel | MÉDIA | 
|RNF-002| Deve processar requisições do usuário em no máximo 3s |  BAIXA | 

Com base nas Histórias de Usuário, enumere os requisitos da sua solução. Classifique esses requisitos em dois grupos:

- [Requisitos Funcionais
 (RF)](https://pt.wikipedia.org/wiki/Requisito_funcional):
 correspondem a uma funcionalidade que deve estar presente na
  plataforma (ex: cadastro de usuário).
- [Requisitos Não Funcionais
  (RNF)](https://pt.wikipedia.org/wiki/Requisito_n%C3%A3o_funcional):
  correspondem a uma característica técnica, seja de usabilidade,
  desempenho, confiabilidade, segurança ou outro (ex: suporte a
  dispositivos iOS e Android).
Lembre-se que cada requisito deve corresponder à uma e somente uma
característica alvo da sua solução. Além disso, certifique-se de que
todos os aspectos capturados nas Histórias de Usuário foram cobertos.

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| Não pode ser desenvolvido um módulo de backend        |


Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
