using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
    public Slider volumeSlider,diffSlider;
    public LevelManager levelManager;

    private MusicManager musicManager;
    void Start()
    {
        musicManager = GameObject.FindObjectOfType<MusicManager>();
        volumeSlider.value = PlayerPrefsManager.GetMasterVolume();
        diffSlider.value = PlayerPrefsManager.GetDifficulty();
    }

    // Update is called once per frame
    private void Update()
    {
        //MusicManager.ChangeVolume(volumeSlider.value);
    }

    public void SaveAndExit()
    {
        PlayerPrefsManager.SetMasterVolume(volumeSlider.value);
        PlayerPrefsManager.SetDifficulty(diffSlider.value);
        levelManager.LoadLevel("01a Start 1"); 
    }

    public void SetDefaults()
    {
        volumeSlider.value = 0.8f;
        diffSlider.value = 2f;
    }
}
