using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingForward : MonoBehaviour
{
    [SerializeField] private float _movingSpeed;

    private void Update()
    {
        Vector3 nextPosition = transform.position;

        nextPosition.x += _movingSpeed * Time.deltaTime;
        transform.position = nextPosition;
    }
}
