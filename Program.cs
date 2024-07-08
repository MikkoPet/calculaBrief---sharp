//asks user for a number and limits input to floatable values
float getNumber()
{
    string userInput;
    float outputNumber;
    bool isNumber;

    isNumber = false;
    userInput = string.Empty;

    while (userInput.ToLower() != "x")
    {
        userInput = Console.ReadLine();

        isNumber = float.TryParse(userInput, out outputNumber);

        if (!isNumber)
        {
            Console.WriteLine("Entrée incorrecte, merci d'inscrire un nombre");
            return float.NaN;
        }
        else
        {
            return outputNumber;
        }
    }
    return float.NaN;

}

//functions for mathematical operations
float addMenu(float startNumber, float operatingNumber)
{
    string userInput;
    userInput = "";

    while (userInput.ToLower() != "x")
    {
        //seek NaN values
        if (startNumber != startNumber)
        {
            Console.Write("Entrez le premier nombre de votre opération: ");
            startNumber = getNumber();
        }
        else
        {
            Console.Write("Entrez le nombre à additioner à (" + startNumber + ") ");
            operatingNumber = getNumber();
            
            //only operate non NaN
            if (operatingNumber == operatingNumber)
            {
                startNumber += operatingNumber;

                Console.WriteLine("Le resultat est " + startNumber);
            }

            Console.Write("Entrez X pour retourner au menu, n'importe quelle autre entrée pour continuer à additioner.");
            userInput = Console.ReadLine();
        }
    }
    return startNumber;
}
float subMenu(float startNumber, float operatingNumber)
{
    string userInput;

    userInput = "";

    while (userInput.ToLower() != "x")
    {
        if (startNumber != startNumber)
        {
            Console.Write("Entrez le premier nombre de votre opération: ");
            startNumber = getNumber();
        }
        else
        {
            Console.Write("Entrez le nombre à soustraire à (" + startNumber + ") ");
            operatingNumber = getNumber();
            if (operatingNumber == operatingNumber)
            {
                startNumber -= operatingNumber;

                Console.WriteLine("Le resultat est " + startNumber);
            }

            Console.Write("Entrez X pour retourner au menu, n'importe quelle autre entrée pour continuer à soustraire.");
            userInput = Console.ReadLine();
        }
    }
    return startNumber;
}
float multMenu(float startNumber, float operatingNumber)
{
    string userInput;

    userInput = "";

    while (userInput.ToLower() != "x")
    {
        if (startNumber != startNumber)
        {
            Console.Write("Entrez le premier nombre de votre opération: ");
            startNumber = getNumber();
        }
        else
        {
            Console.Write("Entrez le nombre par lequel multiplier (" + startNumber + ") ");
            operatingNumber = getNumber();
            if (operatingNumber == operatingNumber)
            {
                startNumber *= operatingNumber;

                Console.WriteLine("Le resultat est " + startNumber);
            }

            Console.Write("Entrez X pour retourner au menu, n'importe quelle autre entrée pour continuer à multiplier.");
            userInput = Console.ReadLine();
        }
    }
    return startNumber;
}
float divMenu(float startNumber, float operatingNumber)
{
    string userInput;

    userInput = "";

    while (userInput.ToLower() != "x")
    {
        if (startNumber != startNumber)
        {
            Console.Write("Entrez le premier nombre de votre opération: ");
            startNumber = getNumber();
        }
        else
        {
            Console.Write("Entrez le nombre non-zero par lequel diviser (" + startNumber + ") ");
            operatingNumber = getNumber();

            if (operatingNumber == operatingNumber)
            {
                if (operatingNumber == 0)
                {
                    Console.WriteLine("Merci de ne pas essayer la division par zero.");
                }
                else
                {
                    startNumber /= operatingNumber;

                    Console.WriteLine("Le resultat est " + startNumber);
                }

            }


            Console.Write("Entrez X pour retourner au menu, n'importe quelle autre entrée pour continuer à diviser.");
            userInput = Console.ReadLine();
        }
    }
    return startNumber;
}
float divByMenu(float startNumber, float operatingNumber)
{
    string userInput;

    userInput = "";

    while (userInput.ToLower() != "x")
    {
        //switch values
        operatingNumber = startNumber;

        Console.Write("Quel nombre voulez vous diviser par " + startNumber + " ");

        startNumber = getNumber();

        startNumber /= operatingNumber;
        Console.WriteLine("Le resultat est " + startNumber);

        Console.Write("Entrez X pour retourner au menu, n'importe quelle autre entrée pour continuer à diviser par votre dernier resultat.");
        userInput = Console.ReadLine();
    }

    return startNumber;
}
void biggestNum(float startNumber, float operatingNumber)
{
    string userInput;

    userInput = "";

    while (userInput.ToLower() != "x")
    {
        if (startNumber != startNumber)
        {
            Console.Write("Entrez le premier nombre de votre opération: ");
            startNumber = getNumber();
        }
        else
        {
            Console.Write("Entrez le numéro avec lequel comparer " + startNumber + " ");
            operatingNumber = getNumber();

            Console.WriteLine("Le plus grand nombre est " + Math.Max(startNumber, operatingNumber));
        }
        Console.Write("Entrez X pour retourner au menu, n'importe quelle autre entrée pour continuer à comparer des nombres.");
        userInput = Console.ReadLine();
    }
}

//variables and initial initiation
bool isRunning;
float currentNumber;
float operatingNumber;
string menuChoice;

isRunning = true;
currentNumber = float.NaN;
operatingNumber = float.NaN;

while (isRunning)
{
    Console.WriteLine("----Calculatrice---- \n \n");

    Console.WriteLine(" ______________________________________________");
    Console.WriteLine("|                                              |");
    Console.WriteLine("|  addition                               -- a |");
    Console.WriteLine("|  soustraction                           -- s |");
    Console.WriteLine("|  division                               -- d |");
    Console.WriteLine("|  diviser par votre numero ci dessous   -- d2 |");
    Console.WriteLine("|  le plus grand nombre                   -- g |");   
    Console.WriteLine("|  multiplication                         -- m |");
    Console.WriteLine("|                                              |");
    Console.WriteLine("|  reinitialiser                          -- r |");
    Console.WriteLine("|______________________________________________|");
    Console.WriteLine("\n \n -SORTIR DE L'APPLICATION -- x \n \n");

    
    //seek non NaN for print of current number
    if (currentNumber == currentNumber)
    {
        Console.WriteLine("Le resultat de votre operation la plus récente: " + currentNumber);
    }

    
    menuChoice = Console.ReadLine().ToLower();

    switch (menuChoice)
    {
        case "a":
            currentNumber = addMenu(currentNumber, operatingNumber);
            break;

        case "s":
            currentNumber = subMenu(currentNumber, operatingNumber);
            break;

        case "d":
            currentNumber = divMenu(currentNumber, operatingNumber);
            break;

        case "d2":
            //only operate if there is a number stored already
            if (currentNumber == currentNumber)
            {
                currentNumber = divByMenu(currentNumber, operatingNumber);
            }
            else
            {
                Console.WriteLine("You don't have a number to divide by yet");
            }
            break;

        case "g":
            biggestNum(currentNumber, operatingNumber);
            break;

        case "m":
            currentNumber = multMenu(currentNumber, operatingNumber);
            break;

        case "r":
            currentNumber = float.NaN;
            break;

        case "x":
            isRunning = false;
            break;

        default:
            Console.WriteLine("Entrée incorrecte");
            break;
    }
    Console.Clear();
}