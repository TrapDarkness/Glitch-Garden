using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{

    [SerializeField] Slider volumeSlider;
    [SerializeField] Slider difficultySlider;
    [SerializeField] SceneLoader levelManager;

    MusicManager musicManager;


    // Use this for initialization
    void Start()
    {

        musicManager = FindObjectOfType<MusicManager>();
        volumeSlider.value = PlayerPrefsManager.GetMasterVolume();
        difficultySlider.value = PlayerPrefsManager.GetDifficulty();

        Debug.Log(musicManager);

    }

    // Update is called once per frame
    void Update()
    {

        musicManager.SetVolume(volumeSlider.value);

    }

    public void SaveAndExit()
    {

        PlayerPrefsManager.SetMasterVolume(volumeSlider.value);
        PlayerPrefsManager.SetDifficulty(difficultySlider.value);
        levelManager.LoadStringScene("01A Start");

    }

    public void SetDefaults()
    {

        volumeSlider.value = 0.8f;
        difficultySlider.value = 2f;

    }

}

