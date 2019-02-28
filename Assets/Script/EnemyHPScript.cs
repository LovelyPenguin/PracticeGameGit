using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHPScript : MonoBehaviour
{
    [SerializeField]
    private GameObject item;
    [Range(0,100)]
    public float itemDropPercentage;
    [SerializeField]
    private int helthPoint = 10;
    [SerializeField]
    private GameObject particle;

    void Start()
    {

    }
    
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PlayerBullet")
        {
            helthPoint--;
            if (helthPoint <= 0)
            {
                Instantiate(particle, transform.position, Quaternion.identity);
                float per = Random.RandomRange(0, 100);
                if (per <= itemDropPercentage)
                {
                    Instantiate(item, transform.position, Quaternion.identity);
                }
                Destroy(gameObject);
            }
        }
    }
}
