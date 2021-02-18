using UnityEngine.AI;
using UnityEngine;

public class Mover : MonoBehaviour
{
    #region Variables
    [SerializeField]
    private Transform target;


    
    #endregion



    // Update is called once per frame
    void Update()
    {
        GetComponent<NavMeshAgent>().destination = target.position;
    }




} // Mover class
