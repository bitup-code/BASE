using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    public float autoLoadNextLevelAfter;
    void Start()
    {
        if (autoLoadNextLevelAfter == 0)
        {
            Debug.Log("Level auto load disabled");
        }
        else
        {
            Invoke("LoadNextLevel", autoLoadNextLevelAfter);
        }
        
    }
    public void LoadLevel(string name)
    {
        Debug.Log("New Level load: " + name);
        Application.LoadLevel(name);
    }
    public void QuitRequest()
    {
        Debug.Log("Quit request");
        Application.Quit();
    }
    public void LoadNextLevel()
    {
        Application.LoadLevel(Application.loadedLevel + 1);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
