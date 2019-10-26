using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackControl : MonoBehaviour
{
    [SerializeField]
    GameObject _gameObject = null;

    // Start is called before the first frame update
    void Start()
    {
        _gameObject = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        // TODO: test
    }

    GameObject GetGameObject()
    {
        return _gameObject;
    }
}
