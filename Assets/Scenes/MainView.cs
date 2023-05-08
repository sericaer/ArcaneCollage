using System;
using System.Collections;
using System.Collections.Generic;
using System.Reactive.Disposables;
using UnityEngine;
using UnityEngine.UI;

public class MainView : MonoBehaviour
{
    public Text classRoomNum;
    public Text teacherNum;
    public Text studentNum;

    private Facade facade;

    private CompositeDisposable disposables = new CompositeDisposable();

    void Awake()
    {
        facade = new Facade();

        Subscribe(facade.ClassRooms.CountChanged, num=> classRoomNum.text = num.ToString());
        Subscribe(facade.Students.CountChanged, num => teacherNum.text = num.ToString());
        Subscribe(facade.Teachers.CountChanged, num => studentNum.text = num.ToString());
    }

    void OnDestroy()
    {
        disposables.Dispose();
    }

    private void Subscribe(IObservable<int> countChanged, Action<int> action)
    {
        disposables.Add(countChanged.Subscribe(action));
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowTeacherResumeDialog()
    {

    }

    public void AddBuilding()
    {
        facade.AddClassRoom();
    }

    public void AddTeacher()
    {
        facade.AddTeacher();
    }

    public void AddStudent()
    {
        facade.AddStudent();
    }
}
