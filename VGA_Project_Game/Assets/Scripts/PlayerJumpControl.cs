using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpControl : MonoBehaviour
{
    [SerializeField]
    Transform _transform = null;

    // Start is called before the first frame update
    void Start()
    {
        _transform = transform;   
    }

    // Update is called once per frame
    void Update()
    {
        // TODO: test   
    }

    Transform GetTransform()
    {
        return _transform;
    }
}
