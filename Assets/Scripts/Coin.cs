using System.Collections;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private float moveSpeed = 3f;
    private int direction = 1;

    void Start()
    {
        //move left or right
        direction = Random.Range(0, 2) == 0 ? 1 : -1;

        Destroy(gameObject, 5f);
    }

    void Update()
    {
        //move down
        transform.Translate(Vector3.right * direction * moveSpeed * Time.deltaTime);

        if (transform.position.x > 9f || transform.position.x < -9f)
            direction *= -1;
    }
}