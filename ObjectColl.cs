using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectColl : MonoBehaviour
{
    private PlayerMovement _player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _player = GameObject.Find("Player").GetComponent<PlayerMovement>();
        if (collision.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
