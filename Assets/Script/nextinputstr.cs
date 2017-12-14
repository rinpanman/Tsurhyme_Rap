using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextinputstr : MonoBehaviour {
    
    public void nextstringscene()
    {
        //SceneManager.LoadScene("stringin");
        Debug.Log("おした");
        Fade_manager.isfadeout = true;
    }
    private void Start()
    {
        SaveData.Clear();
        Fade_manager.fade_init();
    }

    private void Update()
    {
        //Fade_manager.fading("stringin");

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
