using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManger : MonoBehaviour
{

    public Stage[] stages;

    public int currentStageCode;
    public bool StageIsActive;

    public static StageManger instance;

    // Use this for initialization
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }

    }

 
    public void StageStartUp(UIBtn uIBtn)
    {
        //如果 目標Stage = 當前Stage(已開啟)
        if (uIBtn.launchStageCode == currentStageCode && StageIsActive)
        {
            CloseCurrentStage();
        }
        else
        {
            currentStageCode = uIBtn.launchStageCode;
            CloseOtherStage();
            //啟動目標 Stage
            foreach (var st in stages) //找到目標Stage
            {
                if (st.stagecode == uIBtn.launchStageCode)
                {
                    st.StageShow();                    
                }

            }
            StageIsActive = true;


        }

    }
    //關閉其他 Stage
    private void CloseOtherStage()
    {
        foreach (var st in stages)
        {
            if (st.stagecode != currentStageCode && st.isActive)
            {
                st.StageClose();
                StageIsActive = false;
            }

        }
    }
    //關閉當前 Stage
    private void CloseCurrentStage()
    {
        foreach (var st in stages)
        {
            if (st.stagecode == currentStageCode)
            {
                st.StageClose();
                StageIsActive = false;
            }

        }
    }
}
