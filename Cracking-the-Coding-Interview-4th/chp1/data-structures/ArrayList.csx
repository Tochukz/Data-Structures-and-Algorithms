using System.Collections.Generic;

public class RoleCall
{
    public List<string> SetNames(string[] names, string[] moreNames)
    {
        List<string> allNames = new List<string>();

        foreach(string name in names) 
        {
            allNames.Add(name);
        }
        foreach(string name in moreNames)
        {
            allNames.Add(name);
        }
        return allNames;
    }
}

RoleCall classRoll = new RoleCall();
string[] names1 = new string[] {"Jame Brown", "Steve Colins", "Kelvin Smith"};
string[] names2 = new string[] {"Peter Tosh", "Omoladi McClean"};
List<string> studentNames = classRoll.SetNames(names1, names2);
foreach(string name in studentNames)
{
    Console.WriteLine(name);
}