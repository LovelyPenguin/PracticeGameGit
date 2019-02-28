using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleDestroy : MonoBehaviour
{
    public ParticleSystem par;

    void Start()
    {

    }

    void Update()
    {
        Destroy(gameObject, par.duration);
    }
}
