using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meshrenderer : MonoBehaviour
{
    public Renderer rend;  // variable for renderer
    public Color [] colors; // colors variable array
    public float speed;
    public Transform pointA, pointB;
    public float radius;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>(); // calls the mesh renderer
        // transform.position = Vector3.down; //game object model position x,y,z
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.back * speed * Time.deltaTime); // game object movement  
        //transform.position = Vector3.Lerp(pointA.position,pointB.position, speed * Time.time); // makes the game object moves from point a to b
        //transform.position = Vector3.MoveTowards(transform.position, pointA.position, speed * Time.deltaTime); // makes the game object moves towards a specific position
        if (true)
        {
            float dist = Vector3.Distance(transform.position, pointA.position);// distance between player and point a
            Gizmos.DrawWireSphere(transform.position, radius);
        }
        else 
        {
            Debug.Log(dist + "enemy has entered");
        }
       
    
    }

    private void OnEnable()
    {
        // rend.material.color = colors[Random.Range(0,colors.Length)]; // selects the number of range based on how many colors are presents in the lists
    }

    private void OnDisable()
    {
        
    }

    private void OnMouseDown()
    {
        // rend.material.color = colors[Random.Range(0, colors.Length)]; // selects the number of range based on how many colors are presents in the lists
    }

    private void OnMouseEnter()
    {
        // rend.material.color = colors[Random.Range(0, colors.Length)]; // selects the number of range based on how many colors are presents in the lists
    }

    private void OnMouseExit()
    {
        // rend.material.color = colors[Random.Range(0, colors.Length)]; // selects the number of range based on how many colors are presents in the lists
    }

    private void OnMouseUp()
    {
        // rend.material.color = colors[Random.Range(0, colors.Length)]; //selects the number of range based on how many colors are presents in the lists
    }

    private void OnMouseDrag()
    {
        rend.material.color = colors[Random.Range(0, colors.Length)]; //selects the number of range based on how many colors are presents in the lists
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
    }

}
