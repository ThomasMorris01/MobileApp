using UnityEngine;

public class PointSystem : MonoBehaviour
{


    void OnTriggerEnter(Collider collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "Player")
        {
            ScoreScript.scoreValue += 10;
            Destroy(gameObject);
        }

    }

}
