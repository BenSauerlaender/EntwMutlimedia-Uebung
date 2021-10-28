using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gegner : MonoBehaviour
{

    [SerializeField] private Transform target;
    [SerializeField] private float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void setTarget(Transform tar){
        this.target = tar;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(target != null){
            Vector3 direction = target.position - transform.position;
            direction.Normalize();
            transform.position += direction * Time.deltaTime * speed;
            transform.forward = -direction;
        }
        
    }
}
