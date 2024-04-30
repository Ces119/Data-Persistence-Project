using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor;
public class MenuSceneManager : MonoBehaviour
{
    [SerializeField] private TMP_InputField InputField;
    public string player_name;
    public Text highScore;

    void Start()
    {
        WinnerList.Instance.LoadWinnerData();
        highScore.text = "Best score: " + WinnerList.Instance.bestPlayer + ": " + WinnerList.Instance.bestScore;
    }
    public void SaveName()
    {
        player_name = InputField.text;
        WinnerList.Instance.playerName = player_name;
    }
    public void StartMain()
    {
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
