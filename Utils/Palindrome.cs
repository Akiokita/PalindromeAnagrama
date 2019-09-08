namespace PalindromeAnagrama.Utils {
    public static class Palindrome {

        public static bool IsPalindrome (char[] input) {
            var permutations = Permutation.GetPermutations (input);
            foreach(var permutation in permutations){
                if (ArrayIsPalindrome(permutation)){
                    return true;
                }
            }
            return false;
        }
        private static bool ArrayIsPalindrome(char[] input){
            int arrayCount = input.Length;
                for (int i = 0; i < arrayCount / 2; i++) {
                    if (input[i] != input[arrayCount - i - 1]) {
                        return false;
                    }
                }
            return true;
        }
    }
}