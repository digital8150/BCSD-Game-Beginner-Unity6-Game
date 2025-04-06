using UnityEngine;

public class MyBall : MonoBehaviour
{

    Rigidbody rigid;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(Vector3.up * 5, ForceMode.Impulse);
        }

        Vector3 vec = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        rigid.AddForce(vec, ForceMode.Impulse);
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.name == "JumpArea")
        {
            rigid.AddForce(Vector3.up * 2, ForceMode.Impulse);
        }
    }
}
