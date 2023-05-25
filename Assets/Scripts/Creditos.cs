using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Creditos : MonoBehaviour
{
    public Text textBoxPM;
    public Text textBoxLive;
    public int creditos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        creditos = GameManager.creditos / 2;
        textBoxPM.text = creditos.ToString();
        textBoxLive.text = creditos.ToString();
    }
}
