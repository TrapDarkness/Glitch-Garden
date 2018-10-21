﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour {

    public AudioClip[] levelMusicChangeArray;

    private AudioSource audioSource;

    private void Awake()
    {

        DontDestroyOnLoad(gameObject);
        Debug.Log("Don't destroy on load: " + name);

    }

    // Use this for initialization
    void Start () {

        audioSource = GetComponent<AudioSource>();

	}
	
	// Update is called once per frame
	void OnLevelWasLoaded (int level) 
    {

        AudioClip thisLevelMusic = levelMusicChangeArray[level];
            Debug.Log("Playing clip: " + thisLevelMusic);
        if (thisLevelMusic) // If there's some music attached
        {

            audioSource.clip = thisLevelMusic;
            audioSource.loop = true;
            audioSource.Play();

        }

	}

    public void SetVolume(float volume)
    {

        audioSource.volume = volume;

    }

}
