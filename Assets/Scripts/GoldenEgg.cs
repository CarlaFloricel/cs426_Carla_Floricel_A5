using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldenEgg : MonoBehaviour
{
    [SerializeField] ParticleSystem particleSystem; 


 void OnCollisionEnter(Collision collision){
        
        
        if(collision.gameObject.tag == "GoldenEgg")
        GetComponent<ParticleSystem>().Play();
        print("colisionnn");

    }
}
