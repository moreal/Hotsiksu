using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour {

    public GameObject textField = null;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void login()
    {
        string id = textField.GetComponent<Text>().text;
        HttpMethods.Response resp = HttpMethods.GetGET("/login/" + id);

        if (resp.status_code == 403)
            Debug.Log("Error");
        else if (resp.status_code == 200)
        {
            SharedData.id = id;
            Application.LoadLevel("Main");
        }

    }
    
}
