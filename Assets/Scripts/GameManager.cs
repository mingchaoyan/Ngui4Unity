using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
    public enum Difficulties
    {
        Normal,
        Hard
    }
    public static Difficulties Difficulty =  
        Difficulties.Normal;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void ExitPressed()
    {
        //Exit Now
        Application.Quit();
    }

    public void OnDifficultyChange()
    {
        //If Difficulty changes to Normal, set Difficulties.Normal
        if(UIPopupList.current.value == "Normal")
            Difficulty = Difficulties.Normal;
        //Otherwise, set it to Hard
        else Difficulty = Difficulties.Hard;
    }

}
