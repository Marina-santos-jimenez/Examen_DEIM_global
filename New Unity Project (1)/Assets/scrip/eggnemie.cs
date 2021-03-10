using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eggnemie : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject Columna;

    //Variable que tiene la posición del objeto de referencia
    [SerializeField] Transform InitPos;
    private CubeMove CubeMove;
    [SerializeField] GameObject Obstaculo;
    public int contador;
    private float randomNumberX;
    private float randomNumberZ;
    private float randomNumberY;
    Vector3 RandomPos;
    void Start()
    {
        StartCoroutine("ObstaculoCoroutine");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void GenerarObstaculo(float posZ = 0f)
    {
        randomNumberX = Random.Range(-20f, 20f);
        randomNumberZ = Random.Range(-20f, 20f);
        randomNumberY = Random.Range(0f, 20f);

        RandomPos = new Vector3(randomNumberX, randomNumberY, randomNumberZ);

        Vector3 FinalPos = InitPos.position + RandomPos;
        Instantiate(Columna, FinalPos, Quaternion.identity);
    }
    IEnumerator ObstaculoCoroutine()
    {
        for (contador = 1; contador <= 5; contador++)
        {
            GenerarObstaculo();
            yield return new WaitForSeconds(2);
        }
        for (contador = 6; contador <= 10 && contador > 5; contador++)
        {
            GenerarObstaculo();
            yield return new WaitForSeconds(1);
        }
        for (contador = 11; contador > 10; contador++)
        {
            GenerarObstaculo();
            yield return new WaitForSeconds(0.5f);
        }


    }
}
