# GERADOR DE TESTES

## Projeto
Desenvolvido durante o curso Fullstack da Academia do Programador 2024

## Descrição
Mariana prepara diversos exercícios para suas filhas que estão na 1ª e 2ª séries. Ela gostaria de informatizar esses exercícios, para gerar testes aleatórios.
Cada teste  gerado deve ser guardado (acompanhado de suas questões), com a indicação de sua  data de geração. Na geração de um teste, é preciso informar o número de questões
desejadas e qual a disciplina pertence ao teste. Para cada disciplina, cadastra-se: uma lista de questões objetivas, e matérias pertencentes.
O gabarito também é  cadastrado a fim de facilitar a correção do teste. Cada matéria faz parte de uma única  disciplina. A série está ligada à matéria. 

## Requisitos Funcionais

### 1 - Módulo de Disciplinas

#### Requisito 1.1: Cadastrar Novas Disciplinas
Critérios:
- O registro de disciplina é composto por nome;
- O campo nome é obrigatório;
- Não pode registrar uma disciplina com o mesmo nome;
- A disciplina deve armazenar informações sobre as matérias que serão relacionadas à ela posteriormente.

Protótipo:


![Captura de tela 2024-06-13 005948](https://github.com/MorfosCode/GerenciadorTeste/assets/163341752/7531dd8e-7279-4ccc-86e0-7790cf697e4e)

#### Requisito 1.2: Editar Disciplinas
Critérios:
- Os critérios de validação são os mesmos do Requisito 1.1
#### Requisito 1.3: Excluir Disciplinas
Critérios:
- Não deve ser possível excluir disciplinas com matérias e testes relacionados.
#### Requisito 1.4: Visualizar Todas as Disciplinas
Critérios:
- Deve exibir: Id e Nome.

### 2 - Módulo de Matérias
#### Requisito 2.1: Cadastrar Matérias
Critérios:
- O registro de matéria é composto por nome, disciplina e série;
- Todos os campos são obrigatórios;
- Não pode registrar uma matéria com o mesmo nome.

Protótipos:


![Captura de tela 2024-06-13 011520](https://github.com/MorfosCode/GerenciadorTeste/assets/163341752/1fd61898-2ed9-403c-b631-c99d51d90317)

#### Requisito 2.2: Editar Matérias
Critérios:
- Os critérios de validação são os mesmos do Requisito 2.1.
#### Requisito 2.3: Excluir Matérias
Critérios:
- Não deve ser possível excluir matérias sendo utilizadas em questões.
#### Requisito 2.4: Visualizar Todas as Matérias
Critérios:
- Deve exibir: Id, Nome, Disciplina e Série.

### 3 - Módulo de Questões
#### Requisito 3.1: Cadastrar Questões
Critérios:
- O registro de questão é composto por matéria, enunciado e alternativas;
- Todos os campos são obrigatórios;
- Cada questão deve ter um mínimo e máximo de alternativas (máximo sugerido: 4)

Protótipo:


![Captura de tela 2024-06-13 011744](https://github.com/MorfosCode/GerenciadorTeste/assets/163341752/0f1c1672-0bfd-4c14-aa91-8012817efc70)

#### Requisito 3.2: Editar Questões
Critérios:
- Os critérios de validação são os mesmos do Requisito 3.1.
#### Requisito 3.3: Excluir Questões
Critérios:
- Não deve ser possível excluir uma questão relacionada a um teste;
#### Requisito 3.5: Visualizar Todas as Questões
Critérios:
- Deve exibir: Id, Enunciado, Matéria e Resposta Correta.
#### Requisito 3.6: Configurar Alternativas da Questão
Critérios:
- Deve permitir adicionar alternativas à questão;
- Deve permitir remover alternativas à questão;
- Não permitir o cadastro de questões sem uma alternativa correta;
- Não deve permitir o cadastro de mais de uma alternativa correta;
- No mínimo duas alternativas devem ser configuradas.
### 4 - Módulo de Testes
#### Requisito 4.1: Gerar Testes
Critérios:
- O registro de teste é composto por título, disciplina, matéria*, série e quantidade de questões;
- Deve ser informado a quantidade de questões que deverão ser geradas;
- Não pode registrar um teste com o mesmo nome;
- A quantidade de questões informada deve ser menor ou igual a quantidade de questões cadastradas;
- As matérias devem ser carregadas a partir da disciplina selecionada;
- Não deve permitir selecionar uma matéria que não pertença a disciplina selecionada;
- Caso a disciplina seja alterada, o campo matéria deve ficar em branco;
- Caso seja “Prova de Recuperação” deve considerar as questões de todas as matérias da disciplina selecionada;
- Todos os campos são obrigatórios;
- As questões devem ser selecionadas de forma aleatória.

Protótipo:


![Captura de tela 2024-06-13 011947](https://github.com/MorfosCode/GerenciadorTeste/assets/163341752/ed139dc8-9061-4d7e-9f24-7adb1835e2e0)

#### Requisito 4.2: Duplicar Testes
Critérios:
- Deve permitir duplicar testes;
- Na duplicação do teste o título, disciplina, quantidade de questões, série, prova de recuperação e matéria deverão vir preenchidos;
- Não pode duplicar um teste com o mesmo nome;
- Na duplicação do teste, as questões devem vir em branco.

Protótipo:


![Captura de tela 2024-06-13 012054](https://github.com/MorfosCode/GerenciadorTeste/assets/163341752/6acb26b1-213c-471f-a0f8-5c5f7335dccf)

#### Requisito 4.3: Excluir Testes
Critérios:
- Deve permitir excluir testes existentes.
#### Requisito 4.4: Visualizar Todos os Testes
Critérios:
- Deve exibir: Id, Título, Disciplina, Matéria (ou informar se é recuperação) e Quantidade de Questões.
#### Requisito 4.5: Visualizar Detalhes sobre Testes
Critérios:
- Deve ser possível visualizar os testes individualmente, com informações detalhadas incluindo as questões.

Protótipo:


![Captura de tela 2024-06-13 012243](https://github.com/MorfosCode/GerenciadorTeste/assets/163341752/159d1df3-1e08-4546-9f98-e047326fc749)

#### Requisito 4.6: Gerar PDF dos Testes
Critérios:
- O arquivo PDF do Teste deve apresentar: Título, Disciplina, Matéria, as questões e suas as alternativas.
#### Requisito 4.7: Gerar PDF do Gabarito dos Testes
Critérios:
- O arquivo PDF do Gabarito do Teste deve apresentar: Título, Disciplina, Matéria, as questões e suas alternativas (com a alternativa correta assinalada).
