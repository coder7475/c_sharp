using System;

// OOP 
// Student Management System
class Auth {
  public bool IsAuthenticated() {
    return false;
  }
}

class Student {
  private string name;
  private int age;
  Auth auth = new Auth();
  
  public Student(string name, int age) {
    this.name = name;
    this.age = age;
  }
  public void SetName(string name) {
    if (auth.IsAuthenticated()){   
      this.name = name;
    }
    else
    {
        Console.WriteLine("You are not Authenticated");
    }
  }

  public string GetName() {
    return this.name;
  }

  public void ShowInfo() {
    Console.WriteLine("Name: {0} Age: {1}", name, age);
  }
}

// Inheritence
class JIPCStudent : Student {
  public JIPCStudent(string name, int age): base(name, age) {

  }
  public void GiveQuiz() {
    Console.WriteLine("Give Quiz");
  }
}

class Program {
  public static void Main() {   
    Student student = new Student("Saif", 27);



    student.SetName("Shahriar");
    student.ShowInfo();
    Console.WriteLine(student.GetName());


    JIPCStudent jipcStudent = new JIPCStudent("John", 20);
    jipcStudent.ShowInfo();
    jipcStudent.GiveQuiz();
  }
}
