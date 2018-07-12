using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class CurveRenderer : MonoBehaviour
{
    [SerializeField] private CurveObject _curveObject;

    [SerializeField] private float _width = 10;
    [SerializeField] private float _height = 10;
    [SerializeField] private float _sampleStep = 0.1f;

    private LineRenderer _lineRenderer;

    // Use this for initialization
    void Start()
    {
        _lineRenderer = GetComponent<LineRenderer>();


        RenderCurve();
    }

    private void RenderCurve()
    {
        var numOfSteps = (int) (1 / _sampleStep) + 1;

        _lineRenderer.positionCount = numOfSteps;

        for (int i = 0; i < numOfSteps; i++)
        {
            var sampleValue = _curveObject.Curve.Evaluate(((float) i) * _sampleStep);

            _lineRenderer.SetPosition(i, new Vector3((i / (float)numOfSteps) * _width, sampleValue * _height, 0));
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}