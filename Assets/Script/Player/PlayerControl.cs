using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float horizontalSpeed;
    public float verticalSpeed;

    private float accelationSpeed;
    
    [SerializeField]
    private Transform firingLocation;
    void Start()
    {

    }
    
    void Update()
    {
        PlayerContoller();
        SetPlayground();
    }

    private void PlayerContoller()
    {
        // 방향키 위
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * verticalSpeed * Time.deltaTime);
        }

        // 방향키 아래 
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * verticalSpeed * Time.deltaTime);
        }

        // 방향키 왼쪽
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * horizontalSpeed * Time.deltaTime);
        }

        // 방향키 오른쪽
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * horizontalSpeed * Time.deltaTime);
        }
    }

    private void SetPlayground()
    {
        if (transform.position.x >= 8.35)
        {
            transform.position = new Vector3(8.35f, transform.position.y);
        }
        if (transform.position.x <= -8.35)
        {
            transform.position = new Vector3(-8.35f, transform.position.y);
        }
        if (transform.position.y >= 4.5)
        {
            transform.position = new Vector3(transform.position.x, 4.5f);
        }
        if (transform.position.y <= -4.5)
        {
            transform.position = new Vector3(transform.position.x, -4.5f);
        }
    }
}
