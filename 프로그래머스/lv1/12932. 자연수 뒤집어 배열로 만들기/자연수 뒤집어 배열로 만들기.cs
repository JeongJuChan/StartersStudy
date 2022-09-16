using System.Linq;
public class Solution {
    public int[] solution(long n) {
        char[] chars = n.ToString().ToCharArray();
            int[] answer = new int[chars.Length];
            for (int i = 0; i < chars.Length / 2; i++)
            {
                char temp = chars[i];
                chars[i] = chars[chars.Length - i - 1];
                chars[chars.Length - i - 1] = temp;
            }
            for (int i = 0; i < chars.Length; i++)
            {
                answer[i] = int.Parse(chars[i].ToString());
            }
        return answer;
    }
}