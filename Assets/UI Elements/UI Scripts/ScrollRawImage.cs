using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class ScrollRawImage : MonoBehaviour
{
    public float horizontalSpeed;
    public float verticalSpeed;

    RawImage myRawImage;
    void Start()
    {
        myRawImage = GetComponent<RawImage>();
    }

    // Update is called once per frame
    void Update()
    {
        Rect currentUv = myRawImage.uvRect;
        currentUv.x -= Time.deltaTime * horizontalSpeed;
        currentUv.y -= Time.deltaTime * verticalSpeed;

        if (currentUv.x <= -1f || currentUv.x >= 1f)
        {
            currentUv.x = 0;
        }

        if (currentUv.y <= -1f || currentUv.y>=1f)
        {
            currentUv.y = 0;
        }

        myRawImage.uvRect = currentUv;
    }
}
