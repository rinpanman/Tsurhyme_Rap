using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Net;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;


public class TrustAllCertificatePolicy : System.Net.ICertificatePolicy
{

    public TrustAllCertificatePolicy() { }
    public bool CheckValidationResult(System.Net.ServicePoint sp,
        System.Security.Cryptography.X509Certificates.X509Certificate cert,
        System.Net.WebRequest req,
        int problem)
    {
        return true;
    }
}

[System.Serializable]
public class Item
{
    public int id;
    public string text;
}

public class NewBehaviourScript : MonoBehaviour {
    static MonoBehaviour monoBehaviour = new MonoBehaviour();
    public static string URL = "https://tsurhyme0rap.herokuapp.com/rhyme/";
    public WebRequest req_get;
    public static bool flag1, flag2;
    public static string return_data;
    public string text;

    public IEnumerator Get(string url)
    {
        var request = new UnityWebRequest();
        request.downloadHandler = new DownloadHandlerBuffer();
        request.url = url;
        request.SetRequestHeader("Content-Type", "application/json; charset=UTF-8");
        request.method = UnityWebRequest.kHttpVerbGET;
        yield return request.Send();

        if (request.isError)
        {
            Debug.Log(request.error);
        }
        else
        {
            if (request.responseCode == 200)
            {
                Debug.Log("success");
                Debug.Log(request.downloadHandler.text);
            }
            else
            {
                Debug.Log("failed");
            }
        }
    }

    private void Start()
    {
        
    }

    private void Awake()
    {
        URL = "https://tsurhyme0rap.herokuapp.com/rhyme/";
        URL += SaveData.GetString("input");
        //Debug.Log(SaveData.GetString("input"));
        Debug.Log(URL);
    }
    /*
    public NewBehaviourScript()
    {
        // コンストラクタ
        System.Net.ServicePointManager.CertificatePolicy = new TrustAllCertificatePolicy();
        Debug.Log(URL);
        req_get = (HttpWebRequest)WebRequest.Create(URL);
    }*/

    private void Main()
    {
        URL = "https://tsurhyme0rap.herokuapp.com/rhyme/";
        URL += SaveData.GetString("input");
        Debug.Log(URL);

        
        System.Net.ServicePointManager.CertificatePolicy = new TrustAllCertificatePolicy();
        Debug.Log(URL);
        req_get = (HttpWebRequest)WebRequest.Create(URL);
        

        flag1 = false; // 帰ってきたか
        flag2 = false;  // シベリアか成功か

        
        WebResponse res = req_get.GetResponse();
        Stream res_2 = res.GetResponseStream();
        var st = new StreamReader(res_2);
        var response = st.ReadToEnd();
        

        URL = "https://tsurhyme0rap.herokuapp.com/rhyme/";
        URL += SaveData.GetString("input");
        Debug.Log(URL);

        //WWW request = new WWW(URL);
        // yield return request;
        /*UnityWebRequest request = UnityWebRequest.Get(URL);
        request.Send();
        
        if (request.isError)
        {
            Debug.Log(request.error);
        }
        else
        {
            if (request.responseCode == 200)
            {
                text = request.downloadHandler.text;
                Debug.Log(text);
            }
        }*/
        
        Item item = JsonUtility.FromJson<Item>(text);
        //return_data = item.text;

        flag1 = true;
        if (item.text != "" ||item.text !=  null || item.text.Length == 0)
        {
            Debug.Log("aaaaa");
            flag2 = false;
        }
        Debug.Log(item.id);
        Debug.Log(item.text);
        Debug.Log(item.text.Length);
    }

    public static bool get_flag1()
    {
        return flag1;
    }

    public static bool get_flag2()
    {
        return flag2;
    }
}
