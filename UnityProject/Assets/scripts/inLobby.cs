using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class inLobby : MonoBehaviour {

    private void Awake()
    {

    }

    public void InBotton()
    {
        Invoke("Doin", 0.5f);
    }

    public void Doin()
    {
        Application.LoadLevel("Lobby");
    }
}
