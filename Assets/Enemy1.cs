using UnityEngine;
using System.Collections;

public class Enemy1 : MonoBehaviour {

    public float Health = 100;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter2D(Collision2D collision)

    {
        Debug.Log("Bang!!!");
       
        Player1 Mario = collision.collider.GetComponent<Player1>();
        Mario.ApplyDamage(2);
    }
}
