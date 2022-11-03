using System;

public class Solution {
    public int solution(int n, int t) {
        int answer = 0;
        
        // 2마리 1시간은 4마리
        // 4마리가 2시간째 8마리
        // 3마리 1시간 6마리됨
        // 6마리 1시간뒤 12마리됨
        answer = (int) Math.Pow(2, t) * n;
        
        return answer;
    }
}