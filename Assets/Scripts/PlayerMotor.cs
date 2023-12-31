using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
  private CharacterController controller;
  private Vector3 playerVelocity;
  public float speed = 6f;


  // Start is called before the first frame update
  void Start()
  {
    controller = GetComponent<CharacterController>();
  }

  // Update is called once per frame
  void Update()
  {

  }

  public void ProcessMove(Vector3 input)
  {
    Vector3 moveDirection = Vector3.zero;
    moveDirection.x = input.x;
    moveDirection.z = input.y;
    controller.Move(transform.TransformDirection(moveDirection) * speed * Time.deltaTime);
  }
}
