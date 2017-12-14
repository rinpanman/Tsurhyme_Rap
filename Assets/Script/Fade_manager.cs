using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade_manager : MonoBehaviour {

    public static bool isfadein = false;
    public static bool isfadeout = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public static void fade_init()
    {
        if (isfadeout)
        {
            isfadeout = false;
        }
        if (!isfadein)
        {
            isfadein = true;
        }
    }

    public static void fading(string name)
    {
        if (isfadein)
        {
            SceneTransition.FadeIn();
        }
        else if (isfadeout)
        {
            Debug.Log("フェードアウト");
            SceneTransition.ChangeScene(name);
        }
    }
}
