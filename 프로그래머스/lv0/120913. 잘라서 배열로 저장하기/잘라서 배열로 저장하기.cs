using System;

public class Solution {
    public string[] solution(string my_str, int n) {
        string[] answer =
            new string[my_str.Length % n == 0 ?
                       my_str.Length / n : my_str.Length / n + 1];
    
        for (int i = 0; i < my_str.Length / n; i++)
        {
            answer[i] = my_str.Substring(n * i, n);
        }
        
        if (my_str.Length % n > 0)
        {
            answer[my_str.Length / n] =
                my_str.Substring(my_str.Length - (my_str.Length % n), my_str.Length % n);
        }
        
        return answer;
    }
}