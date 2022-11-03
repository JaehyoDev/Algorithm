using System;
using System.Linq;

public class Solution {
    public string solution(string my_string) {
        string answer = "";     
        string lowerResult = "";
        
        lowerResult = my_string.ToLower();
        answer = String.Concat(lowerResult.OrderBy(cha => cha));
        return answer;
    }
}