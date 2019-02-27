using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFireScript : MonoBehaviour
{
    public GameObject bullet;
    public Transform fireLoacation;
    public float firingTimer;
    private float timer;

    void Start()
    {

    }


    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Fire();
        }
    }

    void Fire()
    {
        timer += Time.deltaTime;

        if (timer >= firingTimer)
        {
            Instantiate(bullet, fireLoacation.position, fireLoacation.rotation);
            timer = 0f;
        }
    }
}
