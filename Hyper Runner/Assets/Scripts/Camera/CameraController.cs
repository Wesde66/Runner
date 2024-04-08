using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Vector3 initPostion;
    [SerializeField] private Vector3 maxPostion;
    [SerializeField] [Range(0,1)]private float progress;
   
   
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.localPosition = Vector3.Lerp(initPostion, maxPostion, progress);
    }
}
