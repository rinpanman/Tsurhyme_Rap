using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textinit : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        //str = inputstr.inputvalue;
        Text txt = GameObject.Find("Text").GetComponent<Text>();
        Text txt1 = GameObject.Find("Text (1)").GetComponent<Text>();
        string str = SaveData.GetString("input");
        string str1 = NewBehaviourScript.return_data;
        Debug.Log(str);
        txt.text = str;
        txt1.text = str1;
        SaveData.Remove("input");
    }
	
	// Update is called once per frame
	void Update () {
        if (Fade_manager.isfadein)
        {
            SceneTransition.FadeIn();
        }
    }
}
