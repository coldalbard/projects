int size1 = 4;
int size2 = 4;

// Функция для заполнения двумерного массива
string[,] CreateXOMassiv(int size1, int size2)
{
    string[,] xo_massiv = new string[size1, size2];
    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2; j++)
        {
            xo_massiv[i, j] = ".";
            xo_massiv[i, 0] = $"{i}";
            xo_massiv[0, j] = $"{j}";
        }
    }
    return xo_massiv;
}

// Функция для вывода массива на экран
void Print3dArray(string[,] xo_massiv)
{
    for (int i = 0; i < xo_massiv.GetLength(0); i++)
    {
        for (int j = 0; j < xo_massiv.GetLength(1); j++)
        {
            Console.Write($"{xo_massiv[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Функция для выполнения ходов игроком X
string[,] TakeInputPlayer1(string[,] xo_massiv)
{
    int index = 1;
    if (ChekWin(xo_massiv) != "Victory - Player 1" && ChekWin(xo_massiv) != "Victory - Player 2" && ChekWin(xo_massiv) != "Draw!"){
        for (int i = 0; i < index; i++)
        {
            index++;
            Console.Write("Enter the line you want to put [X] in: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the column you want to put [X] in: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            if (xo_massiv[x1, x2] == "x" || xo_massiv[x1, x2] == "o" || x1 > 3 || x1 < 1 || x2 > 3 || x2 < 1) TakeInputPlayer1(xo_massiv);
            else
            {
                xo_massiv[x1, x2] = "x";
                Console.WriteLine();
                Print3dArray(xo_massiv);
                Console.WriteLine();
                TakeInputPlayer2(xo_massiv);
            }
            if (ChekWin(xo_massiv) == "Victory - Player 1" || ChekWin(xo_massiv) == "Victory - Player 2" || ChekWin(xo_massiv) == "Draw!") return xo_massiv;
        }
    }
    return xo_massiv;
}

// Функция для выполенения ходов игроком O
string[,] TakeInputPlayer2(string[,] xo_massiv){
    int index = 1;
    if (ChekWin(xo_massiv) != "Victory - Player 1" && ChekWin(xo_massiv) != "Victory - Player 2" && ChekWin(xo_massiv) != "Draw!"){
        for(int i = 0; i < index; i++){
            index++;
            Console.Write("Enter the line you want to put [O] in: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the column you want to put [O] in: ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            if(xo_massiv[y1, y2] == "x" || xo_massiv[y1, y2] == "o" || y1 > 3 || y1 < 1 || y2 > 3 || y2 < 1) TakeInputPlayer2(xo_massiv);
            else
            {
                xo_massiv[y1, y2] = "o";
                Console.WriteLine();
                Print3dArray(xo_massiv);
                TakeInputPlayer1(xo_massiv);
            }
            if (ChekWin(xo_massiv) == "Victory - Player 1" || ChekWin(xo_massiv) == "Victory - Player 2" || ChekWin(xo_massiv) == "Draw!") return xo_massiv;
        }
    }
    return xo_massiv;
}


// Функция для того чтобы узнать победителя
string ChekWin(string[,] xo_massiv)
{
    string Player = "-1";
    for (int i = 0; i < xo_massiv.GetLength(0); i++)
    {
        for (int j = 0; j < xo_massiv.GetLength(1); j++)
        {
            if (xo_massiv[1, 1] != "." && xo_massiv[1, 2] != "." && xo_massiv[1, 3] != "."
                && xo_massiv[2, 1] != "." && xo_massiv[2, 2] != "." && xo_massiv[2, 3] != "."
                && xo_massiv[3, 1] != "." && xo_massiv[3, 2] != "." && xo_massiv[3, 3] != "."
            && Player != "Victory - Player 2" && Player != "Victory - Player 1") Player = "Draw!";

            else if (xo_massiv[1, 1] == "o"
            && xo_massiv[2, 2] == "o" && xo_massiv[3, 3] == "o") Player = "Victory - Player 2";

            else if (xo_massiv[1, 3] == "o"
            && xo_massiv[2, 2] == "o" && xo_massiv[3, 1] == "o") Player = "Victory - Player 2";

            else if (xo_massiv[1, 1] == "x"
            && xo_massiv[2, 2] == "x" && xo_massiv[3, 3] == "x") Player = "Victory - Player 1";

            else if (xo_massiv[1, 3] == "x"
            && xo_massiv[2, 2] == "x" && xo_massiv[3, 1] == "x") Player = "Victory - Player 1";

            else if (xo_massiv[1, 1] == "o"
                && xo_massiv[1, 2] == "o"
                && xo_massiv[1, 3] == "o"
                || xo_massiv[2, 1] == "o"
                && xo_massiv[2, 2] == "o"
                && xo_massiv[2, 3] == "o"
                || xo_massiv[3, 1] == "o"
                && xo_massiv[3, 2] == "o"
                && xo_massiv[3, 3] == "o"
                || xo_massiv[1, 1] == "o"
                && xo_massiv[2, 1] == "o"
                && xo_massiv[3, 1] == "o"
                || xo_massiv[1, 2] == "o"
                && xo_massiv[2, 2] == "o"
                && xo_massiv[3, 2] == "o"
                || xo_massiv[1, 3] == "o"
                && xo_massiv[2, 3] == "o"
                && xo_massiv[3, 3] == "o") Player = "Victory - Player 2";

            else if (xo_massiv[1, 1] == "x"
                && xo_massiv[1, 2] == "x"
                && xo_massiv[1, 3] == "x"
                || xo_massiv[2, 1] == "x"
                && xo_massiv[2, 2] == "x"
                && xo_massiv[2, 3] == "x"
                || xo_massiv[3, 1] == "x"
                && xo_massiv[3, 2] == "x"
                && xo_massiv[3, 3] == "x"
                || xo_massiv[1, 1] == "x"
                && xo_massiv[2, 1] == "x"
                && xo_massiv[3, 1] == "x"
                || xo_massiv[1, 2] == "x"
                && xo_massiv[2, 2] == "x"
                && xo_massiv[3, 2] == "x"
                || xo_massiv[1, 3] == "x"
                && xo_massiv[2, 3] == "x"
                && xo_massiv[3, 3] == "x") Player = "Victory - Player 1";
        }
    }
    return Player;
}

string[,] xo_massiv = CreateXOMassiv(size1, size2);
Print3dArray(xo_massiv);
xo_massiv = TakeInputPlayer1(xo_massiv);
xo_massiv = TakeInputPlayer2(xo_massiv);
string Player = ChekWin(xo_massiv);


Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(Player);
Console.ForegroundColor = ConsoleColor.White;

