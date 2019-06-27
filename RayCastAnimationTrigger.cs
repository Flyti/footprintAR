using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastAnimationTrigger : MonoBehaviour
{

    public AnimationPlayer[] animationPlayer;
    public int condition;
    public int count;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

#if UNITY_EDITOR
        //PC編輯模式
        //點擊滑鼠左鍵

        if (Input.GetMouseButtonDown(0))
        {

            //雷射線初始化
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //雷射線碰撞
            RaycastHit hit;
            //雷射線碰撞到物件且碰撞到本體
            if (Physics.Raycast(ray, out hit) && hit.transform.gameObject == this.gameObject)
            {
                count++;
                Debug.Log(gameObject.name + "raycast hit");
                if (count > condition)
                {
                    foreach (var ap in animationPlayer)
                    {
                        Debug.Log("Angryplay");
                        ap.AnimationPlay();

                    }
                    count = 0;
                }

            }

        }
        //放開滑鼠
        if (Input.GetMouseButtonUp(0))
        {

        }


        //手機模式
        //點擊螢幕
#elif UNITY_ANDROID || UNITY_IPHONE
        //點擊螢幕
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            //雷射線初始化
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            //雷射線碰撞
            RaycastHit hit;
            //雷射線碰撞到物件且碰撞到本體
            if (Physics.Raycast(ray, out hit) && hit.transform.gameObject == this.gameObject)
            {
                 count++;
                Debug.Log(gameObject.name + "raycast hit");
                if (count > condition)
                {
                    foreach (var ap in animationPlayer)
                    {
                        Debug.Log("Angryplay");
                        ap.AnimationPlay();

                    }
                    count = 0;
                }
            }
        } 
#endif
    }
}
