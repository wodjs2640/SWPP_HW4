using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Animator animator;

    public int animationInt;
    public GameObject[] enemy;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetInteger("Animation_int", animationInt);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameStart.instance.isPlaying)
            transform.LookAt(enemy[0].transform);
    }
}
