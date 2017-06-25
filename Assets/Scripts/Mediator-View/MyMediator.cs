using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PureMVC.Patterns;
using UnityEngine.UI;
using PureMVC.Interfaces;

public class MyMediator : Mediator {

    public new const string NAME = "MyMediator";

    private Text txtShowNumber;
    private Button btnSubmit;

    public MyMediator(GameObject goUiroot):base(NAME)
    {
        txtShowNumber = goUiroot.transform.Find("TextNumber").GetComponent<Text>();
        btnSubmit = goUiroot.transform.Find("Clickme").GetComponent<Button>();

        btnSubmit.onClick.AddListener(HandleButtonClick);
    }

    private void HandleButtonClick()
    {
        SendNotification("Com_SendNumber");
    }

    public override void HandleNotification(INotification notification)
    {
        switch(notification.Name)
        {
            case "Msg_ReceiveNumberFromModel":
                MyData _mydata = notification.Body as MyData;
                ShowNumber(_mydata);
                break;
            default:
                break;
        }
    }

    public override IList<string> ListNotificationInterests()
    {
        IList<string> list = new List<string>();
        list.Add("Msg_ReceiveNumberFromModel");
        return list;
    }

    private void ShowNumber(MyData myData)
    {
        if(myData!=null)
        {
            txtShowNumber.text = myData.Number.ToString();
        }
    }
}
