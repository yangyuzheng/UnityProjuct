using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PureMVC.Patterns;

public class MyDataProxy : Proxy {

    public new const string NAME = "MyDataProxy";

    private MyData _MyData;
 

    public MyDataProxy() : base(NAME)
    {
        _MyData = new MyData();
    }

    public void AddNumber()
    {
        ++_MyData.Number;
        SendNotification("Msg_ReceiveNumberFromModel",_MyData);
    }
}
