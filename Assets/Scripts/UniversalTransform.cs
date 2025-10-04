using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniversalTransform : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _growSpeed;
    [SerializeField] private float _spinSpeed;

    private void Update()
    {
        Move();
        Grow();
        Spin();
    }

    private void Move()
    {
        transform.Translate(Vector3.right * _moveSpeed * Time.deltaTime);
    }

    private void Grow()
    {
        Vector3 newScale = transform.localScale;
        float newScaleValue = _growSpeed * Time.deltaTime;

        newScale.x += newScaleValue;
        newScale.y += newScaleValue;
        newScale.z += newScaleValue;

        transform.localScale = newScale;
    }

    private void Spin()
    {
        transform.Rotate(Vector3.up * _spinSpeed * Time.deltaTime);
    }
}