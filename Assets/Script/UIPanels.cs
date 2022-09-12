using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPanels : MonoBehaviour
{
    public GameObject UIObject;
    public void OnActive()
    {
        UIObject.SetActive(true);
    }
    public void OnDeActive()
    {
        UIObject.SetActive(false);
    }
}
