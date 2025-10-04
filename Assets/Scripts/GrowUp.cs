using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowUp : MonoBehaviour
{
    [SerializeField] private float _growSpeed;

    private void Update()
    {
        Vector3 newScale = transform.localScale;
        float newScaleValue = _growSpeed * Time.deltaTime;
        
        newScale.x += newScaleValue;
        newScale.y += newScaleValue;
        newScale.z += newScaleValue;

        transform.localScale = newScale;
    }
}