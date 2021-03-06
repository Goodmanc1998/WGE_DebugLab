﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpCubeScript : MonoBehaviour {

    public GameObject _cube;
    public Vector3 _leftPosition;
    public Vector3 _rightPosition;

    public void StartLerp()
    {
        _cube.transform.position = _leftPosition;
        StartCoroutine(LerpCube());
    }

    IEnumerator LerpCube()
    {
        float t = 0;

        while (t < 1)
        {
            t += Time.deltaTime;
            Debug.Log(t);
            _cube.transform.position = Vector3.Lerp(_leftPosition, _rightPosition, t);
            if(t >=1)
            {
                _cube.transform.position = _rightPosition;
            }
            yield return null;
        }
    }

    //inseert code here:

}
