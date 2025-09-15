using UnityEngine;
 
public class PlayerCtrl : MonoBehaviour
 {
 
	public float movSpeed;
 	float speedX, speedY;
 	Rigidbody2D rb;
 	void Start()
 	{
     	rb = GetComponent<Rigidbody2D>();
 
	}
 
	void Update()
 	{
 
    	speedX = Input.GetAxisRaw("Horizontal") * movSpeed;
     	speedY = Input.GetAxisRaw("Vertical") * movSpeed;
     	rb.linearVelocity = new Vector2 (speedX, speedY);

 	}
 }

