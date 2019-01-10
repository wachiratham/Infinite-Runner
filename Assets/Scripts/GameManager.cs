using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;

    public GameObject canvasObject;

    public float delay = 1f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            //Restart game
            Invoke("CallCanvas", delay);
        }

    }

    void CallCanvas()
    {
        canvasObject.SetActive(true);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("Level");
    }
    public void RestartGame()
    {
        SceneManager.LoadScene("Level");
    }

    public void ExitGame()
    {
        Debug.Log("Exit");
        Application.Quit();
    }
}
