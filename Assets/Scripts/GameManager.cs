using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    Quiz2 quiz2;
    EndScreen endscreen;
    void Awake() 
    {
        quiz2 = FindObjectOfType<Quiz2>();
        endscreen = FindObjectOfType<EndScreen>();
    }
    void Start()
    {
        quiz2.gameObject.SetActive(true);
        endscreen.gameObject.SetActive(false);
    }

    void Update()
    {
        if(quiz2.isComplete)
        {
            quiz2.gameObject.SetActive(false);
            endscreen.gameObject.SetActive(true);
            endscreen.ShowFinalScore();
        }
    }

    public void OnReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
