using UnityEngine;

public class AiShell : MonoBehaviour
{
    public GameObject explosion;
    Rigidbody rb;
    
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "tank")
        {
            GameObject exp = Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(exp, 0.5f);
            Destroy(this.gameObject);
        }    
    }
    
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }
    
    private void Update()
    {
        transform.forward = rb.linearVelocity;
    }
}