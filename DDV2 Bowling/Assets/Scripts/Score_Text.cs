using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Score_Text : MonoBehaviour
{
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
    }
    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Your score was: " + Game_Manager.Get().score;
    }
}
