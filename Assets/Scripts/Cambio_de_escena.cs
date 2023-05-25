using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cambio_de_escena : MonoBehaviour
{
    public void CambiarEscena(string Creditos)
    {
        SceneManager.LoadScene(Creditos);
    }
}
