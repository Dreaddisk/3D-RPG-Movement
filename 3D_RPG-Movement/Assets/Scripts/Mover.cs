using UnityEngine.AI;
using UnityEngine;

public class Mover : MonoBehaviour
{
    #region Variables
    [SerializeField]
    private Transform target;


    
    #endregion

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            MoveToCursor();
        }

        UpdateAnimator();
    }


    private void MoveToCursor()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        bool hasHit = Physics.Raycast(ray, out hit);



        if(hasHit == true)
        {
            GetComponent<NavMeshAgent>().destination = hit.point;
            Debug.DrawRay(ray.origin, ray.direction * 100, Color.magenta);
        }
    }

    private void UpdateAnimator()
    {
        Vector3 velocity = GetComponent<NavMeshAgent>().velocity;
        Vector3 localVelocity = transform.InverseTransformDirection(velocity);

        float speed = localVelocity.z;
        GetComponent<Animator>().SetFloat("ForwardSpeed", speed);
    }

} // Mover class
