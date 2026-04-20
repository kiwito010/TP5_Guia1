using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeclaracionDeVariables : MonoBehaviour
{
    public int VariableInt = 923;
    public string VariableString = maestro;
    public bool VariableBool = false;
    public float VariableFloat = 2,71592;
        
    // Start is called before the first frame update
    void Start(){
    Debug.Log(VariableBool +", "+ VariableFloat + ", "+ VariableInt+ ", "+ VariableString+".")
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
