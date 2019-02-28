using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFireScript : MonoBehaviour
{
    [SerializeField]
    private GameObject bullet;
    [SerializeField]
    //private GameObject muzzleFlash;

    void Start()
    {

    }


    void Update()
    {

    }

    public void Fire()
    {
        //Instantiate(muzzleFlash, transform.position, Quaternion.identity);
        Instantiate(bullet, transform.position, transform.rotation);
    }
}
