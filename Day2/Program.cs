using System;

namespace day2
{
    class Program
    {
        static void Main(string[] args)
        {
           string []str;
           Console.WriteLine("Enter your Input string");
            string input=Console.ReadLine();
            str=input.Split(null);
            CheckisPalindrome(input);
           for(int i=0;i<str.Length;i++)
           {
             char[] chararry=str[i].ToCharArray();
             Array.Reverse(chararry);
             str[i]=new string(chararry);
           }
           input =string.Join(" ",str);
           Console.Write(input);
           
        }

        static void CheckisPalindrome(string input)
        {
            int len,flag=1;
            len= input.Length;
            char[] chararry=input.ToCharArray(); 
            for(int i=0;i<=len/2;i++){
           if (chararry[i]!=chararry[len-1-i]) 
           {
            flag = 0;
            break;
           }
            }
           if(flag==1)
           Console.WriteLine("Given string is {0} palindrome" ,input);
           else
           Console.WriteLine("Given string is {0} is not palindrome" ,input);

        }
    }
}
