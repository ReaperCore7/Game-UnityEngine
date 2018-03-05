using UnityEngine;
using System.Collections;

public class Reapr_ : MonoBehaviour
{

    public string logtext = "Dark Guardian";
    public float speed = 2;
    public float health = 100;

    // Use this for initialization
    void Start()
    {
        Debug.Log(logtext);
        //ApplyDamage(5);	
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        float horizontal = Input.GetAxis("horizontal");
        Vector2 velocity = rigidbody.velocity;
        velocity.x = horizontal * speed;
        rigidbody.velocity = velocity;
    }

    public void ApplyDamage(float damagetodeal)
    {
        health = health - damagetodeal;
    }

}
