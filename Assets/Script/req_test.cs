using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System.IO;
using System.Runtime.Serialization;

[System.Serializable]
public class Item
{
    public int id;
    public string text;
}

public class req_test : MonoBehaviour {
    public static string return_data;
    public static bool flag1 = false;
    public static bool flag2 = false;

    // Use this for initialization
    void Start () {
		StartCoroutine (GetText ());
	}

	IEnumerator GetText() {
		UnityWebRequest request = UnityWebRequest.Get ("localhost:5000/rhyme/" + SaveData.GetString("input"));

		yield return request.Send ();

		if (request.isError/*isNetworkError*/) {
			Debug.Log (request.error);
		} else {
            Debug.Log("ÉGÉâÅ[ÇÕÇ»Ç©Ç¡ÇΩÇÊÇ§Çæ...");
            Debug.Log(request.responseCode);
			if (request.responseCode == 200) {
				string text = request.downloadHandler.text;

				Debug.Log (text);
                Item item = JsonUtility.FromJson<Item>(text);

                return_data = item.text;



                flag1 = true;
                if (item.text != "" || item.text != null || item.text.Length == 0)
                {
                    Debug.Log("aaaaa");
                    Debug.Log("*******************sdie****************");
                    //flag2 = false;
                    flag2 = true;
                }
                Debug.Log("*****************************");
                Debug.Log(item.id);
                Debug.Log(item.text);
                Debug.Log(item.text.Length);
                Debug.Log("*******************************");
            }
		}
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