# Arquitetura da Solução

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>

Definição de como o software é estruturado em termos dos componentes que fazem parte da solução e do ambiente de hospedagem da aplicação.

## Diagrama de Classes

O diagrama de classes ilustra graficamente como será a estrutura do software, e como cada uma das classes da sua estrutura estarão interligadas. Essas classes servem de modelo para materializar os objetos que executarão na memória.

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Classes”.

> - [Diagramas de Classes - Documentação da IBM](https://www.ibm.com/docs/pt-br/rational-soft-arch/9.6.1?topic=diagrams-class)
> - [O que é um diagrama de classe UML? | Lucidchart](https://www.lucidchart.com/pages/pt/o-que-e-diagrama-de-classe-uml)

## Modelo ER (Projeto Conceitual)

![Entidade Relacional](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t8-gestao-de-condominio/assets/116739381/5135f435-6550-4452-847a-d1c6b63a1177)


## Projeto da Base de Dados

## 1. Requisitos do Sistema

O sistema de gerenciamento de condomínios deve ser capaz de lidar com várias funcionalidades essenciais, incluindo:

Controle de Acesso: Registrar informações sobre visitantes, incluindo nome, data de visita, tempo de permanência, morador visitado e outros detalhes relevantes. Além disso, deve permitir o bloqueio ou liberação de acesso conforme necessário.

Perfil de Moradores: Manter perfis completos dos moradores, incluindo informações como nome, foto, dados de contato e registro de avisos.

Reserva de Áreas Comuns: Permitir que os moradores agendem áreas comuns, como churrasqueira, piscina e salão de festas, e forneçam informações sobre a disponibilidade dessas áreas.

Chamados de Manutenção: Oferecer a capacidade de registrar chamados de manutenção, incluindo detalhes do problema, nível de urgência e inclusão de fotos.

## Projeto da Base de Dados

## 1. Requisitos do Sistema

O sistema de gerenciamento de condomínios deve ser capaz de lidar com várias funcionalidades essenciais, incluindo:

Controle de Acesso: Registrar informações sobre visitantes, incluindo nome, data de visita, tempo de permanência, morador visitado e outros detalhes relevantes. Além disso, deve permitir o bloqueio ou liberação de acesso conforme necessário.

Perfil de Moradores: Manter perfis completos dos moradores, incluindo informações como nome, foto, dados de contato e registro de avisos.

Reserva de Áreas Comuns: Permitir que os moradores agendem áreas comuns, como churrasqueira, piscina e salão de festas, e forneçam informações sobre a disponibilidade dessas áreas.

Chamados de Manutenção: Oferecer a capacidade de registrar chamados de manutenção, incluindo detalhes do problema, nível de urgência e inclusão de fotos.

## 2. Modelagem do Banco de Dados

Com base nos requisitos acima, podemos criar as seguintes tabelas:

## Tabela: Moradores

- ID (Chave Primária);
- Nome;
- Foto (Link para a foto do morador);
- Telefone;
- Email.
 
## Tabela: Visitantes

- ID (Chave Primária);
- Nome;
- Data de Visita;
- Tempo de Permanência;
- Morador Visitado (Chave Estrangeira referenciando a tabela de Moradores);
- Detalhes Adicionais.

## Tabela: Registros de Acesso

- ID (Chave Primária);
- Visitante (Chave Estrangeira referenciando a tabela de Visitantes);
- Data e Hora de Entrada;
- Data e Hora de Saída;
- Status de Acesso (Bloqueado ou Liberado).

## Tabela: Áreas Comuns

- ID (Chave Primária);
- Nome da Área (por exemplo, Churrasqueira, Piscina, Salão de Festas);
- Disponibilidade (Indicando se a área está disponível para agendamento).

## Tabela: Reservas de Áreas Comuns

- ID (Chave Primária);
- Área Comum (Chave Estrangeira referenciando a tabela de Áreas Comuns);
- Morador (Chave Estrangeira referenciando a tabela de Moradores);
- Data e Hora de Reserva;
- Status da Reserva (Confirmada, Cancelada, Pendente).

## Tabela: Chamados de Manutenção

- ID (Chave Primária);
- Morador (Chave Estrangeira referenciando a tabela de Moradores);
- Data de Abertura;
- Nível de Urgência;
- Descrição do Problema;
- Fotos (Links para fotos do problema).

## 3. Relações entre Tabelas

A tabela "Visitantes" terá uma relação de muitos para um com a tabela "Moradores", indicando qual morador o visitante está visitando.

A tabela "Registros de Acesso" terá uma relação de muitos para um com a tabela "Visitantes", registrando as entradas e saídas dos visitantes.

A tabela "Reservas de Áreas Comuns" terá relações de muitos para muitos com as tabelas "Moradores" e "Áreas Comuns", permitindo que um morador reserve uma área comum.

A tabela "Chamados de Manutenção" terá uma relação de muitos para um com a tabela "Moradores", registrando os chamados de manutenção associados a um morador específico.

## 4. Interface de Aplicação

O sistema será acessado por meio de uma interface de aplicação web, que permitirá aos moradores, visitantes e administradores interagir com as funcionalidades do sistema de forma intuitiva e responsiva.


## Tecnologias Utilizadas

Descreva aqui qual(is) tecnologias você vai usar para resolver o seu problema, ou seja, implementar a sua solução. Liste todas as tecnologias envolvidas, linguagens a serem utilizadas, serviços web, frameworks, bibliotecas, IDEs de desenvolvimento, e ferramentas.

Apresente também uma figura explicando como as tecnologias estão relacionadas ou como uma interação do usuário com o sistema vai ser conduzida, por onde ela passa até retornar uma resposta ao usuário.

## Hospedagem

Explique como a hospedagem e o lançamento da plataforma foi feita.

> **Links Úteis**:
>
> - [Website com GitHub Pages](https://pages.github.com/)
> - [Programação colaborativa com Repl.it](https://repl.it/)
> - [Getting Started with Heroku](https://devcenter.heroku.com/start)
> - [Publicando Seu Site No Heroku](http://pythonclub.com.br/publicando-seu-hello-world-no-heroku.html)
