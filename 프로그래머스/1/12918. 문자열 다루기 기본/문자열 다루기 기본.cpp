#include <string>
#include <vector>
#include <iostream>

using namespace std;

bool solution(string s) {
    bool answer = false;
    int size = s.size();
    
    if (size == 4 || size == 6) answer = true;
    
    if (answer)
    {
        for (int i = 0; i < size; ++i)
        {
            if (!isdigit(s[i]))
            {
                answer = false;
                break;
            }
        }
    }
    
    return answer;
}