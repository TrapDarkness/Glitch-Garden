using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GameSession : MonoBehaviour
{

    //config params
    [SerializeField] float gameSpeedMin = 0.1f;
    [SerializeField] float gameSpeedMax = 10f;
    [Range(0f, 100f)]  [SerializeField] float gameSpeed = 1f;
    [SerializeField] int pointsPerBlockDestroyed = 83;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] bool isAutoPlayEnabled;

    //state variables
    [SerializeField] int currentScore = 0;


    private void Awake()
    {

        int gameSessionCount = FindObjectsOfType<GameSession>().Length;
        if (gameSessionCount > 1) 
        {

            Destroy(gameObject);

        }

        else 
        {

            DontDestroyOnLoad(gameObject);

        }
    }

    private void Start()
    {

        scoreText.text = currentScore.ToString();

    }


    // Update is called once per frame
    void Update () 
    {

        Time.timeScale = gameSpeed;

	}


    public void AddToScore() 
    {

        currentScore += pointsPerBlockDestroyed;
        scoreText.text = currentScore.ToString(); 

    }

    public void ResetGame()
    {

        Destroy(gameObject);

    }

    public bool IsAutoPlayEnabled()
    {

        return isAutoPlayEnabled;

    }

}
