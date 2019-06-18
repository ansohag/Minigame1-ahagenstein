using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower1 : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Flower wird destroyed wenn es den Collider Bottom berührt
        if (collision.gameObject.name == "ColliderBottom")
        {
            Destroy(gameObject);
        }
        //Flower wird destroyed wenn es die biene berührt 
        if (collision.gameObject.name == "bee")
        {
            Destroy(gameObject);
        }
    }
}
