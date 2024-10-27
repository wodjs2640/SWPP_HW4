using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AnimalControl : MonoBehaviour
{
    public int hp;

    private float speed = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            GameStart.instance.isGameOver = true;
            GameStart.instance.gameOver.SetActive(true);
        }
    }
}
