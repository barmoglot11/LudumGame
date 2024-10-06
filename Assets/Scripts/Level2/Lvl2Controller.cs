using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl2Controller : MonoBehaviour
{
    public GameObject platform;
    public GameObject holder;
    private bool check = false;

    public Sprite newSprite;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.tag == "Bloha")
        {
            Debug.Log("123");
            check = true;
            spriteRenderer.sprite = newSprite;
        }
    }

    private void Update()
    {
        if (check)
        {
            platform.transform.position = Vector2.MoveTowards(platform.transform.position, new Vector2(-3, 0), Time.deltaTime);
            
        }
        
    }
}
