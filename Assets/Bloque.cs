using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Bloque : MonoBehaviour
{
    public GameObject Powerup1;
    public GameObject Powerup2;
    public GameObject Powerup3;
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
        if (collision.gameObject.tag == "Pelota")
        {
            Destroy(gameObject);
        }
    }
}
