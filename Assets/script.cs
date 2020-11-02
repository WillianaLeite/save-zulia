using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    public Transform tf;
    public Rigidbody2D rig;

    public float forceJump;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            //          Console.Write("PASSEI AQUI2");
             tf.position = new Vector3(tf.position.x + 0.1f, tf.position.y, tf.position.z);
            //tf.position = new Vector3(10, -5, 0);
            // Console.Write("PASSEI AQUI1");
        }
        if (Input.GetKey(KeyCode.A))
        {
            tf.position = new Vector3(tf.position.x - 0.1f, tf.position.y, tf.position.z);
        }
        if (Input.GetKey(KeyCode.W))
        {
            rig.AddForce(Vector3.up * forceJump);
        }

    }
}
