using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    public int levelSeconds;

    private Scrollbar slider;

    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Scrollbar>();
        print(slider);
    }

    // Update is called once per frame
    void Update()
    {
        slider.size =Time.timeSinceLevelLoad / levelSeconds;
        if (slider.size==1 )
        {
            Application.LoadLevel(Application.loadedLevel + 1);
        }
    }
}
