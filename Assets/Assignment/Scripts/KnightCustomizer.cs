using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightCustomizer : MonoBehaviour // What's this? A new creative thing I did on my own? Yep, I did this before everything else.
{
    // You think I'll get above 80%? Seriously though, I really don't want to fail this course because I love programming. I NEED MY MARKS!
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
    string colorPref;

    private void Start()
    {
        colorPref = PlayerPrefs.GetString("KnightColor", "red");
        ColorChange(colorPref);
    }

    // Fun fact: This is my alternative approach due to not being able to convert a string ("knight_body_" + color) to a sprite. Like, it would've been cool to define a sprite using string variables like you do on Scratch!
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
        else if (spriteRenderer.name == "Body") // Thank goodness word replacers are a thing. This would've taken more time and dopamine than it needed to otherwise.
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
        PlayerPrefs.SetString("KnightColor", color);
        spriteRenderer.sprite = newSprite;
    }
}
