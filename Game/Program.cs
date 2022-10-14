string[,] menu = {{"@","Начать игру"," "},
                  {" ","Выбор уровня"," "},
                  {" ","Выход"," "}};
string[,] matrix1 = {{" "," "," "," "," "," "},
                     {" ","|"," "," "," "," "},
                     {" ","|","@"," "," "," "},
                     {" "," "," "," ","$"," "},
                     {" "," "," "," "," "," "},
                     {" "," "," "," "," "," "}};
int coins = 0;
int menuX = 0;
int menuY = 0;
int SelectMenuPlayer()
{
    int indexMenu = 0;
    ConsoleKeyInfo userKeyTab = Console.ReadKey();
    while(userKeyTab.Key != ConsoleKey.Enter)
    {
        menu[menuY,menuX] = " ";
        if (userKeyTab.Key == ConsoleKey.W && indexMenu > 0)
        {
            indexMenu--;
            menuY--;
        }
        if (userKeyTab.Key == ConsoleKey.S && indexMenu < 2)
        {
            indexMenu++;
            menuY++;
        }
        menu[menuY,menuX] = "@";
        MatrixWrite(menu);
        userKeyTab = Console.ReadKey();
    }
}
void MatrixWrite(string[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           Console.Write(matrix[i,j] + " ");
        }
    Console.WriteLine();
    }
    Console.WriteLine("Кол-во очков: " + coins);
}
string[,] ItemFoodMatrix(int x, int y, string[,] matrix)
{
    while(matrix[y,x] == "$")
    {   
        matrix1[y,x] = " ";
        int matX = new Random().Next(0, matrix.GetLength(1));
        int matY = new Random().Next(0, matrix.GetLength(0));
        while (matrix1[y,x] == "|")
        {
            matrix1[y,x] = "|";
            matX = new Random().Next(0, matrix.GetLength(1));
            matY = new Random().Next(0, matrix.GetLength(0));
        }
        matrix[matY,matX] = "$";
        coins++;
    }
    return matrix;
}
bool Barier(int x, int y)
{
    while(matrix1[y,x] == "|")
    {
        return false;
    }
    return true;
}

int x = 2;
int y = 2;
while (true)
{
    Console.Clear();
    MatrixWrite(matrix1);
    matrix1[y,x] = " ";
    ConsoleKeyInfo userKeyTab = Console.ReadKey();
    if(userKeyTab.Key == ConsoleKey.W) if(Barier(x,y-1))y--;
    if(userKeyTab.Key == ConsoleKey.S) if(Barier(x,y+1))y++;
    if(userKeyTab.Key == ConsoleKey.A) if(Barier(x-1,y))x--;
    if(userKeyTab.Key == ConsoleKey.D) if(Barier(x+1,y))x++;

    if(y >= matrix1.GetLength(0)) y = 0;
    if(y <= 0) y = matrix1.GetLength(0)-1;
    
    if(x >= matrix1.GetLength(1)) x = 0;
    if(x <= 0) x = matrix1.GetLength(1)-1;
    matrix1 = ItemFoodMatrix(x,y, matrix1);
    matrix1[y,x] = "@"; 
}