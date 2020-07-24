using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneMenu : MonoBehaviour
{
   public void EnterARMode()
    {
        SceneManager.LoadScene("ARFunBook");
    }

    public void HowToUse()
    {
        SceneManager.LoadScene("Guide");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void Back()
    {
        SceneManager.LoadScene("UI");
    }

    public void Pdf()
    {
        Application.OpenURL("https://raw.githubusercontent.com/shikherpant/AR-FunBook/master/ImageTargets.pdf");
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Exit Button Pressed");
    }
}
