using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
  public float speed;

  private Vector2 moveVelocity;
  private Rigidbody2D rb;

  void Start(){
      rb = GetComponent<Rigidbody2D>();

  }
  void Update() {

      Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
      moveVelocity = moveInput * speed;
  }

 void FixedUpdate(){

      rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);

  }
}
