using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFlower3 : MonoBehaviour
{
    public Flower3 flower3Prefab;
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
            SpawnFlowr3();
        }

    }

    private void SpawnFlowr3()
    {
        Flower3 flower3Clone = (Flower3)Instantiate(flower3Prefab, transform.position, transform.rotation);
        float flower3Size = 0.15f;
        flower3Clone.transform.localScale = new Vector3(flower3Size, flower3Size, 0);
        flower3Clone.transform.SetParent(flowerParent.transform);
        flower3Clone.transform.localPosition = new Vector3(UnityEngine.Random.Range(-5f, 5f), flowerParent.transform.position.y, 0f);
        flower3Clone.GetComponent<Rigidbody2D>().velocity = new Vector2(UnityEngine.Random.Range(-0, 0), UnityEngine.Random.Range(-5, -1));

    }

}
