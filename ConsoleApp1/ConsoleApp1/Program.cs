string row1 = "...";
string row2 = "...";
string row3 = "...";
char player =  'x';

bool run = true;
while (run)
{
    
    Console.WriteLine(row1);
    Console.WriteLine(row2);
    Console.WriteLine(row3);
    
    Console.WriteLine("enter row or q for quit");
    string input = Console.ReadLine();
    
    if(input!="q") {
        Console.WriteLine("enter col");
        string inputcol = Console.ReadLine();
        int colno = int.Parse(inputcol);
        colno = colno - 1;
        if (input == "1")
        {
            char[] chars = row1.ToCharArray();
            chars[colno] = player;
            row1 = new string(chars);
        }

        if (input == "2")
        {
            char[] chars = row2.ToCharArray();
            chars[colno] = player;
            row2 = new string(chars);
        }

        if (input == "3")
        {
            char[] chars = row3.ToCharArray();
            chars[colno] = player;
            row3 = new string(chars);
        }

        if (player == 'x')
        {
            player = 'o';
        }
        else { player = 'x'; }
    }
    else
    {
        run = false;
    }
}



