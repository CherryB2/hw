using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_SC : MonoBehaviour
{
    float x_pos=0f, y_pos=0f;
    private float moving_speed = 10f;
    private float rot_speed = 15f;


    public GameObject obj;
    void Start()
    {
        Debug.Log("i'm player");
    }

   
    void Update()
    {
        float keyHorizontal = Input.GetAxis("Horizontal");
        float keyVertical = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(keyHorizontal, keyVertical, 0) 
            *this.moving_speed * Time.deltaTime, Space.World);

        Shoot();

        Rotation();
    }

    void Rotation()
    {

        //keybord input
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");



        h = h * this.rot_speed * Time.deltaTime;
        v = v * this.rot_speed * Time.deltaTime;


        transform.Rotate(Vector3.back * h);
        transform.Rotate(Vector3.right * v);

      
    }


    void Shoot()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("space pressed");
            Instantiate(obj, new Vector3(transform.position.x, 
                transform.position.y, transform.position.z), Quaternion.identity);

        }

    }
}
