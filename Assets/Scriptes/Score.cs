using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int score;
    public int currentScore=>score;

    public void scoreUp(){
    	score++;
        UI.instance.UpdateScore();
    }

    

    public void setHighScore(){
    	if(score>PlayerPrefs.GetInt("score"))
    	PlayerPrefs.SetInt("score",score);
    }
}
