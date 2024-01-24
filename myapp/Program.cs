Console.Write("Ingrese un año: ");
        int year = int.Parse(Console.ReadLine());

        // Llamar a la función para verificar si el año es bisiesto
        if (EsBisiesto(year))
        {
            Console.WriteLine($"{year} es un año bisiesto.");
        }
        else
        {
            Console.WriteLine($"{year} no es un año bisiesto.");
        }

        

static bool EsBisiesto(int year)
    {
        // Un año es bisiesto si es divisible por 4
        // Pero no es bisiesto si es divisible por 100, a menos que también sea divisible por 400
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }




