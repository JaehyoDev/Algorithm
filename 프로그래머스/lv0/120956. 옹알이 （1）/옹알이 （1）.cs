using System;

public class Solution {
    public int solution(string[] babbling) {
        int answer = 0;
        
        string[] arr = {"aya", "ye", "woo", "ma"};
        
        for (int i = 0; i < babbling.Length; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                // 발음이 들어가 있다면 치환
                babbling[i] = babbling[i].Replace(arr[j], " ");
            }
            
            // 공백으로 바꾸어 다음 조건문에서 공백 상태인지 확인
            babbling[i] = babbling[i].Replace(" ", "");
 
            // 공백인 경우 발음이 한 번씩 포함된 것
            if (babbling[i] == "")
            {
                answer++;
            }
        }
        
        return answer;
    }
}