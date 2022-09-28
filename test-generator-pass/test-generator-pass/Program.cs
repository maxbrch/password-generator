using System;

public class HelloWorld
{
    enum CHAR_TYPES
    {
        FIRST_TYPE,
        NUMBERS = FIRST_TYPE,
        LETTERS,
        SYMBOLS,
        TYPES_TOTAL
    }
    public static void Main(string[] args)
    {
        //   Random random = new Random();
        Console.Write("Typing lenght password: ");
        string userlenthtstr = Console.ReadLine();
        int userlenght;
        int.TryParse(userlenthtstr, out userlenght);

        string[] password = new string[userlenght];
        string[] chars = new string[] { "!", "^", "@", "$", "&", "(", ")" };
        string[] letters = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        string[] num = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

        string[] strpassword = new string[] { };
        // What usesd in password
        // Lenght
        /* Console.Write("Typing lenght password: ");
         string lenthtstr = Console.ReadLine();
         int lenght;
         int.TryParse(lenthtstr, out lenght);
         Console.WriteLine(lenght.GetType());
         Console.WriteLine(lenght);*/

        // Use Littres    
        Console.Write("Use Littres (True) / (False): ");
        string littresstr = Console.ReadLine();
        bool littres;
        bool.TryParse(littresstr, out littres);
        Console.WriteLine(littres.GetType());
        Console.WriteLine(littres);

        // Use Num    
        Console.Write("Use numbers (True) / (False): ");
        string strnumbers = Console.ReadLine();
        bool numbers;
        bool.TryParse(strnumbers, out numbers);
        Console.WriteLine(numbers.GetType());
        Console.WriteLine(numbers);

        // Use Symbol
        Console.Write("Use symbol (True) / (False): ");
        string symbolstr = Console.ReadLine();
        bool symbol;
        bool.TryParse(symbolstr, out symbol);
        Console.WriteLine(symbol.GetType());
        Console.WriteLine(symbol);

        Random random = new Random();


        for (int i = 0; i < password.Length; i++)
        {
            CHAR_TYPES vubir = (CHAR_TYPES)random.Next((int)CHAR_TYPES.FIRST_TYPE, (int)CHAR_TYPES.TYPES_TOTAL);
            if (numbers == true && vubir == CHAR_TYPES.NUMBERS)
            {
                int n = random.Next(0, num.Length);
                password[i] = Convert.ToString(num[n]);
            }

            if (littres == true && vubir == CHAR_TYPES.LETTERS)
            {
                int t = random.Next(0, letters.Length);
                password[i] = Convert.ToString(letters[t]);
            }

            if (symbol == true && vubir == CHAR_TYPES.SYMBOLS)
            {
                int g = random.Next(0, chars.Length);
                password[i] = Convert.ToString(chars[g]);
            }
        }


        for (int f = 0; f < password.Length; f++)
        {
            Console.Write("=");
        }
        Console.WriteLine(" ");

        if (symbol == false && littres == false && symbol == false)
        {
            Console.WriteLine("ERORR: YOU HAVE NOT SELECT");
        }
        else
        {
            for (int i = 0; i < password.Length; i++)
                Console.Write(password[i]);

        }

    }
}