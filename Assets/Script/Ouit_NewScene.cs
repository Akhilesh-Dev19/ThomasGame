using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ouit_NewScene : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
    }
    public void OpenNewScene(int Id)
    {
        SceneManager.LoadSceneAsync(Id);
    }
}
