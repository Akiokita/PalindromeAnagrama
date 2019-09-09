using PalindromeAnagrama.Utils;

namespace PalindromeAnagrama {
    class Program {
        static void Main (string[] args) {
            //ESCREVER A CADEIA DE CARACTERES DESEJADA
            char[] input = "tactcoa".Replace(" ", "").ToCharArray ();
            System.Console.WriteLine (Palindrome.IsPalindrome (input));
        }
    }
}