using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    #region Singleton

    public static GameManager Instance;

    void Awake()
    {
        if(Instance != null)
        {
            //Debug.Debug.LogWarning("More than one instance of GameManager found!");
            return;

        }
        Init();
        Instance = this;

    }
    #endregion

    public Player p{
        get;private set;}

    public Compagnon c{
        get; set;}

    public CompagnonE ce{
        get; set;}


    void Init()
    {
        

        c = new Compagnon();

        p = new Player();

        ce = new CompagnonE();
    }
    }

    
    

