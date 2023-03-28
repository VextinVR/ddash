using UnityEngine;
using UnityEngine.AI;

public class AIFollowScript : MonoBehaviour
{
    // The NavMeshAgent component attached to this game object
    public NavMeshAgent agent;

    // The target GameObject that this AI will follow
    private GameObject target;

    public string tagString;

    void Start()
    {
        // Get the NavMeshAgent component attached to this game object
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        // Find all GameObjects with the tag "Player"
        GameObject[] players = GameObject.FindGameObjectsWithTag(tagString);

        // Set the target to the closest player
        if (players.Length > 0)
        {
            float minDistance = float.MaxValue;
            foreach (GameObject player in players)
            {
                float distance = Vector3.Distance(transform.position, player.transform.position);
                if (distance < minDistance)
                {
                    minDistance = distance;
                    target = player;
                }
            }
        }

        // If we have a target, set the NavMeshAgent's destination to the target's position
        if (target != null)
        {
            agent.destination = target.transform.position;
        }
    }
}
   