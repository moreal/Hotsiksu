using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class up1_1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void Awake()
    {
        
    }

    public void HomeBotton()
    {
        Invoke("GoHome", .5f);
    }

    public void GoHome ()
    {
        Application.LoadLevel("Main");
    }

}
