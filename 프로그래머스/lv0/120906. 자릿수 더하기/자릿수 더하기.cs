using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        // 12를 10으로 나누고 몫과 나머지를 더한다.
        
        // 103을 10으로 나누고 몫은 10 나머지 3
        // 10을 10으로 나누고 몫은 1 나머지 0
        // 나머지를 반복해서 다 더해준다.
        // 몫은 10보다 작으면 그만.
        // 그래서 마지막 몫을 더해준다.
        
        while (n > 10) {
            answer += n % 10;
            n = n / 10;
        }
        
        answer += n;
        
        return answer;
    }
}