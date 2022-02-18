//Console.WriteLine("Hello World!");
//.Write e WriteLine são métodos após de ele sempre haverá um conjunto de parentêses
//Console é uma classe, classes  são proprietárias dos métodos
//O ponto é o operador de acesso ao membro, é como você navega da classe para um dos métodos dela
//Por fim, o ponto e vírgula é o final do operador de instrução. Uma instrução é uma instrução completa em C#. O ponto e vírgula informa ao compilador que terminamos de inserir o comando.
Console.Write("Congratulations!");
Console.Write(" ");
Console.Write("You wrote your first lines of code!");

Console.WriteLine("This is ths first line.");
Console.WriteLine("This is the second line.");
//Para criar um literal decimal, acrescente a letra m após o número. Nesse contexto, o m é chamado de sufixo literal. O sufixo literal informa ao compilador que você deseja trabalhar com um valor do tipo decimal.
Console.WriteLine(12.3m);
//Você pode usar um m em letras minúsculas ou um M em maiúsculas como o sufixo literal para um decimal.
//Exemplos de declaração de variáveis
string firstName;
char userOption;
int gameScore;
decimal particlesPerMillion;
bool processedCostumer;
//Reatribuir o valor de uma variável
string firstName;
firstName = "Bob";
Console.WriteLine(firstName);
firstName = "Beth";
Console.WriteLine(firstName);
firstName = "Conrad";
Console.WriteLine(firstName);
firstName = "Grant";
Console.WriteLine(firstName);
//você pode declarar e definir o valor da variável em uma linha de código. Essa técnica é chamada de inicializar a variável.
string firstName = "Bob";
Console.WriteLine(firstName);
///É importante entender que a palavra-chave var depende do valor usado para inicializar a variável. Se tentar usar a palavra-chave var sem inicializar a variável, você receberá um erro quando tentar compilar seu código.
//Inicializada
var message = "Hello World!";
message = 10.0m;
//Não inicializada
var message;//dá erro
//Desafio
string firstName = "Bob";
int quant = 3;
decimal temp = 34.4m;
Console.Write("Hello, ");
Console.Write(firstName);
Console.Write("! You have ");
Console.Write(quant);
Console.Write(" in your inbox. The temperature is ");
Console.Write(temp);
Console.Write("Celsius.");