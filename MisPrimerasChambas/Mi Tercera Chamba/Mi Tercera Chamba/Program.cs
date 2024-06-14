

//decimal[] typedNumbers = new decimal[1];
List<decimal> typedNumbers2 = new List<decimal>();

//typedNumbers2.Add(1);
//typedNumbers2.Add(2);
//typedNumbers2.Add(3);
//typedNumbers2.Add(4);
//typedNumbers2.Add(5);

//Console.WriteLine(typedNumbers2[4]);

//typedNumbers2.RemoveAt(2);

//Console.WriteLine(typedNumbers2[4]);

//KEY, Value
//Dictionary<int,decimal > valuesForDictionary = new Dictionary<int,decimal>();
//Dictionary<int,string> names = new Dictionary<int,string>();
//Dictionary<int,string> lastNames = new Dictionary<int,string>();
//Dictionary<int, string> sexs = new Dictionary<int, string>();

//for remove the entires 
//names.Remove(2);


//names.Add(1, "Juan");
//lastNames.Add(1, "Almonte");
//sexs.Add(1, "M");

//names.Add(2, "Juana");
//lastNames.Add(1, "Altagracia");
//sexs.Add(1, "F");

//Console.WriteLine($"Las Informaciones del estudiante son: Nombre: {names[1]}, Apellido: {lastNames[1]}");
//Console.WriteLine($"Las Informaciones del estudiante son: Nombre: {names[2]}, Apellido: {lastNames[2]}");

//for (int i = 1; i < names.Count; i++)
//{
//Console.WriteLine($"Las Informaciones del estudiante son: Nombre: {names[i ]}, Apellido: {lastNames[i]}");

//}
//valuesForDictionary.Add(1, 15);
//valuesForDictionary.Add(2, 162);
//valuesForDictionary.Add(3, 635);
//valuesForDictionary.Add(96, 635);

//for remove the entires 
//names.Remove(2);

//string[,] students = new string [3,3];
//students[0, 1] = "Juan";
//students[0, 2] = "Almonte";
//students[0, 3] = "M";

//students[1, 1] = "Juana";
//students[1, 2] = "Altagracia";
//students[1, 3] = "F";

Console.WriteLine(@"Bienvenido a nuestra calculadora Básica
En este proyecto usted va a escoger una opción de la operación que desea realizar
Y posterior a eso podrá escoger los números a los cuales les desea realizar dicha operación.");


Console.WriteLine("1. Suma \t\t 2. Resta  \t\t 3. Multiplicación  \t\t 4. Divición  \t\t 5. Cerrar");
Console.Write("Digite un numero del 1 al 5, para indicar la operación que usted desea realizar: ");

int typedOption = 0;
try
{
    typedOption = Convert.ToInt32(Console.ReadLine());


    if (typedOption > 5)
    {
        Console.WriteLine("A ti te dejaron caer cuando chiquito, verdad?");
    }
    else
    {

        decimal typedNumber1;
        // decimal typedNumber2;
        int userWantContinue = 1;
        decimal operationResult;
        //decimal typedNumber3;
        //decimal typedNumber4;
        //decimal typedNumber5;
        //decimal typedNumber6;
        //decimal typedNumber7;

        //arrays 
        //  decimal[] decimals = { 1, 2, 3, 4 };
        //decimal[] decimals2 = new decimal [4];
        //decimals2[0] = 1;
        //decimals2[1] = 2;
        //// decimals2[2] = 3;
        //decimals2[3] = 4;

        //Console.WriteLine(decimals[2]);
        //decimals[2] = 0;



        //typedNumbers2.Add(1);
        //typedNumbers2.Add(2);
        //typedNumbers2.Add(3);
        //typedNumbers2.Add(4);
        //typedNumbers2.Add(5);

        //Console.WriteLine(typedNumbers2[2]);


        Console.Write("Digite el primer Número: ");
        typedNumber1 = Convert.ToDecimal(Console.ReadLine());

        //Console.Write("Digite el segundo Número: ");
        //typedNumber2 = Convert.ToDecimal(Console.ReadLine());

        //Console.WriteLine("Desea Continuar? ");
        //Console.WriteLine("1. Si, 2. No");
        //userWantContinue = Convert.ToInt32(Console.ReadLine());

        do
        { 
            Console.Write("Digite un número adicional: ");
            typedNumbers2.Add(Convert.ToDecimal(Console.ReadLine()));

            Console.WriteLine("Desea Continuar? ");
            Console.WriteLine("1. Si, 2. No");
            userWantContinue = Convert.ToInt32(Console.ReadLine());
        }
        while (userWantContinue == 1);

        //while (userWantContinue == 1)
        //{
        //    Console.Write("Digite un nuevo Número: ");

        //    typedNumbers2.Add(Convert.ToDecimal(Console.ReadLine()));
        //    //typedNumbers[typedNumbers.Length -1] = Convert.ToDecimal(Console.ReadLine());

        //    //var tempValue = Convert.ToDecimal(Console.ReadLine());
        //    //typedNumbers[typedNumbers.Length - 1] = tempValue;

        //    //decimal[] typedNumbersTemp = typedNumbers;
        //    //typedNumbers = new decimal[typedNumbers.Length + 1];
        //    // typedNumbers = new decimal[typedNumbers.Count() + 1];

        //    //for (int index = typedNumbersTemp.Length ; index > 0; index--)
        //    //for (int index = typedNumbersTemp.Length + 1; index >= 0; index--)
        //    // for (short index = 0; index <= typedNumbersTemp.Length -1; index++)
        //    //for (int index = 0; index < typedNumbersTemp.Length; index++)
        //    //{
        //    //    typedNumbers[index] = typedNumbersTemp[index];
        //    //}

        //    Console.WriteLine("Desea Continuar? ");
        //    Console.WriteLine("1. Si, 2. No");
        //    userWantContinue = Convert.ToInt32(Console.ReadLine());
        //}
        //Console.WriteLine(typedNumbers[10]);

        //Console.WriteLine(typedNumbers2[10]);

        operationResult = typedNumber1;
        switch (typedOption)
        {
            case 1:
                {
                    //operationResult = typedNumber1; // + typedNumber2;
                    //for (int index = 0; index < typedNumbers.Length; index++)
                    //{
                    //    operationResult += typedNumbers[index];
                    //   // operationResult = operationResult + typedNumbers[index];
                    //}
                    for (int index = 0; index < typedNumbers2.Count; index++)
                    {
                        operationResult += typedNumbers2[index];
                    }

                }
                break;
            case 2:
               // operationResult = typedNumber1 - typedNumber2;

                {
                   // operationResult = typedNumber1;  
                    for (int index = 0; index < typedNumbers2.Count; index++)
                    {
                        operationResult -= typedNumbers2[index];
                    }

                }
                break;
            case 3:
                { 
                    for (int index = 0; index < typedNumbers2.Count; index++)
                    {
                        operationResult *= typedNumbers2[index];
                    } 
                }
                //operationResult = typedNumber1 * typedNumber2;
                break;
            case 4:
                //operationResult = typedNumber1 / typedNumber2;
                {
                    for (int index = 0; index < typedNumbers2.Count; index++)
                    {
                        operationResult = operationResult / typedNumbers2[index];
                    }
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
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine("El programador inepto intentó acceder a un elemento de algun arreglo, que no tiene la dimencion especificada");
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine("El programador inepto intentó acceder a un elemento de algun lista, que no tiene la dimencion especificada");
}
catch (DivideByZeroException ex)
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