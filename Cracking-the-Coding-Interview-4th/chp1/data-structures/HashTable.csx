using System.Collections.Generic;

public class Student 
{
    public int Id; 

    public string Name;

}

public class PhysicsClass 
{
    public Dictionary<int, Student> BuildStudents(Student[] students) 
    {
        Dictionary<int, Student> Students = new Dictionary<int, Student>();
        foreach(Student student in students) 
        {
            Students.Add(student.Id, student);
        }
        return Students;
    }
}

PhysicsClass physicsClass  = new PhysicsClass();
Student[] students = new Student [] {
    new Student { Id = 1, Name = "James Bond"},
    new Student { Id = 2, Name = "Kalvin Klean"}
};

Dictionary<int, Student> studentMap = physicsClass.BuildStudents(students);
foreach(KeyValuePair<int, Student> keyVal in studentMap)
{
    Console.WriteLine($"{keyVal.Key} => {keyVal.Value.Name}");
}




