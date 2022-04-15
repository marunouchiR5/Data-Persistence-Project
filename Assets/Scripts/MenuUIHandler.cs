using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    public GameObject NameInputField;
    public TMP_Text BestScoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        // Modify the upper text with best score and its owner's name
        GameManager.Instance.LoadBestScore();
        BestScoreText.text = "Best Score : " + GameManager.Instance.Name + " : " + GameManager.Instance.Score;
    }

    public void StartNew()
    {
        // Save current player's name
        GameManager.Instance.PlayerName = NameInputField.GetComponent<TMP_InputField>().text;
        
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if  UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // Original code to quit Unity player
#endif
    }
}
