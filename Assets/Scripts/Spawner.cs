using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform coinPrefab;
    public Transform wiese;
    public float offsetY;

    public int anzahl;

    // Start is called before the first frame update
    void Start(){
        for(int i = 0; i < anzahl; i++){

            float x = UnityEngine.Random.Range(wiese.position.x - wiese.localScale.x / 2, wiese.position.x + wiese.localScale.x / 2);
            float y = wiese.position.y + wiese.localScale.y / 2 + offsetY;
            float z = UnityEngine.Random.Range(wiese.position.z - wiese.localScale.z / 2, wiese.position.z + wiese.localScale.z / 2);
            Vector3 position = new Vector3(x,y,z);
            Instantiate(coinPrefab, position, Quaternion.identity);
        }
        
    }

    // Update is called once per frame
    void Update(){
        
    }
}
