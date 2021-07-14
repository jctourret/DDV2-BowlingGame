using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Win_Text : MonoBehaviour
{
    public Text winText;

    // Start is called before the first frame update
    void Start()
    {
        winText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Game_Manager.Get().pinsLeft == 0)
        {
            winText.text = "YOU WIN!";
        }
        if (Game_Manager.Get().triesLeft == 0 && Game_Manager.Get().pinsLeft > 0)
        {
            winText.text = "YOU LOSE!";
        }
    }
}
