using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class combat : MonoBehaviour
{
    public void attaque1()
    {
        GameManager.Instance.ce.hp = GameManager.Instance.ce.hp - 2;
        
    }

    public void attaque2()
    {
        GameManager.Instance.ce.hp = GameManager.Instance.ce.hp - 4;
    }


}