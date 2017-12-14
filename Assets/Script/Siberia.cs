using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Siberia : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Fade_manager.fade_init();
    }
	
	// Update is called once per frame
	void Update () {
        if (Fade_manager.isfadein)
        {
            SceneTransition.FadeIn();
        }
    }
}
