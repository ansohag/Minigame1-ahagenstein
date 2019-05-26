using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFlower1 : MonoBehaviour
{
    public Flower1 flower1Prefab;
    public GameObject flowerParent;

    private void Update()
    {
        //SpawnFl();
    }

    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            SpawnFlowr1();
        }

    }

    private void SpawnFlowr1()
    {
        Flower1 flower1Clone = (Flower1)Instantiate(flower1Prefab, transform.position, transform.rotation);
        float flower1Size = 0.15f;
        flower1Clone.transform.localScale = new Vector3(flower1Size, flower1Size, 0);
        flower1Clone.transform.SetParent(flowerParent.transform);
        flower1Clone.transform.localPosition = new Vector3(UnityEngine.Random.Range(-5f, 5f), flowerParent.transform.position.y, 0f);
        flower1Clone.GetComponent<Rigidbody2D>().velocity = new Vector2(UnityEngine.Random.Range(-2, 2), UnityEngine.Random.Range(-10, -1));

    }

}

