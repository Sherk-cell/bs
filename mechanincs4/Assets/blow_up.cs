using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blow_up : MonoBehaviour
{
    public GameObject particleEffect;
    private ParticleSystem partSys;
    private void Start()
    {
       // var particleMainSettings = partSys.main;
       // particleMainSettings.loop ^= true;


    }
    void OnMouseUp()
    {

        //If your mouse hovers over the GameObject with the script attached, output this message
        // partSys = GetComponent<ParticleSystem>();
        // partSys.Stop();
        GameObject boom = Instantiate(particleEffect, transform.position, Quaternion.identity);
        //boom.GetComponent<ParticleSystem>();
        Destroy(boom, 1.0f);
       
        Destroy(gameObject);
        // partSys.Stop();
        Debug.Log("works");      
       // partSys.Play();

    }

  
}