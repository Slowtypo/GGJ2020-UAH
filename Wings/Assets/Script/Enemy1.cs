using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    public Transform player;
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;
    public bool isPlayerFound;
    public float speed1 = 2.0f;
    private Vector2 screenBounds1;
    private Collider2D damageRange;

    public Animator animEnemy;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -speed1);
        screenBounds1 = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        player = GameObject.FindGameObjectWithTag("Player").transform;
        damageRange = this.gameObject.GetComponentInChildren<CircleCollider2D>();



    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < screenBounds1.y * -2)
        {
            Destroy(this.gameObject);
        }

        animEnemy.SetFloat("Movement", moveSpeed);

    }
    private void FixedUpdate()
    {
        moveCharacter(movement);
    }
    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }

    // Trigger that sets up the 
    
    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {

            rb.velocity = new Vector2(0, 0);
            Vector3 direction = player.position - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            //rb.rotation = angle;
            direction.Normalize();
            movement = direction;
            this.gameObject.GetComponent<SpriteRenderer>().color = Color.red;
            animEnemy.SetBool("PlayerIsFound",true);
        }
        else
        {
            rb.velocity = new Vector2(0, -speed1);
            //rb.position.Normalize();
            this.gameObject.GetComponent<SpriteRenderer>().color = Color.yellow;
            animEnemy.SetBool("PlayerIsFound", false);
        }

        
       
    }

    


    


}
