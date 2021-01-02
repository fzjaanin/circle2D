using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
   public Score score;
   public Text scoreText;
   public Text highScoreText;
   public Text scoreFinal;
   public Image panel;
   public static UI instance;

   public void UpdateScore(){
   	scoreText.text=score.currentScore.ToString();
   }

   public void activePanel(){
   	panel.gameObject.SetActive(true);
   	scoreFinal.text=scoreText.text;
   	highScoreText.text=PlayerPrefs.GetInt("score").ToString();

   }
   void Awake(){
      instance = GetComponent<UI>();
   }

}
