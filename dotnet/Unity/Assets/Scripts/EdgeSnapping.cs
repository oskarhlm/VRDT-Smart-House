using Assets.Scripts.Utils;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class EdgeSnapping : MonoBehaviour
{
    public float SnapDistance = 1;

    [SerializeField] private Collider _targetCollider;
    [SerializeField] private bool _hasSnapped = false;
    [SerializeField] private Transform _rootObject;

    private Collider _myCollider;
    private XRGrabInteractable _grabInteractable;
    private Vector3 _myClosestPoint;
    private Vector3 _targetClosestPoint;
    private Vector3 _offset;

    private void Start()
    {
        _myCollider = GetComponent<BoxCollider>();
        _grabInteractable = _rootObject.GetComponent<XRGrabInteractable>();
    }

    private void FixedUpdate()
    {
        _myClosestPoint = _myCollider.ClosestPoint(_targetCollider.transform.position);
        var closestTarget = GameObject.FindGameObjectsWithTag("Snappable").MinBy(obj =>
        {
            var closestPoint = obj.GetComponent<BoxCollider>().ClosestPointOnBounds(_myClosestPoint);
            return closestPoint - _myClosestPoint;
        });
        _targetCollider = closestTarget.GetComponent<BoxCollider>();
        _targetClosestPoint = _targetCollider.ClosestPoint(_myClosestPoint);
        _offset = _targetClosestPoint - _myClosestPoint;

        //_targetClosestPoint = _targetCollider.ClosestPoint(_myClosestPoint);
        //_offset = _targetClosestPoint - _myClosestPoint;

        if (_offset.magnitude < SnapDistance)
        {
            _rootObject.transform.eulerAngles = _targetCollider.transform.eulerAngles;
            _grabInteractable.trackRotation = false;
        }
        else
        {
            _grabInteractable.trackRotation = true;
        }
    }

    public void SnapToPlane()
    {
        Debug.Log(_offset.magnitude);
        if (_offset.magnitude < SnapDistance)
        {
            _rootObject.transform.eulerAngles = _targetCollider.transform.eulerAngles;
            _myClosestPoint = _myCollider.ClosestPoint(_targetCollider.transform.position);
            _targetClosestPoint = _targetCollider.ClosestPoint(_myClosestPoint);
            _offset = _targetClosestPoint - _myClosestPoint;
            Debug.Log(_offset);
            _rootObject.transform.position += _offset;
        }
    }
}
