using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class ItemsCollectionSQ : MonoBehaviour
{
    private int cherries = 0;
    public string sceneName;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ItemsCollection"))
        {
            Destroy(collision.gameObject);
            cherries++;
        }
        if (collision.gameObject.CompareTag("CheckPoint"))
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
