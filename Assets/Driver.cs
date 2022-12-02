using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 160;
    [SerializeField] float moveSpeed = 20;



    void Start()
    {
       
        
    }

    
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        if (Input.GetKey(KeyCode.DownArrow)) {
           transform.Rotate(0,0,steerAmount);
        } else if (Input.GetKey(KeyCode.UpArrow)) {
            transform.Rotate(0,0,-steerAmount);
        }

        
        transform.Translate(0,moveAmount,0); 
    }
}
