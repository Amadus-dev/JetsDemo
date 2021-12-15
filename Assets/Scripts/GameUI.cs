using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    public static Text scoreText;
    public static Text lifescoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = transform.Find("Score").GetComponent<Text>();
        scoreText.text = "0";
        lifescoreText = transform.Find("LifeScore").GetComponent<Text>();
        lifescoreText.text = "5";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void UpdateScore(int score)
    {
        scoreText.text =  Convert.ToString(int.Parse(scoreText.text)+score);
        
        Animation animation = scoreText.GetComponent<Animation>();
        animation.Play();
    }
    
    public static void UpdateLifeScore(int score)
    {
        lifescoreText.text =  Convert.ToString(int.Parse(lifescoreText.text)-score);
        Animation animation = lifescoreText.GetComponent<Animation>();
        animation.Play();
    }
}
