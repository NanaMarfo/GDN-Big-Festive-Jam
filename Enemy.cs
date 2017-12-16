using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform player;

    void Update()
    {
            RaycastHit playerinfo;
            if (Physics.Raycast(player.transform.position, player.transform.forward, out playerinfo))
            {
                GetComponent<UnityEngine.AI.NavMeshAgent>().SetDestination(player.transform.position);
                transform.eulerAngles = player.transform.position;
                Debug.Log(player.transform.position);
            }
            
    }


}