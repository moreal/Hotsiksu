using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class Back : MonoBehaviour {

    private void Awake()
    {
        
    }

    public void BackBotton()
    {
        Invoke("DoBack", 0.5f);
    }

    public void DoBack()
    {
        Application.LoadLevel("Lobby");
    }
}
