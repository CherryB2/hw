using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class pla_SC : MonoBehaviour
{
    public int speed;
    public GameObject obj;

    public int ballcount;

    public Text tt;
    void Start()
    {
        ballcount = 30;
    }

    // Update is called once per frame
    void Update()
    {
        float keyHorizontal = Input.GetAxis("Horizontal");
        

        transform.Translate(new Vector3(keyHorizontal, 0, 0)
            * speed * Time.deltaTime, Space.World);


        Shoot();
        tt.text = " "+ballcount;
    }


    void Shoot()
    {

        if (Input.GetKeyDown(KeyCode.Space) && ballcount >0)
        {
            Debug.Log("space pressed");
            Instantiate(obj, new Vector3(transform.position.x,
                transform.position.y, transform.position.z), Quaternion.identity);
            ballcount--;
        }

    }
}
