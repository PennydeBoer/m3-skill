using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MyPixel : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    [SerializeField] private GameObject Pixel;
    [SerializeField] private Byte ByteR;
    [SerializeField] private Byte ByteG;
    [SerializeField] private Byte ByteB;
    [SerializeField] private string colorCode;
    
    private void Update()
    {
        if (Pixel != null)
        {
            spriteRenderer = Pixel.GetComponent<SpriteRenderer>();
        }

        if (ByteR != null && ByteG != null && ByteB != null && Pixel != null)
        {
            colorCode = "#" + ByteR.getHex() + ByteG.getHex() + ByteB.getHex();

            if (UnityEngine.ColorUtility.TryParseHtmlString(colorCode, out Color newColor))
            {
                spriteRenderer.color = newColor;
            }
            else
            {
                Debug.LogError("Ongeldige hex kleur: " + colorCode);
            }
        }
    }
}
