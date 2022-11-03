using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        double x = Math.Sqrt(n);
        answer = (x % 1 == 0) ? 1 : 2;
        
        return answer;
    }
}