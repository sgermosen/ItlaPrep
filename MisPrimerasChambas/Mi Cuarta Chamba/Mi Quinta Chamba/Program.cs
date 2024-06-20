try
{
    decimal operationResult;
    int typedOption = 0;
    decimal typedNumber1;

    int wantToContinueTyped = 1;
    bool wantToContinue = true;

    List<decimal> typedAdtionalNumers = new List<decimal>();
    Console.WriteLine(@"Bienvenido a nuestra calculadora Básica
En este proyecto usted va a escoger una opción de la operación que desea realizar
Y posterior a eso podrá escoger los números a los cuales les desea realizar dicha operación.");

    Console.WriteLine("1. Suma \t\t 2. Resta  \t\t 3. Multiplicación  \t\t 4. Divición  \t\t 5. Cerrar");
    Console.Write("Digite un numero del 1 al 5, para indicar la operación que usted desea realizar: ");


    typedOption = Convert.ToInt32(Console.ReadLine());

    if (typedOption >= 6 || typedOption <= 0)
    {
        Console.WriteLine("A ti te dejaron caer cuando chiquito, verdad?");
    }
    else
    {

        Console.Write("Digite el primer Número: ");
        typedNumber1 = Convert.ToDecimal(Console.ReadLine());

        while (wantToContinue)
        {
            Console.Write("Digite otro Número: ");
            decimal tempTypedValue = Convert.ToDecimal(Console.ReadLine());

            typedAdtionalNumers.Add(tempTypedValue);
            Console.WriteLine("Deseas agregar más numeros: ");
            Console.WriteLine("1. Si, 2. No");
            wantToContinue = Convert.ToInt32(Console.ReadLine()) == 1;

        }

        operationResult = typedNumber1;

        switch (typedOption)
        {
            case 1:
                {
                    //foreach (decimal item in typedAdtionalNumers)
                    //{
                    //    operationResult = Add(item, operationResult);
                    //    // operationResult += item;
                    //}
                    // var temp = AddFromList(typedAdtionalNumers, operationResult);
                    //var temp =  AddFromList(typedAdtionalNumers, ref operationResult);
                    AddFromList(typedAdtionalNumers, ref operationResult);
                    // AddFromList( operationResult, typedAdtionalNumers);
                   // Console.WriteLine("operationResult" + operationResult);
                   // Console.WriteLine("temp" + temp);
                }

                break;
            case 2:
                {
                    SubstractFromList(typedAdtionalNumers, ref operationResult);
                    //foreach (decimal item in typedAdtionalNumers)
                    //{
                    //    operationResult -= item;
                    //}
                }

                break;
            case 3:
                {
                    MultiplicationFromList(typedAdtionalNumers, ref operationResult);

                    //foreach (decimal item in typedAdtionalNumers)
                    //{
                    //    operationResult *= item;
                    //}
                }

                break;
            case 4:
                {
                    DivisionFromList(typedAdtionalNumers, ref operationResult);

                    //foreach (decimal item in typedAdtionalNumers)
                    //{
                    //    operationResult /= item;
                    //}
                }

                break;
            default:
                operationResult = 0;
                break;
        }
        Console.WriteLine($"El Resultado es: {operationResult}");
        Console.WriteLine($"Terminamos...");
    }
}
catch (IndexOutOfRangeException)
{
    Console.WriteLine("En algun arreglo estas intentando acceder a un indice no existe");
}
catch (ArgumentOutOfRangeException)
{
    Console.WriteLine("En alguna lista estas intentando acceder a un elemento no existe");
}
catch (KeyNotFoundException)
{
    Console.WriteLine("En algun diccionario estas intentando acceder a una llave que no existe");

}
catch (DivideByZeroException)
{
    Console.WriteLine("No se puede dividir entre cero maldito animal!!!");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Alguien pasó por aqui");
}
Console.ReadKey();

static decimal Add(decimal value1, decimal value2)
{
    var result = value1 + value2;
    return result;
}

//static decimal AddFromList(List<decimal> typedAdtionalNumers,  decimal operationResult)
//{
//    //decimal operationResult = 0;
//    foreach (decimal item in typedAdtionalNumers)
//    {
//        // operationResult = Add(item, value1);
//        operationResult += item;
//    }
//    return operationResult;
//}

static void AddFromList(List<decimal> typedAdtionalNumers, ref decimal operationResult)
{
    foreach (decimal item in typedAdtionalNumers)
    {
        operationResult += item;
    }
}
static void SubstractFromList(List<decimal> typedAdtionalNumers, ref decimal operationResult)
{
    foreach (decimal item in typedAdtionalNumers)
    {
        operationResult -= item;
    }
}

static void MultiplicationFromList(List<decimal> typedAdtionalNumers, ref decimal operationResult)
{
    foreach (decimal item in typedAdtionalNumers)
    {
        operationResult *= item;
    }
}

static void DivisionFromList(List<decimal> typedAdtionalNumers, ref decimal operationResult)
{
    foreach (decimal item in typedAdtionalNumers)
    {
        operationResult /= item;
    }
}