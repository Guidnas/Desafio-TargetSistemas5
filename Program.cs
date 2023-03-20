using System;

/*
 * 5) Escreva um programa que inverta os caracteres de um string.



IMPORTANTE:

a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;

b) Evite usar funções prontas, como, por exemplo, reverse;

 */

class Program
{
    static void Main(string[] args)
    {
        string inputString = "Exemplo de string para ser invertida.";
        char[] charArray = inputString.ToCharArray();

        int start = 0;
        int end = charArray.Length - 1;

        while (start < end)
        {
            char temp = charArray[start];
            charArray[start] = charArray[end];
            charArray[end] = temp;

            start++;
            end--;
        }

        string reversedString = new string(charArray);
        Console.WriteLine(reversedString);
    }
}
