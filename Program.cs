using System;

// OOP 
// Student Management System
class Student {
  private string name;
  private int age;
  
  public Student(string name, int age) {
    this.name = name;
    this.age = age;
  }

  public void ShowInfo() {
    Console.WriteLine("Name: {0} Age: {1}", name, age);
  }
}

class Program {
  public static void Main() {   
    Student student = new Student("Saif", 27);


    student.ShowInfo();
  }
}
