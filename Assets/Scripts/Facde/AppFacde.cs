using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PureMVC.Patterns;

public class AppFacde : Facade {

	// Use this for initialization
	public AppFacde(GameObject goUiroot) {


        RegisterCommand("Com_SendNumber",typeof(MyCommand));
        RegisterMediator(new MyMediator(goUiroot));
        RegisterProxy(new MyDataProxy());
	}
	

}
