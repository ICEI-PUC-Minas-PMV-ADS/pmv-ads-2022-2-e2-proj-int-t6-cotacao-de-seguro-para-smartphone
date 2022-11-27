# Plano de Testes de Software

Os requisitos para realização dos testes de software são:
- Site publicado na Internet
- Navegador da Internet - Chrome, Firefox ou Edge
- Conectividade de Internet para acesso às plataformas (APISs)

Os testes funcionais a serem realizados no aplicativo são descritos a seguir.

| **Caso de Teste** 	| **CT-01 - Realizar login** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-02 - A aplicação deve permitir que o usuário realize o seu cadastro a partir dos seus dados pessoais e os dados do seu smartphone (ano de fabricação, modelo, marca e tempo de uso).<br>RF-03 - A aplicação deve permitir que o usuário acesse sua área do cliente a partir do uso de login e senha.<br>RF-08- A aplicação deve permitir ao usuário cadastrado que edite suas informações de cadastro pessoal.<br>RF-14- A aplicação deve permitir ao usuário realizar a recuperação da senha de acesso.|
| Objetivo do Teste 	| Permitir que o usuário acesse a área do cliente com as informações de cadastros. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site<br> - Realizar cadastro do usuário e cadastro do smartphone <br> - Realizar o login com os dados cadastrados.<br> - Editar os dados de cadastro.<br>|
|Critério de Êxito | - Usuário conseguir realizar o cadastro no site, efetuar o login, editar o respectivo cadastro e recuperar senha de acesso. |
|  	|  	|

| **Caso de Teste** 	| **CT-02 - Realizar cotação do seguro** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-01 - A aplicação deve conter e permitir ao usuário a realização de uma cotação de seguro de forma precisa e sem complexidade. <br>RF-07- A aplicação deve mostrar em sua tela inicial alguns tipos de coberturas que a empresa oferece.<br>RF-09- Após a realização da cotação, o usuário poderá optar por ser direcionado para o whatsapp com algum atendente para finalizar a contratação do seguro.|
| Objetivo do Teste 	| Apresentar para o usuário a cotação do seguro feita. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site<br> - Escolher um dos planos oferecidos<br> - Cotar |
|Critério de Êxito | - Apresentar para o usuário a cotação do seguro feita com base no modelo do smartphone e as opções de planos de seguro oferecidos, permitindo que ele opte por ser direcionado para o Whatsapp a fim de realizar a contratação do seguro.  |
|  	|  	|
| **Caso de Teste**	| **CT-03 - Funcionalidades área do cliente**	|
|Requisito Associado | RF-04 - A aplicação deve mostrar para usuários logados suas mensalidades a vencer (se houver um plano adquirido).<br>RF-06- A aplicação deve permitir que os usuários cadastrados avaliem a qualidade do serviço prestado.<br>RF-10- A aplicação deve permitir ao usuário cancelar o seguro.<br>RF-12- A aplicação deve permitir ao usuário comunicar o sinistro, seja para reparo ou reembolso.<br>RF-13- A aplicação deve permitir ao usuário acompanhar o processo de restituição do sinistro.<br> |
| Objetivo do Teste 	| Acessar a área do cliente a fim de visualizar as mensalidades, pagar seguro, solicitar cancelamento, comunicar sinistro e avaliar o serviço prestado.  |
| Passos 	| - Acessar o Navegador<br>- Informar o endereço do site<br>- Efetuar login com usuário e senha<br>- Consultar as mensalidades<br>- Realizar o pagamento da mensalidade<br>- Comunicar e acompanhar sinistro<br>- Solicitar o cancelamento do seguro<br>- Avaliar serviço<br>|
|Critério de Êxito | Permitir ao usuário realizar o login no site para consultar suas mensalidades, realizar o pagamento do seguro, comunicar e acompanhar o sinistro, solicitar o cancelamento do plano adquirido e avaliar o serviço prestado. |
|  	|  	|
| **Caso de Teste**	| **CT-04 - Consultar informações da seguradora.**	|
|Requisito Associado | RF-05 - A aplicação deve entregar a visualização das informações sobre a empresa e sua história ao usuário.<br>RF-11- A aplicação deve mostrar os dados de contato da empresa para solicitação de assistência técnica imediata e transferir o usuário para o atendimento 24 horas (WhatsApp)|
| Objetivo do Teste 	| Permitir que seja visualizado informações correspondentes a empresa. 
| Passos 	|- Acessar o Navegador<br>- Informar o endereço do site<br>- Apresentar na tela inicial sobre a empresa e história de usuários. <br>- Apresentar os dados para contato|
|Critério de Êxito | Apresentar para o usuário informações sobre a empresa e histórias de usuários, dados para contato e direcionamento para o WhatsApp a fim de falar com um atendente.  |
