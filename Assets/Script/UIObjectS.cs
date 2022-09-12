using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIObjectS : MonoBehaviour
{
    public GameObject SeatDownBtn;


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.transform.tag == "Doors")
        {
            SeatDownBtn.SetActive(true);
        }
    }
    public void OnTriggerExit(Collider other)
    {
        SeatDownBtn.SetActive(false);
    }
}
