using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Range(0,10)][SerializeField][Tooltip("Oh shit a rat")]public float speed = 5;
        

        [SerializeField] AudioSource audioSource;
    

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = Vector3.zero;

        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");


        transform.position += direction * speed * Time.deltaTime ;

        // transform.rotation *= Quaternion.Euler(5, 0, 0);
        // transform.localScale = new Vector3(2, 2, 2);

        /*
        if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.rotation *= Quaternion.Euler(5, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            transform.rotation *= Quaternion.Euler(-5, 0, 0);
        }
        */

       
         if (Input.GetButtonDown("Fire1"))
        {
           audioSource.Play();

           GetComponent<Renderer>().material.color = Color.green;
        }

        GameObject go = GameObject.Find("Sphere");
        if (go)
        {
            go.GetComponent<Renderer>().material.color = Color.cyan;
        }
        
    }
}
