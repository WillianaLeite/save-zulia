using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;

public class rato1 : MonoBehaviour
{
    public Transform tf;
    public Rigidbody2D rig;

    public float forceJump;
    List<Transform> all_positions;

    public Transform target;
    public float smoothTime = 0.05F;
    private Vector3 velocity = Vector3.zero;

    public Transform lixo1;
    public Transform lixo2;
    public Transform lixo3;
    public Transform lixo4;

    // Start is called before the first frame update

    void left()
    {
        tf.position = new Vector3(tf.position.x, tf.position.y - 0.1f, tf.position.z);
    }

    void jumpLeft()
    {
        rig.AddForce(Vector3.down * 10.0f);
    }

    void rigth()
    {
        tf.position = new Vector3(tf.position.x, tf.position.y + 0.1f, tf.position.z);
    }

    void jumpRigth()
    {
        rig.AddForce(Vector3.up * 10.0f);
    }

    void runFront()
    {
        tf.position = new Vector3(tf.position.x - 0.5f, tf.position.y, tf.position.z);
    }

    void getPosAlvo()
    {
        all_positions = new List<Transform>();

        all_positions.Add(lixo1);
        all_positions.Add(lixo2);
        all_positions.Add(lixo3);
        all_positions.Add(lixo4);//Talvez tenha que dá o new aqui 

        System.Random rnd = new System.Random();

        int num_lixo = rnd.Next(0, 4);

        target = all_positions[num_lixo];

    }


    void Start()
    {
        /*
        int x = 1;
        while (x < 100)
        {
            try
            {
                runFront();
            }
            catch
            {
                break;
            }
            x = x + 1;    
        }

        */
        getPosAlvo();
        //target.position = new Vector3(-14.01f, -11.51f, 0.0f);
        // Define a target position above and behind the target transform
        Vector3 targetPosition = target.TransformPoint(new Vector3(0, 5, -10));

        // Smoothly move the camera towards that target position
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
        tf.position = target.position;

        
    }


    // Update is called once per frame
    void Update()
    {
            

    }
}
