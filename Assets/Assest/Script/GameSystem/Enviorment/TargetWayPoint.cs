using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetWayPoint : MonoBehaviour
{
    public Transform player;
    public Transform target;
    public float rotationSpeed = 360f;

    void Update()
    {
        if (player != null && target != null)
        {

            Vector3 direction = target.position - player.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

            float currentRotation = transform.rotation.eulerAngles.z;
            float targetRotation = angle;

            float newRotation = Mathf.MoveTowardsAngle(currentRotation, targetRotation, rotationSpeed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(0, 0, newRotation);

            Vector3 playerPosition = player.position;
            transform.position = new Vector3(playerPosition.x + 2 * Mathf.Cos(angle * Mathf.Deg2Rad), playerPosition.y + 2 * Mathf.Sin(angle * Mathf.Deg2Rad), transform.position.z);
        }
    }
}
