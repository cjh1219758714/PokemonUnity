using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PokeMon.Manager;

public class GameStartToggle : MonoBehaviour {


    public int selectItem = 0;
    public static int itemCount = 2;
    public List<Toggle> gameStartToggles = new List<Toggle>();

    public GameObject newGame;
    public GameObject record;
    public GameObject gameSetting;

    // Use this for initialization
    void Start()
    {
        if (GameManager.Instance.isRecord)
        {
            itemCount = 2;
            Instantiate(newGame, this.transform);
            Instantiate(record, this.transform);
            Instantiate(gameSetting, this.transform);
           
        }
        else
        {
            itemCount = 1;
            Instantiate(newGame, this.transform);
            Instantiate(gameSetting, this.transform);
        }
        
        for (int i = 0; i < this.transform.childCount; i++)
        {
            gameStartToggles.Add(this.transform.GetChild(i).GetComponent<Toggle>());
            gameStartToggles[i].onValueChanged.AddListener(delegate (bool isOn)
            {
                ShowSelectToggle();
            });
        }
        gameStartToggles[selectItem].isOn = true;
        
    }
	// Update is called once per frame
	void Update () {
		
	}

     private void ShowSelectToggle()
    {
        for (int i = 0; i < gameStartToggles.Count; i++)
        {
            gameStartToggles[i].GetComponent<Image>().color = new Color(1, 1, 1, 0.5f);
            gameStartToggles[i].isOn = false;
        }
        gameStartToggles[selectItem].GetComponent<Image>().color = new Color(1, 1, 1, 1);
    }

}
