using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSmoke : MonoBehaviour
{
    public Smoke smokePrefab;
    public GameObject badParent;

    private void Update()
    {
        //SpawnFl();
    }

    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            SpawnSmok();
        }

    }

    private void SpawnSmok()
    {
        Smoke smokeClone = (Smoke)Instantiate(smokePrefab, transform.position, transform.rotation);
        float smokeSize = 0.15f;
        smokeClone.transform.localScale = new Vector3(smokeSize, smokeSize, 0);
        smokeClone.transform.SetParent(badParent.transform);
        smokeClone.transform.localPosition = new Vector3(UnityEngine.Random.Range(-5f, 5f), badParent.transform.position.y, 0f);
        smokeClone.GetComponent<Rigidbody2D>().velocity = new Vector2(UnityEngine.Random.Range(-0, 0), UnityEngine.Random.Range(-5, -1));

    }

}