using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using Unity.VisualScripting;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using JetBrains.Annotations;

public class ChangeScence : MonoBehaviour
{
   
    public void PlayGame(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        Debug.Log("Cham");
    }
    
}
