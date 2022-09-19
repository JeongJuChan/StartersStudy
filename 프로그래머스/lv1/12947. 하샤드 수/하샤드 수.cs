public class Solution {
    public bool solution(int x) {
        bool answer = true;
            char[] chars = x.ToString().ToCharArray();
            int sum = 0;
            foreach (var character in chars)
            {
                sum += int.Parse(character.ToString());
            }

            answer = x % sum == 0;
        return answer;
    }
}