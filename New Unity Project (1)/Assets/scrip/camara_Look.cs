using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara_Look : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Transform playerPosition;
    [SerializeField] float smoothVelocity = 0.1f;
    [SerializeField] Vector3 camaraVelocity = Vector3.zero;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(playerPosition);
        Vector3 targetPosition = new Vector3(playerPosition.position.x, playerPosition.position.y +6, playerPosition.position.z +7);
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref camaraVelocity, smoothVelocity);
    }
}
