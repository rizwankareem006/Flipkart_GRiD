using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private CharacterController characterController;
    private CharacterAnimation playerAnimations;
    public float movementSpeed = 3f;
    public float gravity = 9.8f;
    // public float rotation = 0.15f;
    public float rotateDegreePerSecond = 180f;
    // Start is called before the first frame update
    void Awake()
    {
        characterController = GetComponent<CharacterController>();
        playerAnimations = GetComponent<CharacterAnimation>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Rotate();
        AnimateWalk();

    }

    void Move(){
        if(Input.GetAxis(Axis.VERTICAL_AXIS)>0){
            Vector3 moveDirection = transform.forward;
            moveDirection.y-=gravity*Time.deltaTime;
            characterController.Move(moveDirection*movementSpeed*Time.deltaTime);
        }
        else if(Input.GetAxis(Axis.VERTICAL_AXIS)<0){
            Vector3 moveDirection = -transform.forward;
            moveDirection.y-=gravity*Time.deltaTime;
            characterController.Move(moveDirection*movementSpeed*Time.deltaTime);
        }else{
            characterController.Move(Vector3.zero);
        }
    }
    void Rotate(){
        Vector3 rotation_Direction = Vector3.zero;
        if(Input.GetAxis(Axis.HORIZONTAL_AXIS)<0){
            rotation_Direction = transform.TransformDirection(Vector3.left);
        }
         if(Input.GetAxis(Axis.HORIZONTAL_AXIS)>0){
            rotation_Direction = transform.TransformDirection(Vector3.right);
        }
        if(rotation_Direction!=Vector3.zero)
        transform.rotation = Quaternion.RotateTowards(transform.rotation,Quaternion.LookRotation(rotation_Direction),
            rotateDegreePerSecond*Time.deltaTime);
    }
    void AnimateWalk(){
        if(characterController.velocity.sqrMagnitude!=0){
            playerAnimations.Walk(true);
        }else{
            playerAnimations.Walk(false);
        }
    }
}
