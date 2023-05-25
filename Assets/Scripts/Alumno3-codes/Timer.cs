using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timer = 30;
    public TextMeshProUGUI UItext;

    void Update()
    {
        timer -= Time.deltaTime;
        UItext.text = ""+timer.ToString("f0");
        if (timer == 0)
        {
            //cambio de escena
        }
    }
}
