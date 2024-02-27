void Main(){

    string myString = "Hello there !";
    var array = myString.Split();
    Array.Reverse(array);
    System.Console.WriteLine(string.Join(" ", array));

}



Main();