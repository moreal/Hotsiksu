using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {

    public GameObject obj;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

    }

    public void Test(GameObject obj)
    {
        obj.SetActive(!obj.active);
    }
}
