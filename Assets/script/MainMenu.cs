using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    [Header("Sounds")]
    [SerializeField] private AudioClip Music;
    
    void start()
    {
        AudioManager.Instance.PlayMusicWithFade(Music);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void chargePrefF()
    {
        GameManager.Instance.p.compagnon = 1;
    }

    public void chargePrefP()
    {
        GameManager.Instance.p.compagnon = 2;
    }

    public void chargePrefE()
    {
        GameManager.Instance.p.compagnon = 3;
    }

    public void chargePrefL()
    {
        GameManager.Instance.p.compagnon = 4;
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
}
