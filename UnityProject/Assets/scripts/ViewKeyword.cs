using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewKeyword : MonoBehaviour {
    
    string[] keywords = { "키워드임","델너무조아","시공조아","페그오오" };

    // Use this for initialization
    void Start() {
        view();
    }

    // Update is called once per frame
    void Update() {

    }

    public void view() {
        GetComponent<Text>().text = keywords[Random.Range(0, keywords.Length)];
    }
}
