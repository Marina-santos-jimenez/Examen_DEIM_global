using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    private float moveSpeed = 3f;
    private bool inMarginMoveX = true;
    private bool inMarginMoveY = true;
    [SerializeField] Text TextDistance;
    void Start()
    {
        speed = 3f;
        StartCoroutine("Distancia");
    }

    // Update is called once per frame
    void Update()
    {
        MoverCube();
    }
    IEnumerator Distancia()
    {
        //Bucle infinito que suma 10 en cada ciclo
        //El segundo parámetro está vacío, por eso es infinito
        for (int n = 0; ; n++)
        {
            //Cambio el texto que aparece en pantalla
            TextDistance.text = "Velocidad: " + n * speed;

            //Cada ciclo aumenta la velocidad
            if (speed < 30)
            {
                speed = speed + 0.2f;
            }

            //Ejecuto cada ciclo esperando 1 segundo
            yield return new WaitForSeconds(0.25f);
        }
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
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Obstacle")
        {
            Destroy(other.gameObject);
            speed = 0;

        }
    }
}
