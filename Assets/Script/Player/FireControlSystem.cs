using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireControlSystem : MonoBehaviour
{

    public PlayerFireScript[] upgrade0;
    public PlayerFireScript[] upgrade1;
    public PlayerFireScript[] upgrade2;
    
    public int getItemCount = 0;

    [SerializeField]
    public float firingTimer;
    private float timer = 0;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        FireFunction();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Item")
        {
            getItemCount++;
        }
    }

    void FireFunction()
    {
        if (Input.GetKey(KeyCode.Space) && timer >= firingTimer)
        {
            for (int i = 0; i < upgrade0.Length; i++)
            {
                upgrade0[i].Fire();
            }

            if (getItemCount >= 1)
            {
                for (int i = 0; i < upgrade1.Length; i++)
                {
                    upgrade1[i].Fire();
                }
            }
            if (getItemCount >= 2)
            {
                for (int i = 0; i < upgrade2.Length; i++)
                {
                    upgrade2[i].Fire();
                }
            }
            timer = 0;
        }
    }
}
