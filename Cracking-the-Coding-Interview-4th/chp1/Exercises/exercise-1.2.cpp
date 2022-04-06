#include <bits/stdc++.h>

using namespace std;

void reverseStr(string& str)
{
    int n = str.length();
    for (int i = 0; i < n /2; i++)
        swap(str[i], str[n - i - 1]);
}

char* reverseConstStr(char const* str)
{
    int n = strlen(str);

    char* str1 = new char[n+1];
    strcpy(str1, str);

    for(int i = 0, j = n -1; i < j; i++, j--)
        swap(str1[i], str1[j]);

    return str1;
}

int main()
{
    string str = "geeksforgeeks";
    string str1 = "Impecable";
    const char *str2 = "Meticulous";
    
    reverseStr(str);

    /* Using built in reverse() function*/ 
    reverse(str1.begin(), str1.end());

    char* str21 = reverseConstStr(str2);

    cout << str  << "\n" << str1 << "\n" << str21;
    return 0;
}

/**
 Output:  
   skeegrofskeeg
   elbacepmI
   suoluciteM
 Online Resource:  
   https://www.geeksforgeeks.org/reverse-a-string-in-c-cpp-different-methods/
 */