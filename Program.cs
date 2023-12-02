string textoDigitado;

Console.Write("Digite qualquer coisa: ");
textoDigitado = Console.ReadLine()!;

Console.WriteLine(textoDigitado.Trim().Substring(0, 1));