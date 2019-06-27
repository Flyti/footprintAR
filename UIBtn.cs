using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIBtn : MonoBehaviour
{

    public int launchStageCode;    

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MenuBtnClick()
    {
        if (StageManger.instance != null) {
            StageManger.instance.StageStartUp(this);
        }
        
    }


}
