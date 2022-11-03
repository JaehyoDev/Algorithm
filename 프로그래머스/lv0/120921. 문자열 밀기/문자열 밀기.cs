using System;

public class Solution {
    public int solution(string A, string B) {
        int answer = 0;

        char[] chars = A.ToCharArray();
        char temp = chars[chars.Length - 1];

        for (int j = 0; j < chars.Length; j++)
        {
            A = new string(chars);

            if (A == B)
            {
                answer = j;
                break;
            }
            else
            {
                answer = -1;
            }

            temp = chars[chars.Length - 1];
            for (int i = chars.Length; i > 1; i--)
            {
                chars[i - 1] = chars[i - 2];
            }
            chars[0] = temp;
        }
        
        return answer;
    }
}