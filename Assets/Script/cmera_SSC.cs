using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cmera_SSC : MonoBehaviour
{
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float keyHorizontal = Input.GetAxis("Horizontal");


        transform.Translate(new Vector3(keyHorizontal, 0, 0)
            * speed * Time.deltaTime, Space.World);

    }
}
