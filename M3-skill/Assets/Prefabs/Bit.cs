using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bit : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private bool state = false;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnMouseDown()
    {
        if (state)
        {
            spriteRenderer.color = Color.red;
            state = false;
        }
        else
        {
            state = true;
            spriteRenderer.color = Color.green;
        }

    }
}