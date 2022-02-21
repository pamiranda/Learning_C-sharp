//Sequência de escape para quando é necessário usar aspas duplas dentro de cadeia de caracteres
Console.WriteLine("Hello \"World\"!");
//Para exibir barra invertida simples use \\
Console.WriteLine("c\\source\\repos");

///Formatar a saída do aplicativo de linha de comando usando sequências de escape de caractere

Console.WriteLine("Generating invoices for costumer \"ABC Corp\"...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.Write(@"c:\invoices");

///Um literal de cadeia de caracteres textual manterá todo o espaço em branco e os caracteres sem a necessidade de escapar da barra invertida. Para criar uma cadeia de caracteres textual, use a diretiva @ antes da cadeia de caracteres literal.
Console.WriteLine(@"   c:\source\repos
        (this is where your code goes)");
///Você também pode adicionar caracteres codificados em cadeias de caracteres literais usando a sequência de escape \u e, em seguida, um código de quatro caracteres representando algum caractere em Unicode (UTF-16).
// Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");        
///Use as sequências de escape de caractere quando precisar inserir um caractere especial em uma cadeia de caracteres literal, como uma tabulação \t, uma nova linha \n ou uma aspa dupla \".
///Use um caractere de escape para a barra invertida \\ quando precisar usar uma barra invertida em todos os outros cenários.
///Use a diretiva @ para criar um literal de cadeia de caracteres que mantenha toda a formatação de espaço em branco e caracteres de barra invertida em uma cadeia de caracteres.
///Use o \u mais um código de quatro caracteres para representar caracteres Unicode (UTF-16) em uma cadeia de caracteres.
///Os caracteres Unicode podem não ser impressos corretamente dependendo do aplicativo.