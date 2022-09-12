using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMangement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SwitchScene());
    }

    IEnumerator SwitchScene()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(1);
        Debug.Log("Wait is over, Welcome Cheif!  " +
            "StartYou Game");
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}
