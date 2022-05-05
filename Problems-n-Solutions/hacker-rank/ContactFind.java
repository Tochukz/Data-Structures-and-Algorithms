/**
Problem:  The class must perform two types of operations:

1. add name, where name  is a string denoting a contact name. This must store  name as a new contact in the application.
2 find partial, where partial is a string denoting a partial name to search the application for. 
It must count the number of contacts starting with partial and print the count on a new line.

Given n sequential add and find operations, perform each operation in orde

Example
Operations are requested as follows:

add ed
add eddie
add edward
find ed
add edwina
find edw
find a

Three add operations include the names 'ed', 'eddie', and 'edward'. 
Next, find ed matches all 3 names. 
Note that it matches and counts the entire name 'ed'. 
Next, add 'edwina' and then find 'edw'. 2 names match: 'edward' and 'edwina'. 
In the final operation, there are 0 names that start with 'a'. 
Return the array [3, 2, 0].

Function Description

Complete the contacts function below.

contacts has the following parameters:

* string queries[n]: the operations to perform
Returns

* int[]: the results of each find operation

*/

public class ContactFind {
    public static List<Integer> contacts(List<List<String>> queries) {
        // Write your code here
        
        List<String> names = new ArrayList<String>();
        List<Integer> foundCounts = new ArrayList<Integer>();
        int foundCount = 0;
        for(List<String> query : queries) {
            String operation = query.get(0);
            String param = query.get(1);
            if (operation.equalsIgnoreCase("add")) {
                names.add(param);
            } else if (operation.equalsIgnoreCase("find")) {        
                foundCount = 0;
                for(String name : names) {
                    if(name.indexOf(param) == 0) {
                        foundCount++;
                    }
                }               
                foundCounts.add(foundCount); 
            }
        }
        return foundCounts;
    }
    
}

/**
Note: This solution timeout in the online run. 
      This means that is has to be optimizzed. 

Online Resource:  
 https://www.hackerrank.com/challenges/contacts/problem
*/