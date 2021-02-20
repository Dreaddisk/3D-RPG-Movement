using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{

    #region Variables
    [SerializeField]
    private Transform target;

    #endregion

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position;
    }
}
