using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFlower2 : MonoBehaviour
{
    public Flower2 flower2Prefab;
    public GameObject flowerParent;

    private void Update()
    {
        //SpawnFl();
    }

    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(8);
            SpawnFlowr2();
        }

    }

    private void SpawnFlowr2()
    {
        Flower2 flower2Clone = (Flower2)Instantiate(flower2Prefab, transform.position, transform.rotation);
        float flower2Size = 0.15f;
        flower2Clone.transform.localScale = new Vector3(flower2Size, flower2Size, 0);
        flower2Clone.transform.SetParent(flowerParent.transform);
        flower2Clone.transform.localPosition = new Vector3(UnityEngine.Random.Range(-5f, 5f), flowerParent.transform.position.y, 0f);
        flower2Clone.GetComponent<Rigidbody2D>().velocity = new Vector2(UnityEngine.Random.Range(-2, 2), UnityEngine.Random.Range(-10, -1));

    }

}