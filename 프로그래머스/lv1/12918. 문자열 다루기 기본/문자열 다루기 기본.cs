public class Solution {
    public bool solution(string s) {
        bool isNum = true;
            int num = 0;
            
            if (s.Length == 4 || s.Length == 6)
            {
                if (!int.TryParse(s, out num))
                {
                    isNum = false;
                }
            }
            else
            {
                isNum = false;
            }
        return isNum;
    }
}