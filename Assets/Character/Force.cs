/*using UnityEngine;
using System.Collections;


public class Force : MonoBehaviour {
	private Rigidbody _rigidbody;
	private void Awake() {
		_rigidbody = GetComponent<Rigidbody>();
	}
	void Update () 
	{
		if (Input.GetKey(KeyCode.A))
		{
			_rigidbody.AddForce(-10,0f,0f);
		}
		if (Input.GetKey(KeyCode.D))
		{
			_rigidbody.AddForce(10,0f,0f);
		}
	}
}*/

using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class Force : MonoBehaviour
{
    public float Speed = 5f;
    private Rigidbody _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    
    void FixedUpdate()
    {
        MovementLogic();
    }
    
    private void MovementLogic()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        transform.Translate(movement * Speed * Time.fixedDeltaTime);
    }
}