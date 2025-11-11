//1- Crie uma variável chamada idade e atribua a ela o valor 35 e exiba o seu valor.
using System.IO.Pipes;

var idade = 35;
Console.WriteLine(idade);

//2- Crie uma variável chamada nome e atribua o valor "Maria" e exiba o seu valor.
var nome = "Maria";
Console.WriteLine(nome);

//3- Crie uma variável chamada altura e atribua a ela o valor 3.45.
var altura = 3.45;
Console.WriteLine(altura);

//4- Crie uma variável chamada data e atribua a ela a data 04/09/1999 e exiba o seu valor.
var data = "04/09/1999";
DateTime date = new DateTime(1999, 09, 04);

Console.WriteLine("Data armazenada na variavel (string): " + data);
Console.WriteLine("Data usando DateTime: " + date);

//5- Crie uma constante chamada ano e atribua a ela o valor 12 e exiba o seu valor;
const int ano = 12;
Console.WriteLine(ano);

//6- Declare uma variável nota do tipo double como sendo do tipo Nullable type e atribua o valor 7.80 e exiba o seu valor.
double? nota = null;
nota = 7.80;

Console.WriteLine(nota);

//13- Declare duas variáveis x e y como sendo do tipo int e atribua a ela os valores 77 e 66 e a seguir imprima o valor da soma de x com y. (Use o operador aritmético + para realizar a operação de soma)
int x = 77;
int y = 66;

Console.WriteLine(x + y);

