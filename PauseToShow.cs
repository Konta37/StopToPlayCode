using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseToShow : MonoBehaviour
{
   
    // Start is called before the first frame update
    private void Start() {
        PauseToHideShow();
    }
     void PauseToHideShow()
    {
        GameObject[] objectsToHide = GameObject.FindGameObjectsWithTag("OptionBox");
        foreach (GameObject obj in objectsToHide)
        {
            obj.SetActive(true);
        }
    }
}
