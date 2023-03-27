
delegate void NotificationDelegate(string text);
delegate int OperationDelegate(int X, int Y);

internal class Program
{
    private static void Main(string[] args)
    {

        OperationDelegate operationDelegate = delegate (int firstParameter, int secondParameter) 
        { return firstParameter + secondParameter; } ;

        int result = operationDelegate(1, 5);

        Console.WriteLine(result);


    }

   
    //private static void AddInCOnsole( string text)
    //{
    //    Console.WriteLine(text);
    //}
    //    private static void AddInFile(string text)
    //    {
    //        string path = @"C:\Users\Grinch\Desktop\New folder\Logger.txt";
    //        File.WriteAllText(path, text);
    //    }
}