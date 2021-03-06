using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spieler : MonoBehaviour
{

    [SerializeField] private float speed;

    [SerializeField] private bool godmode;
    private float angle = 0;

    private int coins = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        move(Input.GetAxis("Horizontal") * Time.deltaTime,Input.GetAxis("Vertical")* Time.deltaTime);
    }

    public void move(float moveHorizontal, float moveVertical){
        angle += moveHorizontal * 100;
        if (angle >= 360) angle -= 360;
        if (angle < 0) angle += 360;
        Vector3 direction = new Vector3(Mathf.Sin(Mathf.Deg2Rad*angle), 0, Mathf.Cos(Mathf.Deg2Rad * angle));
        transform.rotation = Quaternion.LookRotation(direction);
        transform.position += direction * moveVertical * speed;
    }

    void OnTriggerEnter(Collider other){
        if(other.CompareTag("Coin")){
            Destroy(other.gameObject);
            coins++;
            Debug.Log("Yeah!!! Add 1 Coin to your wallet!");
            Debug.Log("Wallet: " + coins + " Coins.");
        }

        if(other.CompareTag("Enemy") && !godmode){
            Destroy(other.gameObject);
            coins++;
            Debug.Log("Game over!");
            Destroy(this.gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
