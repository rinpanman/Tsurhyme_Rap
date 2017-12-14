using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fly_siberia : MonoBehaviour {

    GameObject icon;

	// Use this for initialization
	void Start () {
        Fade_manager.fade_init();
        icon = GameObject.Find("icon");
	}
	
	// Update is called once per frame
	void Update () {
		if (icon.transform.localScale.x == 0.05f)
        {
            SceneTransition.ChangeScene("Siberia");
        }

        if (Fade_manager.isfadein)
        {
            SceneTransition.FadeIn();
        }
    }
}
