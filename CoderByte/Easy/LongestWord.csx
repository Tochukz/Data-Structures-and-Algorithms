/* Longest Word
 Have the function LongestWord(sen) take the sen parameter being passed and return the longest word in the string.
 If there are two or more words that are the same length, return the first word from the string with that length. 
 Ignore punctuation and assume sen will not be empty. 
 Words may also contain numbers, for example "Hello world123 567"

Examples
Input: "fun&!! time"
Output: time
Input: "I love dogs"
Output: love

 */

class LongestWord {
    public string LongestWord(string sen) {
        string[] words = sen.Split(" ");
        int maxLen = 0;
        string maxWord = "";
        foreach (string word in words) {
        int wordLen = 0;
        for(int i = 0; i < word.Length; i++) {
            if (!char.IsLetterOrDigit(word[i])) {
                break;
            } 
            wordLen++;
        }
        if (wordLen > maxLen) {
            maxLen = wordLen;
            maxWord = word;
        }
        }
        return maxWord;
    }

    public string LongestWord2(string sen) 
    {
        Regex rgx = new Regex(@"[^\w\s]");
        sen = rgx.Replace(sen,"");
        string[] words = sen.Split(' ');

        return words.OrderByDescending(x => x.Length).First();
}
}


 