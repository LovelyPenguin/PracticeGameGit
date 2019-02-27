using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    [SerializeField]
    private RectTransform[] image;
    private RectTransform temp;
    void Start()
    {

    }
    
    void Update()
    {
        for (int i = 0; i < image.Length; i++)
        {
            image[i].Translate(Vector3.down * 500 * Time.deltaTime);
            if (image[0].position.y <= 0)
            {
                image[i + 1].localPosition = new Vector3(0, image[0].localPosition.y + 1638, 0);
                temp = image[i];
                image[i] = image[i + 1];
                image[i + 1] = temp;
            }
        }
    }
}
