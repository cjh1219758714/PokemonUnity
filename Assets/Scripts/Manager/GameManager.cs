using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

namespace PokeMon.Manager
{
    public class GameManager : MonoBehaviour {

        public GameState gameState;
        public UIManager uiManager;

        public bool isRecord = false;

        public enum GameState
        {
            GamePre,
            GameStart,
            Gameing,
            GameEnd,
        }

        public static GameManager Instance { get { return instance; } }
        private static  GameManager instance;

        void Awake(){
            instance = this;
            gameState = GameState.GamePre;
            uiManager = this.transform.GetComponent<UIManager>();
            if(File.Exists(Application.streamingAssetsPath + "/record.txt"))
            {
                isRecord = true;
            }
           

            
        }
   
     

	// Use this for initialization
    	void Start () {
		   
    	}
	
	// Update is called once per frame
	    void Update () {
           
	    }
}

}
