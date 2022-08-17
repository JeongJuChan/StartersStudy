using System;
using System.Text;

public class Solution {
    public string solution(int[] numbers) {
            string[] strArr = new string[numbers.Length]; 
            for (int i = 0; i < numbers.Length; i++)
            {
                strArr[i] = numbers[i].ToString();
            }
            Array.Sort(strArr, (x, y) => string.Compare(x + y, y + x));
            Array.Reverse(strArr);
            /*for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    string temp1 = numbers[j].ToString() + numbers[j + 1].ToString();
                    string temp2 = numbers[j + 1].ToString() + numbers[j].ToString();
                    if (string.Compare(temp1, temp2) < 0)
                    {
                        int tempNum = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = tempNum;
                    }
                }
            }*/
            StringBuilder result = new StringBuilder();
            
            for (int i = 0; i < numbers.Length; i++)
            {
                if (strArr[0] == "0")
                {
                    result.Append(0);
                    break;
                }
                result.Append(strArr[i]);
            }
        return result.ToString();
    }
}