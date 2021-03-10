using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    private float moveSpeed = 3f;
    private bool inMarginMoveX = true;
    private bool inMarginMoveY = true;
    void Start()
    {
        speed = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        MoverCube();
    }
    void MoverCube()
    {
        float posX = transform.position.x;
        float posZ = transform.position.z;
        float desplZ = Input.GetAxis("Vertical");
        float desplX = Input.GetAxis("Horizontal");

        if (posX < 20f && posX > -20f || posX < -20f && desplX > 0 || posX > 20f && desplX < 0)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed * desplX);
        }

        if (posZ < 20f && posZ > -20f || posZ < -20f && desplZ > 0 || posZ > 20f && desplZ < 0)
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed * desplZ);
        }
        
    }
}
