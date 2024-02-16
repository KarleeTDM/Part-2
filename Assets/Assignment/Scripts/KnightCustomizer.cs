using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightCustomizer : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite blackBodySprite;
    public Sprite blueBodySprite;
    public Sprite greenBodySprite;
    public Sprite orangeBodySprite;
    public Sprite redBodySprite;
    public Sprite whiteBodySprite;
    public Sprite yellowBodySprite;
    public Sprite blackHeadSprite;
    public Sprite blueHeadSprite;
    public Sprite greenHeadSprite;
    public Sprite orangeHeadSprite;
    public Sprite redHeadSprite;
    public Sprite whiteHeadSprite;
    public Sprite yellowHeadSprite;
    Sprite newSprite;

    public void ColorChange(string color)
    {
        if (spriteRenderer.name == "Head")
        {
            if (color == "black")
            {
                newSprite = blackHeadSprite;
            }
            else if (color == "blue")
            {
                newSprite = blueHeadSprite;
            }
            else if (color == "green")
            {
                newSprite = greenHeadSprite;
            }
            else if (color == "orange")
            {
                newSprite = orangeHeadSprite;
            }
            else if (color == "red")
            {
                newSprite = redHeadSprite;
            }
            else if (color == "white")
            {
                newSprite = whiteHeadSprite;
            }
            else if (color == "yellow")
            {
                newSprite = yellowHeadSprite;
            }
        }
        else if (spriteRenderer.name == "Body")
        {
            if (color == "black")
            {
                newSprite = blackBodySprite;
            }
            else if (color == "blue")
            {
                newSprite = blueBodySprite;
            }
            else if (color == "green")
            {
                newSprite = greenBodySprite;
            }
            else if (color == "orange")
            {
                newSprite = orangeBodySprite;
            }
            else if (color == "red")
            {
                newSprite = redBodySprite;
            }
            else if (color == "white")
            {
                newSprite = whiteBodySprite;
            }
            else if (color == "yellow")
            {
                newSprite = yellowBodySprite;
            }
        }
        ChangeSprite();
    }

    void ChangeSprite()
    {
        spriteRenderer.sprite = newSprite;
    }
}
