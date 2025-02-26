using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{

    Vector2 inputVec;
    public float speed = 5;
    Rigidbody2D rigid;
    SpriteRenderer spriter;
    Animator anim;
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        spriter = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            anim.SetBool("Dash", true);
        }
        if(Input.GetKeyUp(KeyCode.Space)){
            anim.SetBool("Dash", false);
        }
            
    }
    void FixedUpdate() {
        Vector2 nextVec = inputVec.normalized * Time.fixedDeltaTime * speed;
        rigid.MovePosition(rigid.position + nextVec);

        anim.SetFloat("Vx", Math.Abs(inputVec.x));
        anim.SetFloat("Vy", inputVec.y);
        if(inputVec.x != 0){
            spriter.flipX = inputVec.x < 0;
        }

        if(inputVec.y == 0 && inputVec.x == 0){
            anim.SetBool("Run", false);
            anim.SetBool("Dash", false);
            anim.SetBool("Stop", true);
        }
        else{
            anim.SetBool("Stop", false);
            anim.SetBool("Run", true);
        }
    }

    void OnMove(InputValue value)
    {
        inputVec = value.Get<Vector2>();    
    }

    void LateUpdate() {
        
    }
}
