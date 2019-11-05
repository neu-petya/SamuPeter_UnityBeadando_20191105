using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPicked : MonoBehaviour
{
    void Start()
    {
        //Debug.Log("collision.gameObject.name: " + gameObject.name);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("Collide");
        //Debug.Log("collision.gameObject.name: " + collision.gameObject.name);
        //Debug.Log("gameObject.name: " + gameObject.name);
        if (collision.gameObject.name == "Body")
        {
            //Destroy(gameObject);
            CreateNewCoin();
            //Begin();
        }
    }

    void CreateNewCoin()
    {
        StartCoroutine(Begin());
    }

    IEnumerator Begin()
    {
        float xRandomTime = Random.Range(1, 5);
        var scale = transform.localScale;
        transform.localScale = new Vector3(0, 0, 0);
        yield return new WaitForSeconds(xRandomTime);
        transform.localScale = scale;
        transform.position = new Vector3(Random.Range(-17, 17), 8, 0);
    }
}
