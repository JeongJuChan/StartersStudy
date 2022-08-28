using System;
using System.Text;

public class Solution {
    public int solution(string s) {
        string[] strArr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            char[] chars = s.ToCharArray();
            StringBuilder stringBuilder = new StringBuilder();
            StringBuilder stringBuilder2 = new StringBuilder();
            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsDigit(chars[i]))
                {
                    stringBuilder2.Append(chars[i]);
                    continue;
                }
                stringBuilder.Append(chars[i]);
                for (int j = 0; j < strArr.Length; j++)
                {
                    if (stringBuilder.ToString().Equals(strArr[j]))
                    {
                        stringBuilder2.Append(j);
                        stringBuilder.Clear();
                    }
                }
            }
        return int.Parse(stringBuilder2.ToString());
    }
}