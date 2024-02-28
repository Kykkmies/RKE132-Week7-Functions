Console.WriteLine("Enter a word");
string userInput = Console.ReadLine();


PrintAnyWord(userInput);//userInput - argument

static void PrintAnyWord(string anyString) //anyString - parameter 
{
    for (int i = 0; i < 5;  i++)
    {
        anyString = anyString.ToUpper();
        Console.WriteLine(anyString);
    }
}