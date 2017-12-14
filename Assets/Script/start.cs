using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Fade_manager.fade_init();
	}
	
	// Update is called once per frame
	void Update () {
        //Fade_manager.fading(name);
        if (Fade_manager.isfadeout)
        {
            SceneTransition.ChangeScene("stringin");
        }
        if (Fade_manager.isfadein)
        {
            SceneTransition.FadeIn();
        }
	}
}
