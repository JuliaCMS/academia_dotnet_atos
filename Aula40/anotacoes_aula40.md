# Anotações aula 40 - 05/06

Aula sobre MVC

O padrão MVC (Model-View-Controller) é uma estrutura de arquitetura que é amplamente utilizada no desenvolvimento de aplicativos web. Ele separa as diferentes responsabilidades de um aplicativo em três componentes principais: o modelo (model), a visualização (view) e o controlador (controller).

M (model) - modelo de dados. O modelo representa os dados e a lógica de negócios do aplicativo. Ele é responsável por definir as classes e estruturas de dados, bem como as regras de validação e operações relacionadas aos dados. O modelo interage com o banco de dados ou outros serviços para recuperar e armazenar os dados necessários.

V (view) - A visualização é responsável por exibir a interface do usuário para o usuário final. Ela consiste em elementos de interface, como HTML, CSS, JavaScript e TypeScript. A visualização recebe dados do controlador e os renderiza para o usuário. Geralmente, existem várias visualizações para diferentes partes do aplicativo.

C (controller) - O controlador lida com as solicitações do usuário e coordena as interações entre o modelo e a visualização. Ele recebe as solicitações HTTP do cliente, processa os dados necessários do modelo e decide qual visualização deve ser exibida. O controlador também pode realizar operações de validação e aplicar regras de negócio antes de retornar uma resposta ao usuário.

Usando esse padrão, as solicitações de usuário são encaminhadas para um controlador, que é responsável por trabalhar com o modelo para executar as ações do usuário e/ou recuperar os resultados de consultas.

O controlador escolhe a exibição a ser exibida para o usuário e fornece-a com os dados do modelo solicitados

Tipo de projeto - Aplicativo web do ASP.NET Core (Model-View-Controller) - pacote que precisa ter instalado (cargas de trabalho): "ASP.NET e desenvolvimento web" - Após criar o projeto, compilar, clicar pra iniciar sem depuração (ctrl + f5)

No arquivo "program.cs" do projeto, você pode encontrar o código responsável pelo controle de rota. O roteamento determina qual controlador e ação devem ser executados com base na URL solicitada pelo usuário.

@RenderBody() apresenta o HTML que está dentro de cada Index -> O uso de "@RenderBody()" em uma visualização do MVC é uma diretiva que indica onde o conteúdo específico de uma página deve ser exibido. Quando uma visualização herda de um layout principal (layout.cshtml), o "@RenderBody()" é usado para renderizar o conteúdo específico de cada página dentro do layout.
