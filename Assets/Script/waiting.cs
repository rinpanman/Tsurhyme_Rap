using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class waiting : MonoBehaviour {

    int i = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        /*if (hogehoge.flag == true)
        {
            SceneTransition.ChangeScene(hogehoge.scenename);
        }*/

        i++;

        if (NewBehaviourScript.get_flag1())
        {
            if (NewBehaviourScript.get_flag2())
            {
                SceneTransition.ChangeScene("seikou");
            }
            else
            {
                Debug.Log("韻踏めなかった");
                SceneTransition.ChangeScene("fly_siberia");
            }
        }

        if (Fade_manager.isfadein)
        {
            SceneTransition.FadeIn();
        }

        if (i >= 300)
        {
            Debug.Log("韻踏めなかった");
            SceneTransition.ChangeScene("fly_siberia");
        }
    }
}
