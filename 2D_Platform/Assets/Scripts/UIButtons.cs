using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButtons : MonoBehaviour
{
    [SerializeField] private GameObject SettingPanel;
    [SerializeField] private GameObject StartPanel;
    [SerializeField] private GameObject MainScene;


    private void Awake()
    {
        Time.timeScale = 0f;
    }

    public void PlayBTN()
    {
        StartPanel.SetActive(false);
        Time.timeScale = 1f;
    }
    public void ResumeBTN()
    {
        SettingPanel.SetActive(false);
        Time.timeScale = 1f;
    }
    public void PauseBTN()
    {
        SettingPanel.SetActive(true);
        Time.timeScale = 0f;
    }
    
}
