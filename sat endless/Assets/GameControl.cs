using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{

    public GameObject GameMenu;
    public GameObject InPlayer;
    public GameObject GameCamera;
    public GameObject InGameMenu;

    public GameObject PlayingMenu;

    public Text score;
    public Text bigScore;
    float ScoreCount;
    bool fail;
    void Update() {

        if (fail)
        {
            ScoreCount += Time.deltaTime*2;
            score.text = ScoreCount.ToString("00");
        }
        
    }
    public void playGame() {

        fail = true;
        GameMenu.SetActive(false);
        GameCamera.GetComponent<CameraFollow>().enabled = true;
        InPlayer.SetActive(true);
        PlayingMenu.SetActive(true);
        
    }

    public void Quit() {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Failed() {

        fail = false;
        bigScore.text = ScoreCount.ToString("00");
        PlayingMenu.SetActive(false);
        InGameMenu.SetActive(true);
        
    
    }

    public void removeAds() {

        PlayerPrefs.SetInt("nads", 1);
    
    }

}
