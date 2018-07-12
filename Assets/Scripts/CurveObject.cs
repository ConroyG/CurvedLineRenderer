using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu( menuName =  "CurveObject")]
public class CurveObject : ScriptableObject
{

    [SerializeField] private AnimationCurve _curve;

    public AnimationCurve Curve
    {
        get { return _curve; }
        set { _curve = value; }
    }
}
