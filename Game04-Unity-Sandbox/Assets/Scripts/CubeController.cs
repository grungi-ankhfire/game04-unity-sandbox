using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{

    private Animator anim;

    void Start() {
        anim = GetComponentInChildren<Animator>();
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            anim.SetBool("startMoving", true);
        }
    }
}
