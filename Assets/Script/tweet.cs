using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tweet : MonoBehaviour {
    string in_txt;
    string tweet_sentence;
	// Use this for initialization
	void Start () {
        in_txt = SaveData.GetString("input");
        Debug.Log(in_txt);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Tweet_Accept()
    {
        tweet_sentence = in_txt + " #tsurhyme_rap";
        Application.OpenURL("http://twitter.com/intent/tweet?text=" + WWW.EscapeURL(tweet_sentence));
    }

    public void Tweet_Fail()
    {
        tweet_sentence = "韻を踏めなかったので一応報告。" + in_txt + " #tsurhyme_rap";
        Application.OpenURL("http://twitter.com/intent/tweet?text=" + WWW.EscapeURL(tweet_sentence));
    }
}
