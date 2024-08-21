using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject canvPause;
    public GameObject canvInGame;
    public GameObject canvEndGame;
    private float realTime = 0;
    private float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        canvPause.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        realTime += Time.deltaTime;
        if (realTime > 20)
        {
            Time.timeScale += .2f;
            speed = Time.timeScale;
            realTime = 0;
            Debug.Log("SpeedUP");
        }
    }

    public void PauseGame()
    {
        canvPause.SetActive(true);
        Time.timeScale = 0;
    }
    public void ResumeGame()
    {
        canvPause.SetActive(false);
        Time.timeScale = speed;
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Restart()
    {
        SceneManager.LoadScene("Playing");
    }
    public void EndGame()
    {
        canvInGame.SetActive(false);
        canvEndGame.SetActive(true);
        Time.timeScale = 0;
    }
}
