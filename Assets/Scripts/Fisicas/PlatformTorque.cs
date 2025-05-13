using UnityEngine;

public class PlatformTorque : MonoBehaviour
{
    public float torqueAmount = 100f;  
    private Rigidbody2D rbPlatform; 

    void Start()
    {
     
        rbPlatform = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.rigidbody != null)
        {
            
            float characterMass = collision.rigidbody.mass;

           
            float finalTorque = torqueAmount * characterMass;

           
            Vector2 contactPoint = collision.GetContact(0).point;
           
            float direction = Mathf.Sign(contactPoint.x - transform.position.x);

            
            rbPlatform.AddTorque(-direction * finalTorque);
        }
    }
}

