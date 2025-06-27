using System;

public class Solution {
    public int solution(int[] diffs, int[] times, long limit) {
        int n = diffs.Length;
        
        int left = 1;
        int right = 0;
        
        for (int i = 0; i < n; i++)
        {
            right = Math.Max(right, diffs[i]);
        }
        
        int answer = right;
        
        while (left <= right)
        {
            int mid = (left + right) / 2;
            
            if (CanSolveAllPuzzles(diffs, times, mid, limit))
            {
                answer = mid;
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }
        
        return answer;
    }
    
    public bool CanSolveAllPuzzles(int[] diffs, int[] times, int level, long limit)
    {
        long totalTime = 0;
        int n = diffs.Length;
        
        for (int i = 0; i < n; i++)
        {
            int diff = diffs[i];
            int timeCur = times[i];
            int timePrev = (i > 0) ? times[i - 1] : 0;
            
            if (diff <= level)
            {
                // 퍼즐을 틀리지 않고 해결
                totalTime += timeCur;
            }
            else
            {
                // 퍼즐을 틀리는 횟수 계산
                int mistakes = diff - level;
                
                // 틀릴 때마다: 현재 퍼즐 시간 + 이전 퍼즐 재시도 시간
                totalTime += (long)mistakes * (timeCur + timePrev);
                
                // 마지막에 성공적으로 해결
                totalTime += timeCur;
            }
            
            // 제한 시간을 초과하면 false 반환
            if (totalTime > limit)
                return false;
        }
        
        return true;
    }
}