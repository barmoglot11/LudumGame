using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public GameObject wall;
    public GameObject upper_holder;
    public GameObject lower_holder;
    private bool check = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Inter")
        {
            //SpriteRenderer spriteRenderer = collision.GetComponent<SpriteRenderer>();
            collision.gameObject.GetComponent<SpriteRenderer>().enabled = false;
            check = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Inter")
        {
            //SpriteRenderer spriteRenderer = collision.GetComponent<SpriteRenderer>();
            collision.gameObject.GetComponent<SpriteRenderer>().enabled = true;
            check = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (check)
        {
            wall.transform.position = Vector2.MoveTowards(wall.transform.position, lower_holder.transform.position, Time.deltaTime);
        }
        else
        {
            wall.transform.position = Vector2.MoveTowards(wall.transform.position, upper_holder.transform.position, Time.deltaTime);
        }
    }
}
