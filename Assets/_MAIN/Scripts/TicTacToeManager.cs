using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TicTacToeManager : MonoBehaviour
{
    public bool turn;
    public Component[][] Components;

    [SerializeField] private Component[] _componentSub1, _componentSub2, _componentSub3;
    
    // Start is called before the first frame update
    void Start()
    {
        // Components[0] = _componentSub1;
        // Components[1] = _componentSub2;
        // Components[2] = _componentSub3;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    
}
