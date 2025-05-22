using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{
    [SerializeField] private byte _id;
    [SerializeField] private Mesh[] _mesh = new Mesh[2];
    [SerializeField] private Component _manager;
    
    // Start is called before the first frame update
    void Start()
    {
        
        GetComponent<MeshFilter>().mesh = _mesh[(_manager.GetComponent<TicTacToeManager>().turn ? 0 : 1)];
        _manager.GetComponent<test>().TestFunc();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public byte ID
    {
        get => _id;
        
    }

    public void ReceiveRay()
    {
        _manager.GetComponent<test>().TestFunc();

    }
    
}
