public class Solution {
    public bool IsPalindrome(int x) {
        string first = x.ToString();             //turn to string (easy to reverse)
        char[] charArr = first.ToCharArray();   //the original target
        char[] reverseArr = first.ToCharArray();   

        Array.Reverse(reverseArr );                 
     
        return charArr.SequenceEqual(reverseArr); //compare two array
    }
}