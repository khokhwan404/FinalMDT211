class Program
{
    public static Stack<char> leftChar = new Stack<char>();
    public static Stack<char> rightChar = new Stack<char>();
    static void InputChar()
    {
        char inputChar;
        while(true)
        {
            inputChar = char.Parse(Console.ReadLine());
            if(inputChar == '?')
            {
                break;
            }
            else
            {
                if (inputChar == '(')
                {
                    leftChar.Push(inputChar);
                }
                else
                {
                    rightChar.Push(inputChar);
                }
            }
        }
    }

    static void Main(string[] args)
    {
        InputChar();
        
        if (leftChar.GetLength() == rightChar.GetLength())
        {
            Console.WriteLine("Valid");
        }
        else 
        {
            Console.WriteLine("Invalid");
        }
    }
}
