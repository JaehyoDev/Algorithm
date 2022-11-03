using System;

public class Solution {
    public int solution(int[] common) {
        int answer = 0;

        // a, a+b, a+2b, a+3b...
        // a, ac, ac^2, ac^3...
        
        if (common[2] - common[1] == common[1] - common[0])
        {
            // 등차수열
            answer = common[common.Length - 1] + (common[1] - common[0]);
        }
        else
        {
            // 등비수열
            answer = common[common.Length - 1] * (common[1] / common[0]);
        }
        
        return answer;
    }
}