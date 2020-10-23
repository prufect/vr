using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject ballObject;
    public GameObject pinsObject;
    public Vector3 originalBallPos;
    public Vector3 originalPinsPos;

    // Start is called before the first frame update
    void Start()
    {
        originalBallPos = ballObject.transform.position;
        originalPinsPos = pinsObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetOriginalPositions()
    {
        ballObject.transform.position = originalBallPos;

        DestroyImmediate(pinsObject, true);
        pinsObject = Instantiate(pinsObject, originalPinsPos, Quaternion.identity);
    }
}
