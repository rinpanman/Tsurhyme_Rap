using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class nextwaiting : MonoBehaviour {

    public static string inn = "";

    void Start()
    {
        Fade_manager.fade_init();
    }

    // Update is called once per frame
    void Update()
    {
        if (Fade_manager.isfadeout)
        {
            SceneTransition.ChangeScene("waiting");
        }

        if (Fade_manager.isfadein)
        {
            SceneTransition.FadeIn();
        }
    }

    public void nextw()
    {
        //mojisyutoku
        //SceneManager.LoadScene("waiting");

        Fade_manager.isfadeout = true;

    }
}
