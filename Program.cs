using System;


namespace projeto_teste_Git_Aulas99a112
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá mundo!"); 
            Console.WriteLine("Bom dia!");
            Console.WriteLine("Como você está hoje?");        

            Console.ReadLine();           
            // Comando para ele esperar eu digitar um <ENTER>.
            // ReadLine() fica esperando o usuário digitar qq coisa e apertar <ENTER>. Ou só apertar <ENTER>.
            //
            //
            //
            //
            // Poderia ser uma ENTRADA DE DADOS para o programa:
            //string leituraDados = Console.ReadLine(); // O usuário irá digitar 3 dados, separados por ' '.
            //                                          // Após o usuário apertar <enter>, irá para a string leitura.
            //
            //System.Console.WriteLine("string leitura = " + leituraDados); // Mostrando a variável leitura.
            //
            //string[] vect = new string[3]; // Criei um VETOR com 3 posições, para armazenar as 3 strings do usuário.
            //vect = leituraDados.Split(' '); // O usuário irá digitar 3 dados, separados por ' '.
            //                                 // Split irá RECORTAR a string do usuário em 3 strings.
            //                                 // Os 3 dados irão pra o vetor nas posições. 
            //
            //for (int i = 0; i < 3; i++)  // Mostrando os 3  dados individualmente agora.          
            //{ 
            //    System.Console.WriteLine(vect[i]);   
            //    // Como os 3 dados são strings, não há necessidade de conversão. Caso contrário, iria
            //    // usar um Parse(), em cada iteração, e atribuir à uma variável do tipo.    
            //} 
            //
            //
            //            
            //
            // 
            //
            //
            //
            // Toda a implementação acima de uma ENTRADA DE DADOS do usuário para o programa, 
            // poderia ser resumida num vetor sem tamanho fixo, assim:
            //string[] dados = Console.ReadLine().Split(' '); // Lê os dados e já aplica o Split. 
            //                                                // E guarda no VETOR.
            //foreach (var item in dados) // ParaCada objeto chamado de item do meu vetor (dados)
            //{
            //  System.Console.WriteLine(item); 
            //}
            //
            //
            //
            //
            //
            //
            //
            //
            //                  
            //
            // Para eu usar este comando (Console.ReadLine()), tenho que modificar a configuração 
            // "console": "externalTerminal", do arquivo launch.json.
            // Senão, vai gerar a EXCEÇÃO:
            //   Unhandled exception. System.InvalidOperationException: Cannot read 
            //   keys when either application does not have a console or when console input 
            //   has been redirected. Try Console.Read.
            //       at System.ConsolePal.ReadKey(Boolean intercept)
            //       at System.Console.ReadKey()
            //       at CourseClass99_ComoCriarUmNovoRepositorio_Comando_init.Program.Main
            //       (String[] args) in /home/jose/Área de Trabalho/Projetos C#/
            //       CourseClass99_ComoCriarUmNovoRepositorio_Comando-init/Program.cs:line 18




            // O que é um REPOSITÓRIO:
            // Quando eu quero iniciar um controle de versão, eu crio um repositório na pasta 
            // (meu projeto de software).
            //
            // Ou seja, transformar esta pasta (projeto) CourseClass99_ComoCriarUmNovoRepositorio_Comando_init
            // num repositório de versionamento.
           



            // Criando um Projeto no VS Code, e depois, transformá-lo num repositório de versionamento:
            // MAS ESTE NÃO É O PROPÓSITO DESTA AULA: vamos usar a cli.
            // 
            //
            // - Menu Terminal / New Terminal
            // - Vou para o diretório onde quero criar o Projeto (Pasta) C#: cd Pasta
            // - mkdir NomeProjeto // criar (mkdir) o Projeto
            // - dotnet new <tipo do projeto> // tipo do Projeto .NET, como console app, web ASP.NET,
            //                                // Windows Form Application etc.
            // - dotnet restore
            // - dotnet run
            // - dotnet build
            // - dotnet run
            //
            //
            // Criando um repositório de versionamento para o meu projeto
            //
            // - Clico no ícone Explorer, da Side Bar (Barra Lateral).
            // - Botão direito na Pasta do Projeto / ícone New File / Digitar .gitignore no campo aberto
            // - Será aberto o arquivo no editor.
            //   Colar nele as recomendações sobre quais partes do meu projeto devem ser ignoradas pelo Git.
            // - No Terminal interno aberto (internalTerminal), digitar git init, para criar o repositório. 






            // Aula 99 - Criando um reposittório
            // Comandos: 
            //    .gitiginore
            //    git init
            //
            // Exemplo de criar um repositório, pela cli (a linha de comando do Linux):
            //            
            // 1o. - Crio o projeto
            // Abro o TERMINAL. 
            //                 Obs: MELHOR ABRIR O APLICATIVO TERMINAL, E NÃO ABRIR O Terminal integrado.
            // mkdir NomePasta/Projeto // crio um projeto (pasta), no diretório que eu quiser.
            // cd NomePasta/Projeto // vou para o projeto.
            // dotnet new <tipo do projeto> // para eu criar um projeto .NET, e escolher o tipo dele, como
            //                              // por exemplo um console app (dotnet new console), wfp, Web ASP.NET etc.
            // dotnet restore // para restaurar e instalar as dependências.
            // dotnet build // para buildar o projeto
            // dotnet run // para executar a aplicação.
            //
            //
            // 2o. - Depois depois crio o repositório, em 2 partes
            // 2.1 - Crio o arquivo .gitignore
            // cd NomePasta/Projeto // entro na pasta / projeto.
            // >.gitignore // para criar o arquivo .gitignore (arquivo de contém instruções do que que o Git 
            //             // deve ignorar, isto é,  as partes desnecessárias do projeto
            //             // que não devem ser versionadas no repositório).
            //             // Por exemplo, o arquivo compilado: arquivo executado que eu gero prá debugar o meu
            //             // projeto de software. ELE NÃO PRECISA SER VERSIONADO PELO Git.
            //             //
            //             // Como que eu sei quais arquivos não devem ser versionados?
            //             // Devo entrar no GOOGLE e digitar: gitinore visual studio 2015.
            //             //
            //             // Ler o arquivo:
            //             //      “Criar arquivo vazio de maneira correta no Linux. Não é o touch. Nunca foi. Nunca
            //             //      será...
            //             //
            //             // Todo arquivo/pasta que começa com ponto (.), é arquivo/diretório oculto.
            //             // No Windows é mais difícil, tenho que criar um Documento (.txt), depois renomeá-lo
            //             // no PROMPT DE COMANDO (cli): ren arquivo.txt .arquivo        
            //             //
            //             // Poderia também +  2 opções para criar o arquivo vazio.
            //             // - o comando touch .gitignore
            //             // - Ou no próprio VS CODE, criar o arquivo .gitignore, assim:
            //             //    Botão direito no NomePasta/Projeto, clico no ícone New File
            //
            // Digito no TERMINAL: 
            // ls -a <enter> // Para mostrar todos os arquivos, inclusive os ocultos (.)
            // OU
            // ls -all // Para mostrar todos os arquivos, inclusive os ocultos (.) + permissões.
            //
            //
            // Pesquiso no Google, TUDO que precisa ser ignorado de um Projeto do Visual Studio, pelo Git:
            // gitignore Visual Studio 2015
            //
            // O Google me mostrará esta página. Clicar nela.
            // https://github.com/github/gitignore/blob/master/VisualStudio.gitignore
            //
            // Selecionar (marcar com o mouse) tudo mostrado na página anterior do blob,  dar CTRL + C pra
            // copiar tudo.
            //
            // Abrir o arquivo .gitignore
            // sudo gedit .gitignore // uso o aplicativo gedit para editar o arquivo texto.
            //
            // Copiar os arquivos selecionados da página blob para o arquivo .gitignore
            // CTRL + V
            //
            //
            // 2.1 - Por fim, crio o repositório
            // git init // para criar o repositório.
            //
            //
            //
            //
            //
            // *************************************************************************************************
            // OBS: Os arquivos controlado pelo repositório Git, no Visual Studio Code, ficam destacados na cor 
            //      verde no EXPLORER da Side Bar.
            // ************************************************************************************************









            // Aula 100 - Configurando a identifcação do usuário no Git - comando config.
            //
            // É como eu faço para me identificar para o Git.
            //
            // Ou seja,
            // Sempre que for feita uma alteração no meu repositório de versionamento, é importante identificar 
            // quem fez essa alteração.
            //
            // Aí, vamos usar estes comandos abaixo, no TERMINAL, na pasta do projeto:
            // git config --global user.name “Seu Nome”
            // git config --global user.email “Seu Email” // Tem que ser o mesmo e-mail cadastrado no Github.
            //
            //
            // Digitar no TERMINAL (externo é MELHOR), na pasta do projeto:
            //   git config --global user.Name "Seu Nome"
            //   git config --global user.email "Seum Email" // Tem que ser o mesmo email cadastrado no Github.
            //
            //
            // Então, na hora de eu cadastrar o email de quem está usando o Git, 
            // jose@jose-OEM:~/Área de Trabalho/Projetos C#/projeto-teste_Git-Aulas99a112$ git config --global user.name "Jose Francisco Teixeira"
            // jose@jose-OEM:~/Área de Trabalho/Projetos C#/projeto-teste_Git-Aulas99a112$ git config --global user.email "jfteixeira@yahoo.com.br"
            //
            // ******* OBS: Os comando de configuração do usuário Git já foi realizado. ***********






           // Aula 101 - Salvando versões -
           // comandos add, commit, status ...
           //
           //
           // A AÇÃO de salvar uma “versão” do projeto chama-se “commit”.
           //
           // Então, quando eu altero o projeto, testei, deu certo. 
           // Opa, quero salvar esta versão porque deu certo.
           // Uso o termo:
           // "Vou dar um commit no projeto".
           //
           // Muitos usam o verbo "commitar". 
           // Commitar é salvar uma alteração (versão) do meu projeto que deu certo.
           //
           //
           //
           // Como salvar uma “versão” do meu projeto de software?
           // git add .
           // // Coloco os arquivos modificados na área de "stage" (PRONTOS, para serem commitados).
           // // Depois que eu der este comando, os arquivos alterados (em vermelho) passam para a VERDE.
           // // Basta eu dar "git status" para ver que passaram prá cor VERDE. 
           //
           // git commit -m "Descrição do commit" 
           // // Realizo o commit, colocando a descrição (Descrever o que que eu fiz (alterei) até este momento).
           //
           //
           //
           //
           //
           // Antes ou após salvar uma "versão" do meu projeto, posso usar uns comandos (operações) úteis:
           // git status 
           // // Para verificar como está o nosso REPOSITÓRIO. 
           // // O git vai indicar em VERMELHO:
           // // - Os arquivos que foram modificados, e não estão RASTREADOS. 
           // // O git vai indicar em VERDE:
           // // - Os arquivos PRONTOS (os arquivos que estão na área "stage") para commitar ("salvar"):
           // //   , ie, .
           // //   D.
           // // Os arquivos em VERMELHO, se eu quiser commitar na sequência, digito "git add .". 
           // // após este comando.
           //
           // git log 
           // // Comando para ver o histórico de versões.
           // // Após realizar um commit, para ver se o commit existe (se foi realizado com sucesso).
           //
           // git log --online 
           // // Mostra os commit realizados (Histórico de versões), de formma mais resumida.
           //
           //
           //
           //
           //
           //
           // Commits realizados neste projeto de software até a aula 101:
           // 1o. commit:
           // Projeto inicial:
           //   Console.WriteLine("Olá Mundo!";
           //   Console.ReadLine();
           //
           // 2o. commit:
           // Alteração:
           //   Console.WriteLine("Olá Mundo!";
           //   Console.WriteLine("Bom dia!"); // INCLUÍ ESTA LINHA.
           //   Console.ReadLine();
           //
           // Dando o comando
           // git log // Vejo estes commits.


           





        }
    }
}
