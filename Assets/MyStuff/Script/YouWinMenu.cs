using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class YouWinMenu : MonoBehaviour
{
    public static YouWinMenu Instance;
    public GameObject container;
    public Button nextlevelbutton;
    public Button hidebutton;

    private void OnEnable()
    {
       nextlevelbutton.onClick.AddListener(HandleNextLevelPressed);
       hidebutton.onClick.AddListener(HandleClosePressed);
    }

    private void OnDisable()
    {
        nextlevelbutton.onClick.RemoveListener(HandleNextLevelPressed);
        nextlevelbutton.onClick.RemoveListener(HandleClosePressed);
    }
    private void HandleNextLevelPressed()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextSceneIndex);
    }
    private void Awake()
    {
        Instance = this;
    }

    public void Show()
    {
        container.SetActive(true);
    }

    private void HandleClosePressed()
    {
        container.SetActive(false);
    }
}
