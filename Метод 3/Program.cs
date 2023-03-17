// See https://aka.ms/new-console-template for more information
string Method4(int count, string text)  
{  
    int i = 0; 
    String result = String.Empty;

    while ( i<count)
{
    result =result + text;
    i++;
}
    return result;
}

String res = Method4(10, "asdf");
Console.WriteLine(res); 

