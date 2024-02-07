string condicao = "executar";
string? valorRecebidoDoUsuario = "";

while (condicao == "executar")
{
    Console.WriteLine("\n  MENU DE FUNÇÕES  ");
    Console.WriteLine("Qual função deseja rodar? ");
    Console.WriteLine("1. Calculadora Básica");
    Console.WriteLine("2. Calculadora de IMC");
    Console.WriteLine("3. Calculadora de Combustível");
    Console.WriteLine("0. Sair");

    Console.WriteLine("\nInforme o número da função escolhida: ");
    valorRecebidoDoUsuario = Console.ReadLine();

    switch(valorRecebidoDoUsuario)
    {
        case "1":
            exibirCalculadoraBasica();
            break;
        case "2":
            exibirCalculadoraDeIMC();
            break;
        case "3": 
            exibirCalculadoraDeCombustivel();
            break;
        case "0":
            condicao = "sair";
            Console.WriteLine("\nObrigada por utilizar nosso programa!");
            break;
        default:
            Console.WriteLine("\nO número digitado é inválido, tente novamente.");
            break;
    }

}


void exibirCalculadoraBasica()
{
// # CALCULADORA BÁSICA #
double valor1, valor2;
string condicao = "calculadora";
string? valorRecebidoDoUsuario = "";

Console.WriteLine("\n--------------------------------------------------------------------------------------------------");
Console.WriteLine("\n  CALCULADORA BÁSICA  ");
while (condicao == "calculadora")
{
    Console.WriteLine("Qual operação deseja realizar? ");
    Console.WriteLine("1. Soma ");
    Console.WriteLine("2. Subtração ");
    Console.WriteLine("3. Multiplicação ");
    Console.WriteLine("4. Divisão ");
    Console.WriteLine("0. Sair ");

    Console.Write("\nDigite o número da operação escolhida: ");
    valorRecebidoDoUsuario = Console.ReadLine();

switch (valorRecebidoDoUsuario)
{
    case "1":
        Console.Write("\nInforme o primeiro valor: ");
        valor1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Informe o segundo valor: ");
        valor2 = Convert.ToDouble(Console.ReadLine());
            double soma = valor1 + valor2;
            Console.WriteLine($"{valor1} + {valor2} = {soma}\n");
        break;
    case "2":
        Console.Write("\nInforme o primeiro valor: ");
        valor1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Informe o segundo valor: ");
        valor2 = Convert.ToDouble(Console.ReadLine());
            double subtracao = valor1 - valor2;
            Console.WriteLine($"{valor1} - {valor2} = {subtracao}\n");
        break;
    case "3":
        Console.Write("\nInforme o primeiro valor: ");
        valor1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Informe o segundo valor: ");
        valor2 = Convert.ToDouble(Console.ReadLine());
            double multiplicacao = valor1 * valor2;
            Console.WriteLine($"{valor1} x {valor2} = {multiplicacao}\n");
        break;
    case "4":
        Console.Write("\nInforme o primeiro valor: ");
        valor1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Informe o segundo valor: ");
        valor2 = Convert.ToDouble(Console.ReadLine());
            double divisao = valor1 / valor2;
            Console.WriteLine($"{valor1} / {valor2} = {divisao}\n");
                if (valor2 == 0){
                    Console.WriteLine("Não é possível realizar divisões com divisor igual a zero. Por favor, forneça outro valor.\n");
                }
        break;
    case "0":
        condicao = "executar";
        break;
    default:
        Console.WriteLine("\nO número digitado é inválido. Por favor, tente novamente.\n");
        break;
    } 
}
}

