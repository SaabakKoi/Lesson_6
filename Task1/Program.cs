void Main()
{
    char[,] symbols = 
    {
    {'a', 'b', 'c', 'd'},
    {'e', 'f', 'g', 'h'}
    };

    string myString = makeMyString(symbols); 
    PrintResult(myString);
}

string makeMyString(char[,] array){

    string str = "";

    for(int i = 0;i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            str += array[i,j];
        }
    }
    return str;
}

void PrintResult(string str){
    System.Console.WriteLine(str);
}

Main();