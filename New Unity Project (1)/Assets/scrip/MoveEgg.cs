using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEgg : MonoBehaviour
{
    // Start is called before the first frame update
    private float obstacleSpeed;
    public GameObject Egg;
     CubeMove cubeMove;
    void Start()
    {
        Egg = GameObject.Find("Cube");
        cubeMove = Egg.GetComponent<CubeMove>();
    }

    // Update is called once per frame
    void Update()
    {

       // float PosY = transform.position.Y;
       // if (PosY < -1)
       // {
          //  Destroy(gameObject);
       // }

        obstacleSpeed = cubeMove.speed;
        transform.Translate(Vector3.down * Time.deltaTime * obstacleSpeed);
    }
}
