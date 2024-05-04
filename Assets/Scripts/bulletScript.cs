using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5;
    public bool goingLeft = false;

    public AudioSource audioPlayer;


    public playerHpScript phs;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position += transform.right * speed * Time.deltaTime;


    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            phs = other.transform.GetComponent<playerHpScript>();
            if (other.gameObject.layer == 8)
            {
                phs=other.gameObject.GetComponent<playerHpScript>();
                phs.takeDamage(transform.position);
                Debug.Log("cagirildi");
                Destroy(gameObject);

            }

        }
    }
}
