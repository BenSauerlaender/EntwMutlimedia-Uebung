using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spieler : MonoBehaviour
{

    private float angle = 0;

    private int coins = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveVertical = Input.GetAxis("Vertical") * Time.deltaTime;
        angle += Input.GetAxis("Horizontal") * Time.deltaTime * 50;
        if (angle >= 360) angle -= 360;
        if (angle < 0) angle += 360;
        Vector3 direction = new Vector3(Mathf.Sin(Mathf.Deg2Rad*angle), 0, Mathf.Cos(Mathf.Deg2Rad * angle));
        transform.rotation = Quaternion.LookRotation(direction);
        //transform.Translate(direction* moveVertical,transform);
        transform.position += direction * moveVertical;
    }

    void OnTriggerEnter(Collider other){
        if(other.CompareTag("Coin")){
            Destroy(other.gameObject);
            coins++;
            Debug.Log("Yeah!!! Add 1 Coin to your wallet!");
            Debug.Log("Wallet: " + coins + " Coins.");
        }
    }
}
