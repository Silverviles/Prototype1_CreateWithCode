using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    [SerializeField] int cameraXOffset = 25;
    [SerializeField] int cameraYOffset = 5;
    public GameObject plane;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset.x = plane.transform.position.x + cameraXOffset;
    }

    // Update is called once per frame
    void Update()
    {
        offset.y = cameraYOffset;
        transform.position = plane.transform.position + offset;
    }
}
