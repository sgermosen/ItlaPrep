
try
{
    Console.WriteLine(@"Bienvenido a nuestra calculadora Básica.
En este proyecto usted va a escribir una opcion que represente la operación que desea realizar.
Y luego podrá digitar los numeros que desea afectar con dicha operación.");


    Console.WriteLine("1. Suma      2. Resta        3. Multiplicación       4. Divición     5.Cerrar");
    Console.Write("Digite un numero del 1 al 5 que represente la operación que usted desea realizar: ");

    string opctionDigitada = Console.ReadLine();
    //int valorDeOperacion = int.Parse(opctionDigitada);
    int valorDeOperacion;

    //try { }
    //catch { }
    //finally { }

    valorDeOperacion = Convert.ToInt32(opctionDigitada);

    if (valorDeOperacion > 5 || valorDeOperacion < 1)
    {
        Console.WriteLine("A ti te dejaron caer cuando chiquito, verdad?");
    }
    else
    {
        Console.WriteLine();
        Console.Write("Digite el primer numero: ");
        string primerValorDiginato = Console.ReadLine();
        decimal primerNumero = Convert.ToDecimal(primerValorDiginato);

        Console.Write("Digite el segundo numero: ");
        decimal segundoNumero = Convert.ToDecimal(Console.ReadLine());

        decimal resultado;

        switch (valorDeOperacion)
        {
            case 1:
                resultado = primerNumero + segundoNumero;
                break;
            case 2:
                resultado = primerNumero - segundoNumero;
                break;
            case 3:
                resultado = primerNumero * segundoNumero;
                break;
            case 4:
                resultado = primerNumero / segundoNumero;
                break;
            default:
                resultado = 0;
                break;
        }

        Console.WriteLine($"El Resultado es: {resultado}");
        Console.ReadKey();
    }
}
//catch (DivideByZeroException ex)
//{
//    Console.WriteLine($"Ah porque tu ere loco: como que tu no sabes que no se puede divir entre cero");
//}

catch (ArithmeticException ex)
{ 
    Console.WriteLine($"Montro, pasó un error aritmetico raro, la verdad no se que lo que, agarrate de ahi de lo mio: {ex.Message}");
}
catch (FormatException)
{ 
    Console.WriteLine("Ah porque tu ere loco: Digitaste una palomeria");
}
catch (Exception ex)
{
    Console.WriteLine($"Ocurrió un error que que no pude identificar: {ex.Message}");
}
