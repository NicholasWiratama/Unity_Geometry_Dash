using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeIcon: MonoBehaviour
{
    public Sprite Wave;
    public Sprite Cube;
    public SpriteRenderer render;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Wave Portal"))
        {
            render.sprite = Wave;
        }
        else
        {
            render.sprite = Cube;
        }
    }
}
