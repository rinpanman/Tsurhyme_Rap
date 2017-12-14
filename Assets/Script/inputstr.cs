using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inputstr : MonoBehaviour {
    InputField input_text;
    private InputField inputField;
    private Text text1;

    public static string inputValue = "";

    /// <summary>
    /// Startメソッド
    /// InputFieldコンポーネントの取得および初期化メソッドの実行
    /// </summary>
    void Start()
    {
        input_text = GameObject.Find("InputField").GetComponent<InputField>();
        Debug.Log(input_text);
        inputField = GetComponent<InputField>();
        DontDestroyOnLoad(this);
        InitInputField();
}

    public void InputLogger()
    {

        inputValue = input_text.text;
        SaveData.SetString("input", input_text.text);
        SaveData.Save();
        Debug.Log(input_text.text);
        Debug.Log(SaveData.GetString("input"));
        DontDestroyOnLoad(this);
        // InitInputField();
    }


    /// <summary>
    /// InputFieldの初期化用メソッド
    /// 入力値をリセットして、フィールドにフォーカスする
    /// </summary>


    void InitInputField()
    {

        // 値をリセット
        inputField.text = "";

        // フォーカス
        inputField.ActivateInputField();
    }
}
