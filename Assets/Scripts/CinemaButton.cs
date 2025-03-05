//#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CinemaButton : MonoBehaviour
{
    [SerializeField] private Button m_Button;
    [SerializeField] private GameObject m_Screen;

    public void ChangeState()
    {
        if(m_Screen.activeSelf)
        {
            m_Screen.SetActive(false);
        }
        else 
        {
            m_Screen.SetActive(true);
        }
    }

    public void StartGame()
    {
        SceneTransitionManager.singleton.GoToSceneAsync(0);
    }

    public void ToCampus()
    {
        SceneTransitionManager.singleton.GoToSceneAsync(4);
    }

    public void ToCinema()
    {
        SceneTransitionManager.singleton.GoToSceneAsync(2);
    }

    public void ToLab()
    {
        SceneTransitionManager.singleton.GoToSceneAsync(3);
    }
}
//#endif