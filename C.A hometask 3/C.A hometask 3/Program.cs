// See https://aka.ms/new-console-template for more information
char[] upperLetters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
char[] lowerLetters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
while (true)
{

    Console.WriteLine("Convert to upper letters");
    Console.WriteLine("Convert to lower letters");
    Console.WriteLine("Find the letter from text");
    Console.WriteLine("Please choose the command : ");
   
    string requiredCommand=Console.ReadLine();
    if(requiredCommand == "Convert to upper letters")
    {
        Console.WriteLine("Please enter your text : ");
        string requiredText = Console.ReadLine();
        string result = GetUpperLetters(requiredText, upperLetters, lowerLetters);
        Console.WriteLine(result);
        Console.WriteLine();

    }
    else if(requiredCommand== "Convert to lower letters")
    {
        Console.WriteLine("Please enter your text : ");
        string requiredText = Console.ReadLine();
        string result=GetLowerLetters(requiredText, lowerLetters, upperLetters); 
        Console.WriteLine(result);
        Console.WriteLine();
    }
    else if(requiredCommand== "Find the letter from text")
    {
        Console.WriteLine("Choose the default mode(yes) or not(no) : ");
        string requiredMode=Console.ReadLine();
        bool isSensitiveCase=false;
        if (requiredMode == "yes")
        {
            isSensitiveCase = true;
        }
        else if(requiredMode == "no")
        {
            isSensitiveCase= false;
        }
        else
        {
            Console.WriteLine("Not found command");
            break;
        }
        Console.WriteLine("Please enter your text : ");
        string requiredText=Console.ReadLine();
        Console.WriteLine("Please enter your letter : ");
        string requiredLetter=Console.ReadLine();
        bool result = isLetterExists(requiredText, requiredLetter, isSensitiveCase);
        Console.WriteLine(result);
        Console.WriteLine();


    }
}
static string GetUpperLetters(string requiredText, char[] upperLetters,char[] lowerLetters)
{
    for (int i = 0; i < upperLetters.Length; i++)
    {
        requiredText = requiredText.Replace(lowerLetters[i], upperLetters[i]);
    }
    return requiredText;
}

static string GetLowerLetters(string requiredText, char[] lowerLetters, char[] upperLetters)
    {
        for (int i = 0; i < lowerLetters.Length; i++)
        {
            requiredText = requiredText.Replace(upperLetters[i], lowerLetters[i]);
        }
        return requiredText;
    }

static bool isLetterExists(string requiredText,  string requiredLetter, bool isSensitiveCase)
{
    for(int i = 0; i < requiredText.Length; i++)
    {
        if (isSensitiveCase == false)
        {   
            requiredText=requiredText.ToLower();
            requiredLetter=requiredLetter.ToLower();
            if(requiredText[i]==requiredLetter[0])
            {
                return true;
            }
        }
        else if(isSensitiveCase == true)
        {
            if (requiredText[i] == requiredLetter[0])
            {
                return true;
            }
        }
    }return false;
}
