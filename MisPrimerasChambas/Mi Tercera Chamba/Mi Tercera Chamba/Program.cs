try
{
    //arrays
    //int[] numbers = { 1, 2, 3, 4, 5 };

    //Console.WriteLine(numbers[0]);  
    //Console.WriteLine(numbers.Count());  
    //Console.WriteLine(numbers.Length);

    //Console.WriteLine(numbers[4]);  
    // Console.WriteLine(numbers[6]);

    //int[] results = new int[5];  
    //results[0] = 1;
    //results[1] = 2;
    //results[2] = 3;
    //results[3] = 4;
    //results[4] = 5;
    //results = new int[6];  

    //results[5] = 6;

    //results[5] = 0;

    //string[] strings = { "Juan", "Pedro", "Pablo", "De la Mar" };

    ////strings[0] = "";
    //strings[1] = string.Empty;

    //Console.WriteLine(results[0]);  

    //Console.WriteLine(results[4]);  

    //List

    // List<string> fruits = new List<string> { "manzana", "banana", "cereza" };

    //Console.WriteLine(fruits[2]);

    //fruits.Add("durazno");  

    //Console.WriteLine(fruits[3]);  

    //List<int> operationHistory = new List<int>();
    //operationHistory.Add(1);
    // int firstOperation = operationHistory[0];
    //Console.WriteLine(firstOperation);

    //operationHistory.Add(1);
    //operationHistory.Add(10);
    //operationHistory.Add(15);
    //operationHistory.Add(25);

    ////operationHistory[2] = 25;
    //Console.WriteLine(operationHistory[4]);

    //operationHistory.RemoveAt(2);
    //Console.WriteLine(operationHistory[4]);

    //string [,] records = new string [3,3];
    //records[0, 1] = "Juan";
    //records[0, 2] = "Almonte";
    //records[0, 3] = "M";

    //records[1, 1] = "Juana";
    //records[1, 2] = "La Cubana";
    //records[1, 3] = "F";

    //records[2, 1] = "Alberto";
    //records[2, 2] = "Santiago";
    //records[2, 3] = "M";


    ///Dictionary
    ///
    //Dictionary<int, int> ids = new Dictionary<int, int>();
    //ids.Add(1, 1);
    //ids.Add(2, 2);
    //ids.Add(3, 15);

    //Dictionary<string, int> ages = new Dictionary<string, int>();
    ////ages["Juan"] = 25;
    //ages.Add("Juan", 25);
    //ages["Juana"] = 30;
    //ages["Alberto"] = 35;
    ////Console.WriteLine(ages["Juanz"]);
    //Console.WriteLine(ages["Juan"]);

    //Dictionary<string, string> names = new Dictionary<string, string>();
    //names.Add("Juan", "Juan");
    //names.Add("Juana", "Juana");
    //names.Add("Alberto", "Alberto");

    //Dictionary<string, string> lastNames = new Dictionary<string, string>();
    //lastNames.Add("Juan", "Almonte");
    //lastNames.Add("Juana", "La Cuabana");
    //lastNames.Add("Alberto", "Santiago");

    //foreach (string name in names.Keys)
    //{
    //    Console.WriteLine($"El Nombre es {names[name]} el apellido es {lastNames[name]} {ages[name]}");
    //}

    //lastNames.Remove("Alberto");
     

    decimal operationResult;
    int typedOption = 0;
    decimal typedNumber1;
    //decimal typedNumber2 = 0;
    int wantToContinueTyped = 1;
    bool wantToContinue = true;
    //decimal[] typedAdtionalNumers = new decimal[1];
    List<decimal> typedAdtionalNumers = new List<decimal>();
    Console.WriteLine(@"Bienvenido a nuestra calculadora Básica
En este proyecto usted va a escoger una opción de la operación que desea realizar
Y posterior a eso podrá escoger los números a los cuales les desea realizar dicha operación.");

    Console.WriteLine("1. Suma \t\t 2. Resta  \t\t 3. Multiplicación  \t\t 4. Divición  \t\t 5. Cerrar");
    Console.Write("Digite un numero del 1 al 5, para indicar la operación que usted desea realizar: ");


    typedOption = Convert.ToInt32(Console.ReadLine());
    //y    o   not
    //&&  ||   !
    /*
    y
    v y v = v
    v y f = f
    f y v = f
    f y f = f

    o
    v o v = v
    v o f = v
    f o v = v
    f o f = f

    not
    not v = f
    not f = v

    */


    //if (! ((typedOption >= 6) && (typedOption <= 0)))
    //{
    //    Console.WriteLine("A ti te dejaron caer cuando chiquito, verdad?");
    //}
    // if (typedOption >= 6 || typedOption < 1)
    //if (typedOption > 5 || typedOption <= 0)
    if (typedOption >= 6 || typedOption <= 0)
    {
        Console.WriteLine("A ti te dejaron caer cuando chiquito, verdad?");
    }
    else
    {

        Console.Write("Digite el primer Número: ");
        typedNumber1 = Convert.ToDecimal(Console.ReadLine());
        //Console.Write("Digite el segundo Número: ");
        //typedNumber2 = Convert.ToDecimal(Console.ReadLine());

        //Console.WriteLine("Deseas agregar más numeros: ");
        //Console.WriteLine("1. Si, 2. No");
        //// wantToContinueTyped = Convert.ToInt32(Console.ReadLine());
        //wantToContinue = Convert.ToInt32(Console.ReadLine()) == 1;

        //int count = 0;
        //while
        while (wantToContinue)
        {
            Console.Write("Digite otro Número: ");
            decimal tempTypedValue = Convert.ToDecimal(Console.ReadLine());
            //typedAdtionalNumers[typedAdtionalNumers.Length - 1] = tempTypedValue;
            ////var dd =  typedAdtionalNumers.Length;
            ////var dd2 =  typedAdtionalNumers.Count();

            //decimal[] tempTypedNumbers = typedAdtionalNumers;
            //typedAdtionalNumers = new decimal[typedAdtionalNumers.Length + 1];
            ////  typedAdtionalNumers[0] = Convert.ToDecimal(Console.ReadLine()); ;

            ////for (int index = tempTypedNumbers.Length; index >= 0; index--)
            //// for (int index = tempTypedNumbers.Length; index > 1; index--) 
            ////for (int index = 0; index < tempTypedNumbers.Length; index++)
            //// for (int i = -1; i <= tempTypedNumbers.Length -1; i++)
            //for (int i = 0; i <= tempTypedNumbers.Length - 1; i++)
            //{
            //    typedAdtionalNumers[i] = tempTypedNumbers[i];
            //}
            typedAdtionalNumers.Add(tempTypedValue);
            Console.WriteLine("Deseas agregar más numeros: ");
            Console.WriteLine("1. Si, 2. No");
            wantToContinue = Convert.ToInt32(Console.ReadLine()) == 1;

        }

        //if (wantToContinue) //== true)
        //{
        //    Console.WriteLine("Deseas agregar más numeros: ");
        //    Console.WriteLine("1. Si, 2. No");
        //    //wantToContinue = true;
        //}
        //else
        //{
        //    //wantToContinue = false;
        //}
        //if (!(wantToContinue)) // == false)
        //{


        //}
        //else
        //{
        //    Console.WriteLine("Deseas agregar más numeros: ");
        //    Console.WriteLine("1. Si, 2. No");
        //    //wantToContinue = false;
        //}

        //if (wantToContinue == true) {
        //    Console.WriteLine("Deseas agregar más numeros: ");
        //    Console.WriteLine("1. Si, 2. No");


        //}
        operationResult = typedNumber1;

        switch (typedOption)
        {
            case 1:
                {
                    // for (int i = 0; i <= typedAdtionalNumers.Length - 1; i++)
                    //for (int i = 0; i <= typedAdtionalNumers.Count() - 1; i++)
                    //for (int i = 0; i <= typedAdtionalNumers.Count - 1; i++)
                    //{
                    //    //  operationResult = operationResult + typedAdtionalNumers[i];
                    //    operationResult += typedAdtionalNumers[i];
                    //};

                    foreach (decimal item in typedAdtionalNumers)
                    {
                        operationResult += item;
                    }
                }

                break;
            case 2:
                {
                    //  operationResult = typedNumber1; 
                    foreach (decimal item in typedAdtionalNumers)
                    {
                        operationResult -= item;
                    }
                }

                break;
            case 3:
                {
                    // operationResult = typedNumber1; 
                    foreach (decimal item in typedAdtionalNumers)
                    {
                        operationResult *= item;
                    }
                }

                break;
            case 4:
                {
                    // operationResult = typedNumber1;  
                    foreach (decimal item in typedAdtionalNumers)
                    {
                        operationResult /= item;
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