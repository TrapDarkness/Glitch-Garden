﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    [SerializeField] float autoLoadNextLevelAfter;

    private void Start()
    {

        StartCoroutine(delaySplash());

    }

    IEnumerator delaySplash()
    {

        if (autoLoadNextLevelAfter <=   0f)
        {

            Debug.Log("Level auto load disabled,  a positive number in seconds");

        }
        else
        {
            yield return new WaitForSeconds(autoLoadNextLevelAfter);
            LoadNextScene();
        }

    }

    public void LoadNextScene()
    {

        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);



    }

    public void LoadStringScene( string name)
    {

        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(name);



    }

    public void LoadStartScene()
    {

        SceneManager.LoadScene(0);
        FindObjectOfType<GameSession>().ResetGame();


    }

    public void QuitGame()
    {
        //Testing Version Control
        Application.Quit();

    }

}