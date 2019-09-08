using PalindromeAnagrama.Utils;

namespace PalindromeAnagrama {
    class Program {
        static void Main (string[] args) {
            //ESCREVER A PALAVRA DESEJADA
            char[] input = "tactcoa".ToCharArray ();
            System.Console.WriteLine (Palindrome.IsPalindrome (input));
        }
    }
}