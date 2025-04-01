using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TCPixel : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public Color color;

    void Start()
    {
        RandomColor();
        spriteRenderer = GetComponent<SpriteRenderer>();
       
    }
    private void Update()
    {
        spriteRenderer.color = color;
    }

    public void RandomColor()
    {
        float R = Random.value;
        float G = Random.value;
        float B = Random.value;
        color = new Color(R, G, B);
    }
}