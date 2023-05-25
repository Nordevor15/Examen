using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timer = 10;
    public TextMeshProUGUI UItext;

    void Update()
    {
        timer -= Time.deltaTime;
        UItext.text = ""+timer.ToString("f0");
        if (timer <= 0.1)
        {
            SceneManager.LoadScene("Victoria");
        }
    }
}
