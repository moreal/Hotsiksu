using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System.Net;
using System.Web;
using System;
using System.IO;

public class HttpMethods {

    public static string url = "http://hotsex.run.goorm.io";

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
        req.Method = "GET";
        HttpWebResponse rep = (HttpWebResponse)req.GetResponse();
        Stream stream = rep.GetResponseStream();
        StreamReader reader = new StreamReader(stream);
        return new Response((int)rep.StatusCode, reader.ReadToEnd());
    }

    public static Response GetPOST(string path, byte[] data = null)
    {
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(new Uri(url + path));
        req.Credentials = CredentialCache.DefaultCredentials;
        req.Method = "POST";

        if (data != null)
        {
            req.GetRequestStream().Write(data, 0, data.Length);
            req.ContentLength = data.Length;
            req.ContentType = "application/octet-stream";
        }

        HttpWebResponse rep = (HttpWebResponse) req.GetResponse();
        Stream stream = rep.GetResponseStream();
        StreamReader reader = new StreamReader(stream);
        return new Response((int)rep.StatusCode, reader.ReadToEnd());
    }

    
}
