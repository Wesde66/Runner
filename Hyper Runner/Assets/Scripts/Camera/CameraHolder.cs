using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHolder : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    private Vector3 initRotation;
    // Start is called before the first frame update
    void Start()
    {
        initRotation = transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerTransform.position;

        transform.eulerAngles = new Vector3(playerTransform.eulerAngles.x + initRotation.x, playerTransform.eulerAngles.y + initRotation.y, 0);
    }
}
