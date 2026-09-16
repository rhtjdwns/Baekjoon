#include <string>
#include <vector>

using namespace std;

int solution(int n, vector<int> lost, vector<int> reserve) {
    int answer = 0;
    vector<int> clothes(n, 1);
    
    for (int i = 0; i < lost.size(); ++i)
    {
        clothes[lost[i] - 1] -= 1;
    }
    for (int i = 0; i < reserve.size(); ++i)
    {
        clothes[reserve[i] - 1] += 1;
    }
    
    for (int i = 0; i < n; ++i)
    {
        if (clothes[i] == 0)
        {
            if (i - 1 >= 0 && clothes[i - 1] == 2)
            {
                clothes[i - 1] -= 1;
                clothes[i] += 1;
            }
            else if (i + 1 < n && clothes[i + 1] == 2)
            {
                clothes[i + 1] -= 1;
                clothes[i] += 1;
            }
        }
    }
    
    for (int i = 0; i < n; ++i)
    {
        if (clothes[i] >= 1) answer++;
    }
    
    return answer;
}