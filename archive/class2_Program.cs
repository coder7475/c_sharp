using System;

// OOP 
// Student Management System
class Authenticator {
  public bool IsUserAuthenticated() {
    return false;
  }
}

class Student {
  private string _name;
  private int _age;
  private Authenticator _authenticator = new Authenticator();
  
  public Student(string name, int age) {
    _name = name;
    _age = age;
  }
  public void SetName(string name) {
    if (_authenticator.IsUserAuthenticated()){   
      _name = name;
    }
    else
    {
        Console.WriteLine("You are not authenticated");
    }
  }

  public string GetName() {
    return _name;
  }

  public void DisplayInfo() {
    Console.WriteLine("Name: {0} Age: {1}", _name, _age);
  }
}

// Inheritance
class JipcStudent : Student {
  public JipcStudent(string name, int age): base(name, age) {

  }
  public void TakeQuiz() {
    Console.WriteLine("Take Quiz");
  }
}

class StudentManagementProgram {
  public static void Student() {   
    Student student = new Student("Saif", 27);

    student.SetName("Shahriar");
    student.DisplayInfo();
    Console.WriteLine(student.GetName());

    JipcStudent jipcStudent = new JipcStudent("John", 20);
    jipcStudent.DisplayInfo();
    jipcStudent.TakeQuiz();
  }
}
