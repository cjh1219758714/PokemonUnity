using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PokeMon.Manager;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System;

namespace PokeMon.Manager
{
    public class UIManager : MonoBehaviour
    {
        private GameManager gameManager; //  游戏管理器
        private Ray ray;
        private RaycastHit hit;
        public Button leftBtn;
       

       
        [Header("===== GameStart =====")]
        public GameObject loginPanel; // 游戏登录界面
        public GameObject controller; // 游戏控制器
        // Use this for initialization
        void Start()
        {
            gameManager = this.transform.GetComponent<GameManager>();
            
        }

        // Update is called once per frame
        void Update()
        {

          if(gameManager.gameState == GameManager.GameState.GamePre)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    gameManager.gameState = GameManager.GameState.GameStart;
                    loginPanel.SetActive(true);
                    controller.SetActive(true);
                    
                }
            }

          
        }

   
    }
}
