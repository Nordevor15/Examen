using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Ganados : MonoBehaviour
{
    public Text textBoxPM;
    public Text textBoxLive;
    public int wins;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        wins = GameManager.wins / 2;
        textBoxPM.text = wins.ToString();
        textBoxLive.text = wins.ToString();
    }
}
