using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatforms : MonoBehaviour
{
    public Transform[] platformPosition = new Transform[3];
    int direction = 1;
    public float speed;
    Vector2 target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        target = currentMovementTarget();


        //need to set our distance and chance direction

        float distance = (target - (Vector2)platformPosition[0].position).magnitude;

        if (distance <= 0.5f)
        {
            direction *= -1;
        }
    }
    private void FixedUpdate()
    {
        platformPosition[0].position = Vector2.Lerp(platformPosition[0].position, target, speed * Time.deltaTime);
    }
    Vector2 currentMovementTarget()
    {
        if (direction == 1)
        {
            return platformPosition[1].position;
        }
        else
        {
            return platformPosition[2].position;
        }
    }

}
