using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grow : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        Vector3 newScale = transform.localScale;
        float newScaleValue = _speed * Time.deltaTime;
        
        newScale.x += newScaleValue;
        newScale.y += newScaleValue;
        newScale.z += newScaleValue;

        transform.localScale = newScale;
    }
}