using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PokeMon.Manager;
using UnityEngine.EventSystems;


public class ChooseBtnListener :  ButtonListener,IPointerDownHandler,IPointerUpHandler,IPointerClickHandler {

    private GameStartToggle toggle;

    // Use this for initialization
    void Start () {
        toggle = GameObject.Find("Login").transform.GetChild(0).GetComponent<GameStartToggle>();
    }
	


    public void OnPointerClick(PointerEventData eventData)
    {
        print(choose);
        if(choose == Choose.A)
        {
            print("test");
            if(toggle.selectItem == 0 )
            {
                print(" New Game Start!");
            }

            else if(toggle.selectItem == 1 && !GameManager.Instance.isRecord)
            {
                print("Open Setting Panel!");
            }

            else if(toggle.selectItem == 1 && GameManager.Instance.isRecord)
            {
                print("Loading Record");
            }
            else if (toggle.selectItem == 2 && GameManager.Instance.isRecord)
            {
                print("Open Setting Panel!");
            }
        }

        
    }

    public void OnPointerDown(PointerEventData eventData)
    {
       
    }

    public void OnPointerUp(PointerEventData eventData)
    {
      
    }
}
