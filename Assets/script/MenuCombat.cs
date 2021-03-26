using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuCombat : MonoBehaviour
{

    public GameObject PrefRougeF;
    public GameObject PrefVertF;
    public GameObject PrefBleuF;
    public GameObject PrefJauneF;

    public GameObject PrefRougeD;
    public GameObject PrefVertD;
    public GameObject PrefBleuD;
    public GameObject PrefJauneD;

    public Slider vieComp;
    public Slider vieEnemie;

    public Text txt;

    public int alea;


    public enum BattleStates
    {
        START,
        PLAYERCHOICE,
        ENEMYCHOICE,
        LOSE,
        WIN
    }
    public BattleStates currentState;
    // Start is called before the first frame update
    void start()
    {

        currentState = BattleStates.START;
        SetupBattle();
    }
    
public void SetupBattle()
    {
        switch (currentState)
        {
        case (BattleStates.START):
        alea = Random.Range(1,4);
        if(alea == 1)
        {
            PrefVertF.SetActive(false);
            PrefBleuF.SetActive(false);
            PrefJauneF.SetActive(false);
            
        }
        else if(alea == 2 )
        {
            PrefRougeF.SetActive(false);
            PrefBleuF.SetActive(false);
            PrefJauneF.SetActive(false);

        }
        else if(alea == 3 )
        {
            PrefVertF.SetActive(false);
            PrefRougeF.SetActive(false);
            PrefJauneF.SetActive(false);
            
        }
        else if(alea == 4)
        {
            PrefVertF.SetActive(false);
            PrefRougeF.SetActive(false);
            PrefBleuF.SetActive(false);
        }

        if( GameManager.Instance.p.compagnon == 1)
        {
            PrefVertD.SetActive(false);
            PrefBleuD.SetActive(false);
            PrefJauneD.SetActive(false);
        }
        else if( GameManager.Instance.p.compagnon == 2)
        {
            PrefRougeD.SetActive(false);
            PrefBleuD.SetActive(false);
            PrefJauneD.SetActive(false);
        }
        else if( GameManager.Instance.p.compagnon == 3)
        {
            PrefVertD.SetActive(false);
            PrefRougeD.SetActive(false);
            PrefJauneD.SetActive(false);
        }
        else if(GameManager.Instance.p.compagnon == 4)
        {
            PrefVertD.SetActive(false);
            PrefBleuD.SetActive(false);
            PrefRougeD.SetActive(false);
        }

        vieComp.value = GameManager.Instance.c.hp;
        vieEnemie.value = GameManager.Instance.ce.hp;

                currentState = BattleStates.PLAYERCHOICE;
            break;

            case (BattleStates.PLAYERCHOICE):

            vieComp.value = GameManager.Instance.c.hp;
            vieEnemie.value = GameManager.Instance.ce.hp;
            if(GameManager.Instance.ce.hp > 0)
            {
                currentState = BattleStates.ENEMYCHOICE;
            }
            else
            {
                currentState = BattleStates.WIN;
            }
            
            break;

            case(BattleStates.ENEMYCHOICE):
                vieComp.value = GameManager.Instance.c.hp;
                vieEnemie.value = GameManager.Instance.ce.hp;
                alea = Random.Range(1,2);
                if(alea==1)
                {
                    GameManager.Instance.c.hp = GameManager.Instance.c.hp - 2;
                }
                else
                {
                    GameManager.Instance.c.hp = GameManager.Instance.c.hp - 4;
                    
                }

                vieComp.value = GameManager.Instance.c.hp;
                vieEnemie.value = GameManager.Instance.ce.hp;

                if(GameManager.Instance.c.hp > 0){
                    currentState = BattleStates.PLAYERCHOICE;
                }
                else
                {
                    currentState = BattleStates.LOSE;
                }
            break;

            case (BattleStates.LOSE):
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
            break;

            case (BattleStates.WIN):
                GameManager.Instance.ce.hp = GameManager.Instance.ce.hpMax;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            break;
        }
    }

}
