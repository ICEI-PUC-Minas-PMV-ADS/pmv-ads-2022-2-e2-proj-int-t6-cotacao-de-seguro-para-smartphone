
# Projeto de Interface

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Documentação de Especificação</a></span>

Visão geral da interação do usuário pelas telas do sistema e protótipo interativo das telas com as funcionalidades que fazem parte do sistema (wireframes).

 Apresente as principais interfaces da plataforma. Discuta como ela foi elaborada de forma a atender os requisitos funcionais, não funcionais e histórias de usuário abordados nas <a href="2-Especificação do Projeto.md"> Documentação de Especificação</a>.

## Diagrama de Fluxo

O diagrama apresenta o estudo do fluxo de interação do usuário com o sistema interativo e  muitas vezes sem a necessidade do desenho do design das telas da interface. Isso permite que o design das interações seja bem planejado e gere impacto na qualidade no design do wireframe interativo que será desenvolvido logo em seguida.

O diagrama de fluxo pode ser desenvolvido com “boxes” que possuem internamente a indicação dos principais elementos de interface - tais como menus e acessos - e funcionalidades, tais como editar, pesquisar, filtrar, configurar - e a conexão entre esses boxes a partir do processo de interação. Você pode ver mais explicações e exemplos https://www.lucidchart.com/blog/how-to-make-a-user-flow-diagram.

![Exemplo de Diagrama de Fluxo](img/diagramafluxo2.jpg)

As referências abaixo irão auxiliá-lo na geração do artefato “Diagramas de Fluxo”.

> **Links Úteis**:
> - [Fluxograma online: seis sites para fazer gráfico sem instalar nada | Produtividade | TechTudo](https://www.techtudo.com.br/listas/2019/03/fluxograma-online-seis-sites-para-fazer-grafico-sem-instalar-nada.ghtml)

## Wireframes

### **Tela - Home**

A tela home é onde vai se concentrar a maior parte das funcionalidades da aplicação web. Pensando em um novo cliente, no topo da página teremos um cabeçalho com o logo da empresa, direcionamento para outras telas e uma barra de navegação que direciona as demais páginas do site.

![image](docs/imgs-presentation/home.png)

> **Body da Home Page - Breve apresentação da empresa**

- Nessa primeira parte faremos uma breve apresentação da empresa com imagens e pouco texto, focando em que tipos de soluções a empresa de proteção fornece, as   facilidades de acesso e adesão, do suporte, da qualidade e do foco no cliente. Em outras palavras, seria um cartão de visitas e convite à adesão da pessoa que está olhando.

**Página - Planos de proteção**

É possível ver os planos que podem ser adquiridos pelo usuário.

![image](docs/imgs-presentation/planos.png)


> **Opção de proteção para o seu smartphone**
- Furto
- Roubo
- Vidros trincados
- Quebra em geral

**Página - Cotação**

Ao clicar no botão abrirá um formulário para preenchimento com opções de marcar, para digitar os dados do cliente e de seu aparelho.

![image](docs/imgs-presentation/cotacao.png)

- Botão para cotar: Apartir dos dados fornecidos o sistema vai gerar um valor para o seguro em mensalidade, já com os valores dos opcionais agregados.

- Botão para contratação: Após a cotação o cliente já pode contratar o serviço. (Caso o cliente não esteja logado um pop-up é aberto com a opção de login/cadastro)


**Página - Login/Cadastro**

Pode ser acessada pela barra no cabeçalho da página ou vir através da página de cotação.

![image](docs/imgs-presentation/logincadastro.png)

- Nesta página você tem os campos para logar com email e senha e os campos para realizar um registro no site.
- Após clicar em logar, você é redirecionado para página d cliente.

**Página - Sobre a empresa**

Nessa página terá uma apresentação completa da empresa, contenta visão, missão e valores da mesma.

![image](docs/imgs-presentation/sobre.png)

- Contem alguns botões, mas o principal é o que redireciona para página de avaliações da empresa.

**Página - Avaliações da empresa**

Essa página não terá nenhum componente que o cliente possa interagir (somente um botão redirecionando para pagina para que o mesmo possa fazer uma avaliação dos serviçõs por ele contratado), ela vai ter recortes das avaliações feitas por clientes que já aderiram e utilizaram do serviços fornecidos pela empresa. Essencialmente terá uma foto, um comentário e a nota dada.

![image](docs/imgs-presentation/avaliacoes.png)

**Página - Cliente**

A página do cliente contem algumas opções importantes, como a emissão de boletos, atualização de dados, informações sobre o plano contratado e situação de sinistros. Contem um botão com o redirecionamento para pagina de realização de avaliações sobre o plano contratado.

![image](docs/imgs-presentation/userlogged.png)

- Botão de imprimir segunda via de boletos.
- Botão de atualiação de dados contendo um formulário para a inserção dos novos dados.
- Tela lateral com as informações do plano contratado.
- Botão de redirecionamento para a realização de avaliações.
- Situação do sinistros (SE HOUVER)
