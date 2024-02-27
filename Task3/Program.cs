void Main ()
{
    string myString = "sghnojs";
    
    System.Console.WriteLine(IsPalindrome(myString));
}

bool IsPalindrome(string str){
    char[] charArray = str.ToCharArray();
    Array.Reverse(charArray);

    return string.Equals(str, new string(charArray));
}

Main();