using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_SC : MonoBehaviour
{
    private float z_pos;

    Rigidbody rigi;

    // Start is called before the first frame update
    void Start()
    {
        z_pos = 0.0f;
        rigi = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        z_pos += 0.01f;
        // transform.Translate(0.0f, 0.0f, z_pos * Time.deltaTime);

        //Debug.Log(z_pos);
        rigi.AddForce(new Vector3(0, 0, z_pos), ForceMode.Impulse);
        if (z_pos > 120.0f)
        {
            // Kills the game object in 0 seconds 
            Destroy(gameObject, 0);

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Finish"))

        {
            Destroy(gameObject, 0);
        }
    }
}
