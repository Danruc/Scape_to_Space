using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject gc = GameObject.Find("GameController");
        Lvl3Q2GameController gc3 = gc.GetComponent<Lvl3Q2GameController>();
        gc3.score += 100;
        collision.gameObject.active = false;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
