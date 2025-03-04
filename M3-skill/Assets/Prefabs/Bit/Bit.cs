using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bit : MonoBehaviour
{
    SpriteRenderer spriteRenderer; // Variabele om de sprite op te slaan

    void Start()
    {
        // Haal de SpriteRenderer op en sla het op in de variabele
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    public bool state = false; // Houdt de status van de bit bij

    void Update()
    {
        if (state)
        {
            // Zet de sprite kleur op groen als state true is
            spriteRenderer.color = Color.green;
        }
        else
        {
            // Zet de sprite kleur op rood als state false is
            spriteRenderer.color = Color.red;
        }
    }
    private void OnMouseUp()
    {
        state = !state; // Wissel tussen true en false
    }
}
