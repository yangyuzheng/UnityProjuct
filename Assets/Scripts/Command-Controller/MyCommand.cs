using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PureMVC.Patterns;
using PureMVC.Interfaces;

public class MyCommand : SimpleCommand {

    public override void Execute(INotification notification)
    {
        //方法调用模型层
       MyDataProxy proxy= Facade.RetrieveProxy(MyDataProxy.NAME)as MyDataProxy;
        proxy.AddNumber();
    }
}
