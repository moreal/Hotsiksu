using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System.Web;
using System;
using System.IO;

public class HttpMethods : MonoBehaviour {

    public static string url = "http://hotsex.run.goorm.io";

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public class Response
    {
        public int status_code;
        public string content;

        public Response(int i, string s)
        {
            status_code = i;
            content = s;
        }
    }

    public static Response GetGET(string path)
    {
        HttpWebRequest req = (HttpWebRequest) WebRequest.Create(new Uri(url+path));
        req.Credentials = CredentialCache.DefaultCredentials;
        //req.Headers.Add("Host","hotsex.run.groom.io");
        req.Method = "GET";
        HttpWebResponse rep = (HttpWebResponse)req.GetResponse();
        Stream stream = rep.GetResponseStream();
        StreamReader reader = new StreamReader(stream);
        return new Response((int)rep.StatusCode, reader.ReadToEnd());
    }

    public static Response GetPOST(string path)
    {
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(new Uri(url + path));
        req.Credentials = CredentialCache.DefaultCredentials;
        req.Method = "POST";
        //req.Headers.Add("Host: hotsex.run.groom.io");
        HttpWebResponse rep = (HttpWebResponse) req.GetResponse();
        Stream stream = rep.GetResponseStream();
        StreamReader reader = new StreamReader(stream);
        return new Response((int)rep.StatusCode, reader.ReadToEnd());
    }
}
