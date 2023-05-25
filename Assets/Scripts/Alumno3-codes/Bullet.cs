using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float dieTime = 2f;
    void Start()
    {
        StartCoroutine(Timer());
    }
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collisionGameObject = collision.gameObject;
        if (collisionGameObject.name != "Player")
        {
            Destroy(gameObject);
        }
    }
    IEnumerator Timer()
    {
        yield return new WaitForSeconds(dieTime);
        Destroy(gameObject);
    }
}
