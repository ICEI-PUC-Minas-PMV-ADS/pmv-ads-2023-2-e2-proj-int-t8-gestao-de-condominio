# Plano de Testes de Software

## Tela de registro
| Caso de Teste 	| CT-01 – Cadastrar perfil 	|
| --------------- | -------------------------- |
|	Requisito Associado 	| RF-001 - O sistema deve permitir o gerenciamento de logins. |
| Objetivo do Teste 	| Verificar se o sistema permite a criação de novas contas. |
| Passo 1	| Acessar o site hospedado pelo navegador. |
| Passo 2 | Entrar na tela de registro de contas pelo botão "Registrar". |
| Passo 3 | Inserir dados válidos em todos os campos necessários. |
| Passo 4 | Clicar no botão "Cadastrar" |
| Critério de Êxito | O cadastro foi realizado com sucesso, e a Home Page é carregada para o usuário. |

| Caso de Teste 	| CT-02 – Cadastrar perfil (Sem sucesso)	|
| --------------- | -------------------------- |
|	Requisito Associado 	| RF-001 - O sistema deve permitir o gerenciamento de logins. |
| Objetivo do Teste 	| Verificar se o sistema permite a criação de novas contas. |
| Passo 1	| Acessar o site hospedado pelo navegador. |
| Passo 2 | Entrar na tela de registro de contas pelo botão "Registrar". |
| Passo 3 | Inserir dados inválidos em todos os campos e/ou deixar de inserir dados em algum dos campos. |
| Passo 4 | Clicar no botão "Cadastrar" |
| Critério de Êxito | O sistema detecta que há campos vazios e/ou dados inválidos em algum dos campos e nega o cadastro de uma nova conta. |

## Tela de Login

| Caso de Teste 	| CT-03 - Efetuar o login de uma conta |
| --------------- | -------------------------- |
|	Requisito Associado 	| RF-001 - O sistema deve permitir o gerenciamento de logins. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login. |
| Passo 1	| Acessar o site hospedado pelo navegador. |
| Passo 2 | Entrar na tela de login de contas pelo botão "Entrar" |
| Passo 3 | Inserir todos os dados previamente inseridos na criação da conta. |
| Passo 4 | Clicar no botão "Entrar" |
| Critério de Êxito | O usuário consegue entrar em sua conta com sucesso, e a Home Page é carregada para o usuário. |

| Caso de Teste 	| CT-04 - Efetuar o login de uma conta (Sem sucesso) |
| --------------- | -------------------------- |
|	Requisito Associado 	| RF-001 - O sistema deve permitir o gerenciamento de logins. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login. |
| Passo 1	| Acessar o site hospedado pelo navegador. |
| Passo 2 | Entrar na tela de login de contas pelo botão "Entrar" |
| Passo 3 | Inserir dados inválidos em todos os campos e/ou deixar de inserir dados em algum dos campos. |
| Passo 4 | Clicar no botão "Entrar" |
| Critério de Êxito | O sistema detecta que há campos vazios e/ou dados inválidos em algum dos campos e nega o login em uma conta.|

## Tela de Registro de Reservas

| Caso de Teste 	| CT-05 - Reservar área de lazer |
| --------------- | -------------------------- |
|	Requisito Associado 	| RF-006 	A aplicação deve gerenciar reservas de áreas de lazer; RF-005 -	A aplicação deve gerenciar áreas de lazer. |
| Objetivo do Teste 	| Verificar se o sistema registra reservas das áreas de lazer. |
| Passo 1	| Acessar a Home Page. |
| Passo 2 | Acessar o menu de reservas pelo botão "Reservas". |
| Passo 3 | Acessar o meunu para efetuar reservas pelo botão "Nova reserva".|
| Passo 3 | Especificar todas os dados necessários para a reserva da área. |
| Passo 4 | Clicar no botão "Efetuar reserva" | 
| Critério de Êxito | É registrado a reserva, e esta é demonstrada para todos usuários do mesmo apartamento que aquela área foi reservada. |

 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
