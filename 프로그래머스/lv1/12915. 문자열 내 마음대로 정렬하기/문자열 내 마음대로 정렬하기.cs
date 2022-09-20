using System.Collections.Generic;
using System.Linq;
public class Solution {
    public string[] solution(string[] strings, int n) {
        var query = from data in strings
                //data의 n번째 단어기준으로 오름차순 정렬
                orderby data[n], data.Substring(0, data.Length)
                select data;
            List<string> list = new List<string>();
            foreach (var item in query)
            {
                list.Add(item);
            }
        return list.ToArray();
    }
}