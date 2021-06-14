using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BezierSolution;

public class Teleporter : MonoBehaviour
{
    public BezierSpline path;
    private BezierWalkerWithSpeed walker;

    private void OnTriggerEnter(Collider other)
    {
        walker = other.transform.GetComponent<BezierWalkerWithSpeed>();
        walker.spline = path;
        walker.enabled = true;
    }

    public void EndSplineTravel()
    {
        walker.enabled = false;
        walker.NormalizedT = 0;
    }
}
