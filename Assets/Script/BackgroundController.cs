using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    [SerializeField]
    private Transform top;
    [SerializeField]
    private Transform bottom;

    public float scrollSpeed = 10f;

    private Transform temp;
    void Start()
    {

    }
    
    void Update()
    {
        ScrollBackgrond();
    }

    private void ScrollBackgrond()
    {
        top.Translate(Vector3.down * scrollSpeed * Time.deltaTime);
        bottom.Translate(Vector3.down * scrollSpeed * Time.deltaTime);

        if (top.position.y <= -5)
        {
            bottom.position = new Vector3(0, top.position.y + 20.4f, 0);
        }

        if (bottom.position.y <= -5)
        {
            top.position = new Vector3(0, bottom.position.y + 20.4f, 0);
        }
    }
}
