public class Solution {
    public int RomanToInt(string s) {
        // lowercase the strings
        // forloop: index i of string but check the numeral of i+1
        
        int number = 0;

        Dictionary<char, int> romanNumerals = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        for (int i = 0; i < s.Length; i++)
        {
            if (i != s.Length - 1 && romanNumerals[s[i]] < romanNumerals[s[i + 1]])
            {
                number -= romanNumerals[s[i]];
            }
            else
            {
                number += romanNumerals[s[i]];
            }
        }

        return number;



        // s = s.ToLower();
        // int number = 0;
        
        // for(int i = 0; i < s.Length; i++){
        //     if (s[i] == 'i'){
        //         if (i != s.Length -1){
        //             if (s[i+1] == 'v' || s[i+1] == 'x'){
        //                 number --;
        //             }
        //             else{
        //                 number ++;
        //             }
        //         }
        //         else{
        //             number ++;
        //         }
        //     }
        //     else if (s[i] == 'v'){
        //         number += 5;
        //     }
        //     else if (s[i] == 'x'){
        //         if (i != s.Length -1){
        //             if (s[i+1] == 'l' || s[i+1] == 'c'){
        //                 number -= 10;
        //             }
        //             else{
        //                 number += 10;
        //             }
        //         }
        //         else{
        //             number += 10;
        //         }
        //     }
        //     else if (s[i] == 'l'){
        //         number += 50;
        //     }
        //     else if (s[i] == 'c'){
        //         if (i != s.Length -1){
        //             if (s[i+1] == 'd' || s[i+1] == 'm'){
        //                 number -= 100;
        //             }
        //             else{
        //                 number += 100;
        //             }
        //         }
        //         else{
        //             number += 100;
        //         }
        //     }
        //     else if (s[i] == 'd'){
        //         number += 500;
        //     }
        //     else if (s[i] == 'm'){
        //         number += 1000;
        //     }
        //     else{
        //         number += 0;
        //     }
        // }

        // return number;
    }
}