using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    [SerializeField] int speed = 20;
    [SerializeField] int turnSpeed = 10;
    [SerializeField] String playerId = "1";

    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxis("Vertical" + playerId) * Time.deltaTime * speed;
        horizontal = Input.GetAxis("Horizontal" + playerId) * Time.deltaTime * turnSpeed;

        transform.Translate(new Vector3(0, 0, vertical));
        transform.Rotate(new Vector3(0, horizontal, 0));
    }
}
