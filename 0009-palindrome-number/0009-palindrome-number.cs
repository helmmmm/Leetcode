public class Solution {
    public bool IsPalindrome(int x) {
        string digits = x.ToString();
        string compareDigits = "";

        for (int i = digits.Length - 1; i >= 0; i--){
            compareDigits += digits[i];
        }

        if (digits == compareDigits){
            return true;
        }
        else{
            return false;
        }

    }
}