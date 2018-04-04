using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class Off : MonoBehaviour {

    public void DoOff()
    {
        Application.Quit();
    }

    private void Start()
    {
        HttpMethods.Response resp = HttpMethods.GetPOST("/get/rooms");
    }
}
