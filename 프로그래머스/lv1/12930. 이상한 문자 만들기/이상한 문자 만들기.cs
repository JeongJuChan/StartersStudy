using System;
using System.Text;
public class Solution {
    public string solution(string s) {
        string[] strs = s.Split();
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < strs.Length; i++)
            {
                char[] chars = strs[i].ToCharArray();
                for (int j = 0; j < strs[i].Length; j++)
                {
                    if (j % 2 != 0)
                        chars[j] = Char.ToLower(chars[j]);
                    else
                        chars[j] = Char.ToUpper(chars[j]);
                }
                if (i == strs.Length - 1)
                    stringBuilder.Append(chars);
                else
                    stringBuilder.Append(new string(chars) + " ");
            }
        return stringBuilder.ToString();
    }
}