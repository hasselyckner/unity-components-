using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public SpriteRenderer rend;
    public Color color;
    public float leftTurn;
    public float rightTurn;
    public float forward;
    public float reverse;
    public float movespeed;
    public TrailRenderer trailRend; 

    


    // Use this for initialization
    void Start()
    {
        rend.color = color;
        rend.color = new Color(0.2f, 0.25f, 0.33f);



        //transform.position = new Vector3(-5f, transform.position.y);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 0, leftTurn * Time.deltaTime);  
        }
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0, rightTurn * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(movespeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-movespeed * Time.deltaTime, 0, 0);
            rend.color = new Color(1, 0, 0);
            trailRend.endColor = new Color(1, 0, 1);
            trailRend.startColor = new Color(1, 0.5f, 0);
            
        }

        //transform.Rotate(0, 0, 180f * Time.deltaTime);
        //transform.Translate(-2f * Time.deltaTime, 0, 0, Space.World); 

    }
}
