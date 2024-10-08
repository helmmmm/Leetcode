public class Solution {
    public string LongestCommonPrefix(string[] strs) 
    {
        int minLength = strs.Min(s => s.Length);
        string res = strs.First(s => s.Length == minLength);

        foreach(string str in strs)
        {
            for (int j = 0; j < minLength; j++)
            {
                if (str[j] != res[j])
                {
                    minLength = j;
                    break;
                }
            }
        }
        if(minLength == 0)
        {
            return "";
        }
        else 
        {
            return res.Substring(0, minLength);
        }
    }
}