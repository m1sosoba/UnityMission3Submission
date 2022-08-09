using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    public GameObject inputFieldSetText;
    public TMP_Text inputField;
    public TMP_Text highscoreText;
    // Start is called before the first frame update
    void Start()
    {
        DataManager.Instance.LoadHighscore();
        inputFieldSetText.GetComponent<TMP_InputField>().text = DataManager.Instance.playerName;
        highscoreText.text = "Best Score: " + DataManager.Instance.playerName + ": " + DataManager.Instance.highscore;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartNew()
    {
        string name = inputField.text;
        DataManager.Instance.currentPlayerName = name;
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
            Application.Quit();
#endif
    }
}
