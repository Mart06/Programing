using System.Xml;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] tokens = new string[] { "10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+" };
        Stack<int> stc = new Stack<int>();

        for (int i = 0; i < tokens.Length; i++)
        {            
            switch (tokens[i])
            {
                case "+": 
                    int result = stc.Pop() + stc.Pop();                    
                    stc.Push(result);
                    break;

                case "-":
                    int firstNum2 = stc.Pop();
                    int secondNum2 = stc.Pop();
                    int result2 = secondNum2 - firstNum2;
                    stc.Push(result2);
                    break;

                case "*":
                    int result3 = stc.Pop() * stc.Pop();
                    stc.Push(result3);
                    break;

                case "/":
                    int firstNum = stc.Pop();
                    int secondNum = stc.Pop();
                    int result4 = secondNum / firstNum;
                    stc.Push(result4);
                    break;
                default:
                    stc.Push(int.Parse(tokens[i]));
                    break;
            }
            
        }
        Console.WriteLine(string.Join(" ", stc));
    }
}