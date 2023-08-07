using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMov : MonoBehaviour
{

    [SerializeField] Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 initialPos = transform.position;
        Vector3 finalPos = new Vector3(player.position.x, player.position.y, transform.position.z);
        transform.position = Vector3.Slerp(initialPos, finalPos, 0.01f);
        
    }
}
