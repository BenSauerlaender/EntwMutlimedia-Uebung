using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform root;
    [SerializeField] private Transform spieler;
    [SerializeField] private Transform coinPrefab;
    [SerializeField] private int coinAnzahl;
    [SerializeField] private Transform gegnerPrefab;
    [SerializeField] private int gegnerAnzahl;
    [SerializeField] private Transform wiese;
    [SerializeField] private float offsetY;

    

    // Start is called before the first frame update
    public void spawn(){
        for(int i = 0; i < coinAnzahl; i++){

            float x = UnityEngine.Random.Range(wiese.localPosition.x - wiese.localScale.x / 2, wiese.localPosition.x + wiese.localScale.x / 2);
            Debug.Log(wiese.localPosition.x);
            Debug.Log(wiese.localScale.x);
            float y = wiese.position.y + wiese.localScale.y / 2 + offsetY*wiese.localScale.y;
            float z = UnityEngine.Random.Range(wiese.localPosition.z - wiese.localScale.z / 2, wiese.localPosition.z + wiese.localScale.z / 2);
            Vector3 position = new Vector3(x,y,z);
            Transform coin = Instantiate(coinPrefab, new Vector3(0,0,0), Quaternion.identity,root);
            coin.transform.localPosition = position;
        }

        for(int i = 0; i < gegnerAnzahl; i++){

            float x = UnityEngine.Random.Range(wiese.localPosition.x - wiese.localScale.x / 2, wiese.localPosition.x + wiese.localScale.x / 2);
            float y = wiese.position.y + wiese.localScale.y / 2 + offsetY*wiese.localScale.y;
            float z = UnityEngine.Random.Range(wiese.localPosition.z - wiese.localScale.z / 2, wiese.localPosition.z + wiese.localScale.z / 2);
            Vector3 position = new Vector3(x,y,z);
            Transform gegner = Instantiate(coinPrefab, new Vector3(0,0,0), Quaternion.identity,root);
            gegner.SetPositionAndRotation(position,Quaternion.identity);
            gegner.transform.localPosition = position;

        }
        
    }

    // Update is called once per frame
    void Update(){
        
    }
}
