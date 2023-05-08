using DynamicData;
using System;

internal class Facade
{
    public IObservableList<ClassRoom> ClassRooms => _classRooms;
    public IObservableList<Teacher> Teachers => _teachers;
    public IObservableList<Student> Students => _students;

    private SourceList<ClassRoom> _classRooms = new SourceList<ClassRoom>();
    private SourceList<Teacher> _teachers = new SourceList<Teacher>();
    private SourceList<Student> _students = new SourceList<Student>();
    public Facade()
    {
    }

    internal void AddClassRoom()
    {
        _classRooms.Add(new ClassRoom());
    }

    internal void AddTeacher()
    {
        _teachers.Add(new Teacher());
    }

    internal void AddStudent()
    {
        _students.Add(new Student());
    }
}