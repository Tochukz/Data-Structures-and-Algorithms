class exercise8{
    static void reverseChars(char[] letters, int start, int end) {
        while (start < end)
        {
            char temp = letters[start];
            letters[start] = letters[end];
            letters[end] = temp;
            start++;
            end--;
        }
    }
  
    public static void reverseWords (char[] sentence) {
        int len = sentence.length;
        for(char x : sentence)
        {
          System.out.print(x);
        }
        System.out.println("");
        reverseChars(sentence, 0, len - 2); // Note1
        for(char x : sentence)
        {
          System.out.print(x);
        }
        System.out.println("");
  
        int start = 0;
        for (int i = 0; i < len; i++)
        {
            if (sentence[i] == ' ')
            { 
               reverseChars(sentence, start,  i - 1);
               start = i + 1;
            }
            if(i == len - 1)
            {
               reverseChars(sentence, start, len - 2); // Note1
            }
        }
    }   
  }  

  /* 
    Note1:
    NB: 2 isused here instead of 1 because of the charater array is terminated by a space in the online exercise
  */