using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainCamera : MonoBehaviour
{
    public GameObject focusObject;
    private Vector3 distance;
    private Vector3 target = new Vector3(5.0f, 0.0f, 0.0f);

    // Start is called before the first frame update
    void Start()
    {
        distance = transform.position - focusObject.transform.position;    
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = distance + focusObject.transform.position;

        // Spin the object around the world origin at 20 degrees/second.
        //transform.RotateAround(target, Vector3.up, 30 * Time.deltaTime);

        // Target focused object anytime
        //transform.LookAt(focusObject.transform);
    }
}

// public class mainCamera : MonoBehaviour {

//     [SerializeField]
//     private Transform target;

//     [SerializeField]
//     private Vector3 offsetPosition;

//     [SerializeField]
//     private Space offsetPositionSpace = Space.Self;

//     [SerializeField]
//     private bool lookAt = true;

//     private void LateUpdate()
//     {
//         Refresh();
//     }

//     public void Refresh()
//     {
//         if (target == null)
//         {
//             Debug.LogWarning("Missing target ref !", this);

//             return;
//         }

//         // compute position
//         if (offsetPositionSpace == Space.Self)
//         {
//             transform.position = target.TransformPoint(offsetPosition);
//         }
//         else
//         {
//             transform.position = target.position + offsetPosition;
//         }

//         // compute rotation
//         if (lookAt)
//         {
//             transform.LookAt(target);
//         }
//         else
//         {
//             transform.rotation = target.rotation;
//         }
//     }
// }