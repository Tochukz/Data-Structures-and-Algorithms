/**
  Have the function CodelandUsernameValidation(str) take the str parameter being passed and determine if the 
  string is a valid username according to the following rules:
1. The username is between 4 and 25 characters.
2. It must start with a letter.
3. It can only contain letters, numbers, and the underscore character.
4. It cannot end with an underscore character.

If the username is valid then your program should return true, otherwise return  false.
Examples
Input: "aa_"
Output: false
Input: "u__hello_world123"
Output: true
*/

using System.Text.RegularExpressions;

class UsernameValidation {
   
    public bool Validate(string username) 
    {  
        string letters = "abcdefghijklmnopqrstuvwxyz";
        string numbers = "0123456789";
        string lettersNumbers = letters + numbers + "_";
        int len = username.Length;
        char firstChar = username[0];
        char lastChar = username[len-1];
        if (len < 4 || len > 25) {
            return false;
        } else if (!char.IsLetter(firstChar)) {
            return false;
        } else if (lastChar == '_') {
            return false;
        } else {    
            for(int i = 0; i < username.Length; i++) {                
                if (!char.IsLetterOrDigit(username[i]) && username[i] != '_') {
                    return false;
                }
            }
        }
        return true;
    }

    public bool Validate2(string username)
    {
        bool isValidUser = false;
        if(
            username.Length > 4 
            && username.Length < 25 
            && username[username.Length -1] != '_' 
            && Regex.IsMatch(username, @"^[a-zA-Z0-9_]+$")
            && Regex.IsMatch(username[0].ToString(), @"^[a-zA-Z]+$")
        ) {
            isValidUser = true;      
        } 
        return isValidUser;
    }

    public void Test(Dictionary<string, bool> items) 
    {
    
        foreach(KeyValuePair<string, bool> item in items)
        {
            bool result = Validate(item.Key);
            if (result == item.Value) {
                Console.WriteLine("Passed!");
            } else {
                Console.WriteLine($"Failed: expected {item.Value}, got {result}");
            }
        } 
    }
}

Dictionary<string, bool> testCases = new Dictionary<string, bool> {
    { "aa_", false },
    { "u__hello_world123", true }
};

UsernameValidation userNameValidator = new UsernameValidation();
userNameValidator.Test(testCases);