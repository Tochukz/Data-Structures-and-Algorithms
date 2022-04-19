/**
Problems: Balanced Brackets
  A bracket is considered to be any one of the following characters: (, ), {, }, [, or ].
  Given n strings of brackets, determine whether each sequence of brackets is balanced. 
  If a string is balanced, return YES. Otherwise, return NO.
*/

import java.util.*;

public class BalancedBracket 
{
    public static String isBalanced(String str) {
            HashMap<Character, Character> map = new HashMap<Character, Character>();
            map.put('{', '}');
            map.put('[', ']');
            map.put('(', ')');
            Stack<Character> stack = new Stack<Character>();
            for(int i = 0; i < str.length(); i++)
            {
                char c = str.charAt(i);
                if (map.containsKey(c))
                {
                    stack.push(c);
                }
                else if(!stack.isEmpty())
                {
                    char k = stack.pop();
                    if (map.containsKey(k) && map.get(k) == c)
                    {
                        continue;
                    }
                    return "NO";
                }
                else
                {
                    return "NO";
                }
            } 
            
            if (stack.isEmpty())
            {
                return "YES";
            }
            return "NO";
        }    
}

/**

Online Resource:  
  https://www.hackerrank.com/challenges/balanced-brackets/problem 
*/