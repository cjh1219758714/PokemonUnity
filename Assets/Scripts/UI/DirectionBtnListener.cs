using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using PokeMon.Manager;

public class DirectionBtnListener : ButtonListener,IPointerDownHandler,IPointerUpHandler,IPointerClickHandler {

    private GameStartToggle toggle;

	// Use this for initialization
	void Start () {
        toggle = GameObject.Find("Login").transform.GetChild(0).GetComponent<GameStartToggle>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnPointerDown(PointerEventData eventData)
    {
        
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        
    }

    public void OnPointerClick(PointerEventData eventData)
    {
       if(GameManager.Instance.gameState == GameManager.GameState.GameStart)
        {
           if(direction == Direction.Up)
            {
                if (toggle.selectItem >0)
                {
                    toggle.selectItem--;
                    toggle.gameStartToggles[toggle.selectItem].isOn = true;
                }
                else
                {
                    toggle.selectItem = GameStartToggle.itemCount;
                    toggle.gameStartToggles[toggle.selectItem].isOn = true;
                }
            }

            if (direction == Direction.Down)
            {
                if (toggle.selectItem <GameStartToggle.itemCount)
                {
                    toggle.selectItem++;
                    toggle.gameStartToggles[toggle.selectItem].isOn = true;
                }
                else
                {
                    toggle.selectItem = 0;
                    toggle.gameStartToggles[toggle.selectItem].isOn = true;
                }
            }
        }
    }
}
