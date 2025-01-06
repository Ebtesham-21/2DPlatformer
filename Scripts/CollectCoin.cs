using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{

    public GameObject Sparkle;
    public AudioClip collectSound;
    private Player player;

    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player")
        {
           
            player.coins++;
            Instantiate(Sparkle, gameObject.transform.position, gameObject.transform.rotation);
            audioSource.PlayOneShot(collectSound);
            Destroy(gameObject);
        }
    }
}
