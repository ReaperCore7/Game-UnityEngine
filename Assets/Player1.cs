using UnityEngine;
using System.Collections;

public class Player1 : MonoBehaviour {

    public string logText = "Death to the Infadels";
    public float speed = 2;
    public float health = 100;

    void Start () {
       Debug.Log(logText);
        ApplyDamage(0);
	}
	
	
	void Update () {
        
        Rigidbody2D Rigidbody = GetComponent<Rigidbody2D>();

        Rigidbody.velocity = Vector2.right * speed;

    }
     public void ApplyDamage (float DealDamage)
    {
        health = health - DealDamage;
    }
}
