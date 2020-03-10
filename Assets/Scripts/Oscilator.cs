using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscilator : MonoBehaviour
{

    [SerializeField] Vector3 movementVector;
    [Range(0,1)][SerializeField] float movementFactor;
    [SerializeField] Vector3 startingPos;
    [SerializeField] float period = 8f;
    // Start is called before the first frame update
    void Start()
    {
        startingPos=transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        float cycles = Time.time / period;
        const float tau = Mathf.PI * 2;
        float rawSinWave = Mathf.Sin(cycles * tau);
        movementFactor = rawSinWave /2f + 0.5f;
        Vector3 offset = movementVector * movementFactor;
        transform.position = startingPos + offset;   
    }
}
