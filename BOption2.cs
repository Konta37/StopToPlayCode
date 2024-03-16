using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOption2 : MonoBehaviour
{
    public GameObject objectToToggle;
    public GameObject OptionCall;

    private void OnMouseDown()
    {
        ToggleObject();
        pauseGameSpace();
    }

    private void ToggleObject()
    {
        // Toggle the active state of the object
        if (objectToToggle != null)
        {
            objectToToggle.SetActive(!objectToToggle.activeSelf);
            OptionCall.SetActive(!OptionCall.activeSelf);
        }
    }
    void pauseGameSpace()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            OptionCall.SetActive(!OptionCall.activeSelf);
        }
    }
}
