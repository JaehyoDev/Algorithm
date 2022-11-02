using System;
using System.Text;

public class Solution {
    public int solution(int[] array) {
        int answer = 0;
        
        string[] strArray = Array.ConvertAll(array, x => x.ToString());  
        
        StringBuilder stringBuilder = new StringBuilder();

        for (int i = 0; i < strArray.Length; i++)
        {
            stringBuilder.Append(strArray[i]);
        }

        string strArrayToString = stringBuilder.ToString();
        
        for (int i = 0; i < strArrayToString.Length; i++)
        {
            String substring = strArrayToString.Substring(i, 1);
            if (substring == "7")
            {
                answer++;
            }
        }
                
        return answer;
    }
}