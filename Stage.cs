using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage : MonoBehaviour
{

    public int stagecode;
    public AnimationPlayer[] StartanimationPlayers = null;
    public AnimationPlayer[] CloseanimationPlayers = null;

    public bool isActive;

    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void StageShow()
    {
        if (StartanimationPlayers != null)
        {
            foreach (var ap in StartanimationPlayers)
            {
                ap.AnimationPlay();
            }
        }
        Debug.Log("stage:" + stagecode + " show");

        isActive = true;

    }
    public void StageClose()
    {       

        if (CloseanimationPlayers != null)
        {
            foreach (var ap in CloseanimationPlayers)
            {
                ap.AnimationClose();
            }
        }
        Debug.Log("stage:" + stagecode + " close");
        isActive = false;
    }
}
