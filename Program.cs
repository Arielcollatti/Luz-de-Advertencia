Console.WriteLine(" --- Simulador de Luz de Advertência --- \n ");

Console.Write("Digite {A}tivado,{D}esativado \n");

Console.Write("Sensor de temperatura....: ");
string tempe = Console.ReadLine()!;

Console.Write("Sensor de presssão.......: ");
string press = Console.ReadLine()!;

Console.Write("Sensor de rotação........: ");
string  rota = Console.ReadLine()!;

if (tempe == "A" && (press == "A" || rota == "D"))
{
    Console.ForegroundColor =  ConsoleColor.Green;
    Console.WriteLine(" Luz de advertencia estará  ativada  ");

} else 
    {
    Console.ForegroundColor =  ConsoleColor.DarkRed;
    Console.WriteLine(" Luz de advertencia estará  desativada ");
    }
Console.ResetColor();





