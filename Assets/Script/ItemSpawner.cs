using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject item;
    [SerializeField]
    private float interval;
    private float timer = 0f;

    void Start()
    {

    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= interval)
        {
            Instantiate(item, new Vector3(Random.RandomRange(-8.35f, 8.35f), transform.position.y, 0), Quaternion.identity);
            timer = 0f;
        }
    }
}
