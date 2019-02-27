using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float horizontalSpeed;
    public float verticalSpeed;

    private float accelationSpeed;
    void Start()
    {

    }
    
    void Update()
    {
        PlayerContoller();
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

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hit");
    }
}
