using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuSac : MonoBehaviour
{
    public Text txt;

    
    public void soin()
    {
        if(GameManager.Instance.p.potion > 0)
        {
            GameManager.Instance.c.hp = GameManager.Instance.c.hpMax;
            txt.text = "votre compagnon est soigné";
            GameManager.Instance.p.potion = GameManager.Instance.p.potion - 1;
        }
        else
        {
            txt.text = "vous n'avaiez pas de potion";
        }
    }

    public void reset()
    {
        txt.text =" ";
    }
}
