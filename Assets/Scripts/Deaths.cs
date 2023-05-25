using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Deaths : MonoBehaviour
{
    public Text textBoxPM;
    public Text textBoxLive;
    public int deaths;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        deaths = GameManager.deaths / 2;
        textBoxPM.text = deaths.ToString();
        textBoxLive.text = deaths.ToString();
    }
}
