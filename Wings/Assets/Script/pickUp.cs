using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class pickUp : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject pickupEff;
    public AudioClip pickupSound;
    AudioSource pickupSource;

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //pickupSource.Play();
            Debug.Log("picked up");
            //pickupSource.PlayOneShot(pickupSound);
            Destroy(this.gameObject);
            ScrapPickUp(collision);
        }
        
    }
    void Start()
    {
        pickupSource =  GameObject.FindGameObjectWithTag("SoundManager").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ScrapPickUp(Collider2D playerC)
    {
        PlayerStats stats = playerC.GetComponent<PlayerStats>();
        pickupSource.PlayOneShot(pickupSound);
        stats.scraps += 1;   
    }
}
