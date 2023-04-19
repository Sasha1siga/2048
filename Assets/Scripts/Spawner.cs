using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float _sencentivivty = 25f;
    [SerializeField] private float _maxXPosition = 2.5f;

    private float _xPosition;
    private float _oldWorldX;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _oldWorldX = GetWorldPoint().x;
        }
        if (Input.GetMouseButton(0))
        {
            float currentX = GetWorldPoint().x;
            float delta = currentX - _oldWorldX;
            _oldWorldX = currentX;
            _xPosition += delta;// * _sencentivivty / Screen.width;
            _xPosition = Mathf.Clamp(_xPosition, -_maxXPosition, _maxXPosition);
            transform.position = new Vector3(_xPosition, transform.position.y, transform.position.z);
        }
    }
    private Vector3 GetWorldPoint()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Plane plane = new Plane(Vector3.forward, Vector3.zero);
        float distance;
        plane.Raycast(ray, out distance);
        Vector3 point = ray.GetPoint(distance);
        return point;
    }
}
