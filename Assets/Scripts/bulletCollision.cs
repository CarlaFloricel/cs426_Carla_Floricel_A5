using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class bulletCollision : NetworkBehaviour
{
        [SerializeField] ParticleSystem particleSystem;
    void OnCollisionEnter(Collision collision){
        
        
        if(collision.gameObject.tag == "GoldenEgg")
        if (!particleSystem.isPlaying){particleSystem.Play();}
                

        else NetworkServer.Destroy(gameObject);

    }

    


}
