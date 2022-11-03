using System;

public class Solution {
    public int solution(int M, int N) {
        int answer = 0;
        
        // 2x2 : (2-1) + 2 = 3
        // 3x2 가로로 먼저 자른 경우 : (3-1)*2 + (2-1) = 5
        // 3x2 세로로 먼저 자른 경우 : (3-1) + 3*(2-1) = 5
        // 가로로 먼저 자른 경우 : (M - 1) * N + (N - 1) = MN - N + N - 1 = MN - 1
        // 세로로 먼저 자른 경우 : (M - 1) + M * (N - 1) = M - 1 + MN - M = MN - 1
        
        answer = M * N - 1;
        
        return answer;
    }
}