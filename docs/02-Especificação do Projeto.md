# Especificações do Projeto

As partes mais importantes para a solução do problema foi produzida como uma mistura de personas fictícias produzidas pelos membros do grupo e também baseadas em necessidades reais de possíveis usuários.

## Personas

As personas levantadas durante o processo de entendimento do problema são apresentadas a seguir: 

Joana Oliveira tem 50 anos, é Professora. Nas horas livres gosta de caminhar a noite, escutando música ou ouvindo algum podcast. Sua maior motivação é transmitir conhecimento e ensinar as pessoas. Suas frutações são o alto risco de furto na região onde mora e a dificuldade com tecnologia. Utiliza muitos aplicativos, alguns deles são: Pinterest, Whatsapp, Aplicativos de bancos.

Guilherme Amaral tem 24 anos, é Digital Influêncier. Gosta de trabalhar com a internet, influênciando pessoas, gravando vídeos e divulgando marcas. Sua maior motivação é Influenciar as Pessoas positivamente e apresentar ao seu público bons produtos testatos e aprovados. Sua frustação é medo do seu smartphone sofrer qualquer dano que impossibilite de exercer seu trabalho. Utiliza muitos aplicativos, alguns deles são: Instagram, YouTube, Whatsapp, Telegram.

Mariana Sousa tem 19 anos, é Estudante Universitária. Gosta de estudar e sair com seus amigos à noite. Sua maior motivação é se formar em Direito. Sua frustação é ter tido seu smartphone de alto valor aquisitivo roubado e usar transporte público. Utiliza muitos aplicativos, alguns deles são: Instagram, TikTok, Whatsapp, Aplicativos de bancos. 


## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Joana Oliveira  | cotar os planos de seguro sem burocracia           | possuo dificuldade com tecnologia               |
|Mariana Sousa       | segurança e tranquilidade                 | pois sei que com o seguro estou protegido e vou ser indenizado |
|Joana Oliveira | proteger meu dinheiro           | devido ao alto valor de compra              |
|Guilherme Amaral     | usar tranquilamente o celular em lugares externos               | porque é minha ferramenta de trabalho |
|Guilherme Amaral | melhor custo na aquisição de um seguro para celular           | a fim de reduzir danos e prejuízos               |
|Guilherme Amaral      | assistência técnica imediata caso o aparelho pare de funcionar              | por ter um respaldo caso aconteça qualquer problema independente do dia/horário |
|Mariana Sousa  | proteger meu smartphone de forma simples e a preço acessível           | porque utilizo o transporte público para me locomover pela cidade e já tive um celular furtado anteriormente               |

## Requisitos

Abaixo as tabelas detalham todos os requisitos funcionais e não funcionais do projeto de seguro para aparelhos celulares.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| A aplicação deve conter e permitir ao usuário a realização de uma cotação de seguro de forma precisa e sem complexidade. | ALTA | 
|RF-002| A aplicação deve permitir que o usuário realize o seu cadastro a partir dos seus dados pessoais e os dados do seu smartphone (ano de fabricação, modelo, marca e tempo de uso).   | ALTA |
|RF-003| A aplicação deve permitir que o usuário acesse sua área do cliente a partir do uso de login e senha. | ALTA | 
|RF-004| A aplicação deve mostrar para usuários logados suas mensalidades a vencer (se houver um plano adquirido). | MÉDIA | 
|RF-005| A aplicação deve entregar a visualização das informações sobre a empresa e sua história ao usuário. | BAIXA | 
|RF-006| A aplicação deve permitir que os usuários cadastrados avaliem a qualidade do serviço prestado. | MÉDIA | 
|RF-007| A aplicação deve mostrar em sua tela inicial alguns tipos de coberturas que a empresa oferece. | BAIXA | 
|RF-008| A aplicação deve permitir ao usuário cadastrado que edite suas informações de cadastro pessoal. | MÉDIA | 
|RF-009| Após a realização da cotação, a aplicação deve direcionar o usuário diretamente para o whatsapp com algum atendente para finalizar a contratação do seguro. | ALTA | 
|RF-010| A aplicação deve mostrar os dados de contato da empresa para solicitação de assistência técnica imediata e transferir o usuário para o atendimento 24 horas (WhatsApp). | ALTA | 
|RF-011| A aplicação deve permitir ao usuário acompanhar o processo de restituição do sinistro. | ALTA | 

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| A aplicação deverá ser responsivo permitindo a visualização em um mobile de forma adequada e compreensiva. | ALTA | 
|RNF-002| A aplicação deve ter bom nível de contraste entre os elementos da tela em conformidade. |  MÉDIA | 
|RNF-003| A aplicação deve ser compatível com os principais navegadores do mercado (Google Chrome, Firefox, Microsoft Edge) |  ALTA | 
|RNF-004| A aplicação não deve revelar nenhuma informação pessoal dos clientes como por exemplo o CPF |  MÉDIA | 
|RNF-005| A aplicação deve processar o calculo da cotação em até 5 segundos |  BAIXA | 
|RNF-006| A aplicação deve ser desenvolvida nas linguagens JavaScript, HTML, CSS. (Front-End) |  ALTA | 

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| A aplicação deverá ser entregue no final do semestre letivo, não podendo extrapolar o mês de novembro. |
|02| A aplicação deve se restringir às tecnologias básicas da Web no Frontend e Backend.       |
|03| A equipe deve utilizar as tecnologias apresentadas. |

## Diagrama de Casos de Uso

O diagrama contempla as principais ligações previstas entre casos de uso e atores e permite detalhar os Requisitos Funcionais identificados na etapa de elicitação. 

![Diagrama de Caso de Uso_V2](https://user-images.githubusercontent.com/90807404/189547452-9f5a2dde-dda6-4c4d-9e46-3f6f8d7fbe84.png)


