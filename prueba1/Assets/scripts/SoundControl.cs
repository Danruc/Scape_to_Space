using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision){

        foreach (ContactPoint contact in collision.contacts){
            Debug.Log(contact.point + " " + contact.normal);
            Debug.DrawLine(contact.point, (contact.point + contact.normal) * 2, Color.red, 5);
        }

        if(collision.relativeVelocity.magnitude > 2){
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
        }
    }
}
