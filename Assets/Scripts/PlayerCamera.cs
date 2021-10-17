using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player != null){
            transform.position = player.position + player.rotation*offset;
            transform.rotation = player.rotation;
            transform.Rotate(new Vector3(40,0,0));
        }
        
    }

    
}
