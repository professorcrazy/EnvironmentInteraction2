using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTriggerEvent : MonoBehaviour
{
    [SerializeField] private Color targetNewColor = Color.cyan;
    public GameObject target;

    int count = 0;
    [SerializeField] int triggerCount = 3;

    [SerializeField] GameObject explosion;

    private void OnTriggerEnter(Collider other) {
        count++;
        if (count % triggerCount == 0 ) {
            target.GetComponent<Renderer>().material.color = new Color(
                                                       Random.Range(0f, 1f),
                                                       Random.Range(0f, 1f),
                                                       Random.Range(0f, 1f));
        }
        GameObject tempExplosion = Instantiate(explosion, target.transform.position, 
                                         target.transform.rotation);
        Destroy(tempExplosion, 2f);
    }
    
}
