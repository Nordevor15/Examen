using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int deaths = 0;
    public static int wins = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        deaths++;
        wins++;
    }
}
