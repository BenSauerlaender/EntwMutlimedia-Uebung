using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform spieler;
    [SerializeField] private Transform coinPrefab;
    [SerializeField] private int coinAnzahl;
    [SerializeField] private Transform gegnerPrefab;
    [SerializeField] private int gegnerAnzahl;
    [SerializeField] private Transform wiese;
    [SerializeField] private float offsetY;

    

    // Start is called before the first frame update
    void Start(){
        for(int i = 0; i < coinAnzahl; i++){

            float x = UnityEngine.Random.Range(wiese.position.x - wiese.localScale.x / 2, wiese.position.x + wiese.localScale.x / 2);
            float y = wiese.position.y + wiese.localScale.y / 2 + offsetY;
            float z = UnityEngine.Random.Range(wiese.position.z - wiese.localScale.z / 2, wiese.position.z + wiese.localScale.z / 2);
            Vector3 position = new Vector3(x,y,z);
            Instantiate(coinPrefab, position, Quaternion.identity);
        }

        for(int i = 0; i < gegnerAnzahl; i++){

            float x = UnityEngine.Random.Range(wiese.position.x - wiese.localScale.x / 2, wiese.position.x + wiese.localScale.x / 2);
            float y = wiese.position.y + wiese.localScale.y / 2 + offsetY;
            float z = UnityEngine.Random.Range(wiese.position.z - wiese.localScale.z / 2, wiese.position.z + wiese.localScale.z / 2);
            Vector3 position = new Vector3(x,y,z);
            Transform gegner = Instantiate(gegnerPrefab, position, Quaternion.identity);
            gegner.GetComponent<Gegner>().setTarget(spieler);
        }
        
    }

    // Update is called once per frame
    void Update(){
        
    }
}
