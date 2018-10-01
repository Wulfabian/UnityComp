using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public SpriteRenderer rend;
    public TrailRenderer trailRend;
    public Color color;

    public float moveSpeed = 2f;
    public float rotationSpeed = 360f;

    // Use this for initialization
    void Start()
    {
        rend.color = color;
        //rend.color = new Color(0, 2f, 0.25f);

        //transform.position = 
        //    new Vector3(-5f, transform.position.y);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(-moveSpeed * Time.deltaTime, 0, 0, Space.Self);
            rend.color = Color.green; // new Color(0, 1, 0);
            trailRend.endColor = Color.red; // new Color(1, 0, 0);
            trailRend.startColor = Color.green; // new COlor (0, 1, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate((moveSpeed / 2) * Time.deltaTime, 0, 0, Space.Self);
            rend.color = Color.red; //new Color(1, 0, 0);
            trailRend.endColor = Color.green; // new Color(0, 1, 0);
            trailRend.startColor = Color.red; //new Color(1, 0, 0);
        }
        if (Input.GetKey(KeyCode.Space) && Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate((-moveSpeed * 2) * Time.deltaTime, 0, 0, Space.Self);
        }



    }
}