void exibirCalculadoraDeIMC()
{
    // # CALCULADORA DE IMC #
double pesoUsuario, alturaUsuario;
string condicao = "calculoIMC";


Console.WriteLine("\n--------------------------------------------------------------------------------------------------");
Console.WriteLine("\n  CALCULADORA DE IMC  ");
while (condicao == "calculoIMC")
{
Console.WriteLine("Escolha uma das opções para prosseguir: ");
Console.WriteLine("1. Usar calculadora de IMC");
Console.WriteLine("0. Voltar para o menu");

Console.WriteLine("\nInforme o número da opção escolhida: ");
valorRecebidoDoUsuario = Console.ReadLine();

switch(valorRecebidoDoUsuario)
{
    case "1":
        calculadoraDeIMC();
        break;
    case "0":
        condicao = "executar";
        break;
    default:
        Console.WriteLine("\nO número digitado é inválido, tente novamente.");
        break;
}


void calculadoraDeIMC()
{
Console.Write("\nInforme o seu peso em quilogramas (kg): ");
pesoUsuario = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe a sua altura em metros (m): ");
alturaUsuario = Convert.ToDouble(Console.ReadLine());

double imcUsuario = pesoUsuario / Math.Pow(alturaUsuario, 2);

if (imcUsuario < 18.5){
    Console.WriteLine($"\nO seu IMC é de {imcUsuario.ToString("0.00")} Kg/m2 e você se encontra com baixo peso.");
}
else if (imcUsuario >= 18.5 && imcUsuario < 24.9){
    Console.WriteLine($"\nO seu IMC é de {imcUsuario.ToString("0.00")} Kg/m2 e você se encontra com peso normal.");
}
else if (imcUsuario >= 25 && imcUsuario < 29.0){
    Console.WriteLine($"\nO seu IMC é de {imcUsuario.ToString("0.00")} Kg/m2 e você se encontra com excesso de peso.");
}
else if (imcUsuario >= 30 && imcUsuario < 34.9){
    Console.WriteLine($"\nO seu IMC é de {imcUsuario.ToString("0.00")} Kg/m2 e você se encontra com obesidade classe I.");
}
else if (imcUsuario >= 35 && imcUsuario < 39.9){
    Console.WriteLine($"\nO seu IMC é de {imcUsuario.ToString("0.00")} Kg/m2 e você se encontra com obesidade classe 2.");
}
else{
    Console.WriteLine($"\nO seu IMC é de {imcUsuario.ToString("0.00")} Kg/m2 e você se encontra com obesidade mórbida.");
}
}
};
};

void exibirCalculadoraDeCombustivel()
{
    // # CALCULADORA DE COMBUSTÍVEL #
double precoAlcool, precoGas, qtdAbastecidaAlcool, qtdAbastecidaGas;
string condicao = "calculoCombustivel";

Console.WriteLine("\n--------------------------------------------------------------------------------------------------");
Console.WriteLine("\n  CALCULADORA DE COMBUSTÍVEL  ");
while (condicao == "calculoCombustivel")
{
Console.WriteLine("Escolha uma das opções para prosseguir: ");
Console.WriteLine("1. Usar calculadora de combustível");
Console.WriteLine("0. Voltar para o menu");

Console.WriteLine("\nInforme o número da opção escolhida: ");
valorRecebidoDoUsuario = Console.ReadLine();

switch(valorRecebidoDoUsuario)
{
    case "1":
        calculadoraDeCombustivel();
        break;
    case "0":
        condicao = "executar";
        break;
    default:
        Console.WriteLine("\nO número digitado é inválido. Por favor, tente novamente.");
        break;
}

void calculadoraDeCombustivel()
{
    Console.WriteLine("\n ÁLCOOL ");
Console.Write("Informe o preço do litro de álcool: ");
precoAlcool = Convert.ToDouble(Console.ReadLine());
Console.Write("Informe a quantidade de litros abastecidos com álcool: ");
qtdAbastecidaAlcool = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("\n GÁS ");
Console.Write("Informe o preço do litro de gás: ");
precoGas = Convert.ToDouble(Console.ReadLine());
Console.Write("Informe a quantidade de litros abastecidos com gás: ");
qtdAbastecidaGas = Convert.ToDouble(Console.ReadLine());

double alcoolTotal = precoAlcool * qtdAbastecidaAlcool;
double gasTotal = precoGas * qtdAbastecidaGas;

double diferencaPrecoGas = alcoolTotal - gasTotal;
double diferencaPrecoAlcool = gasTotal - alcoolTotal;

if (alcoolTotal > gasTotal){
    Console.WriteLine($"\nA opção mais econômica é o gás. Você pagará R${gasTotal} e economizará R${diferencaPrecoGas}.");
    Console.WriteLine("\n--------------------------------------------------------------------------------------------------");
}
else{
    Console.WriteLine($"\nA opção mais econômica é o álcool. Você pagará R${alcoolTotal} e economizará R${diferencaPrecoAlcool}.");
    Console.WriteLine("\n--------------------------------------------------------------------------------------------------");
}
}
}
};




