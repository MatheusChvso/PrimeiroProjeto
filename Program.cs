//Introdução A C# , Strings

Console.WriteLine("Olá Mundo!");


string aAmigo = "";
aAmigo = "Kayky";

Console.WriteLine("Hello " + aAmigo);
//ou
// Se colocar $ antes da abertura de aspas da cadeia de caracteres, você poderá incluir variáveis.

aAmigo = "Samuel";
Console.WriteLine($"Hello {aAmigo}");

//-------------------------------------------------------------------
string amigoA = "Murilo";
string amigoB = "Pablo Marçal";
Console.WriteLine($"Olá {amigoA} and {amigoB}!");

Console.WriteLine($"O Nome {amigoA} has {amigoA.Length} letras.");
Console.WriteLine($"O Nome {amigoB} has {amigoB.Length} letras.");

// cortando espaços nas strings


string boasvindas = "                    HELLO WORLD!                     ";
Console.WriteLine($"[{boasvindas}]");
//repare que o [] está desempenhando o papel de string depois o {} está chamando a variavel boasvindas
//vamos remover o espaõ inutil com o método trim
string trimmedGreeting = boasvindas.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]"); //cirtado no começo , start
trimmedGreeting = boasvindas.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]"); //cortado no fim, end
trimmedGreeting = boasvindas.Trim();
Console.WriteLine($"[{trimmedGreeting}]"); // trim base, remove tudo.



// método replace
string digaola = "Olá Mundo!";
Console.WriteLine(digaola);
digaola = digaola.Replace("Olá", "Grande");
Console.WriteLine(digaola);


//método escrever tudo em maiusculo ou tudo em minusculo
Console.WriteLine(digaola.ToUpper()); //maiusulo

Console.WriteLine(digaola.ToLower()); // minusculo

//método para encontrar uma subcadeia de caracteres em uma cadeia de caracteres .contains
string letraMusica = "A galera grita quando eu mostro skateboard";
Console.WriteLine($"A musica '{letraMusica}' contém skateboard?");
Console.WriteLine(letraMusica.Contains("skateboard"));
Console.WriteLine("E Mundo?");
Console.WriteLine(letraMusica.Contains("Mundo"));

string songLyrics = "You say goodbye, and I say hello";
Console.WriteLine(songLyrics.Contains("goodbye"));
Console.WriteLine(songLyrics.Contains("greetings"));

Console.WriteLine(songLyrics.StartsWith("You"));
Console.WriteLine(songLyrics.StartsWith("goodbye"));

Console.WriteLine(songLyrics.EndsWith("hello"));
Console.WriteLine(songLyrics.EndsWith("goodbye"));