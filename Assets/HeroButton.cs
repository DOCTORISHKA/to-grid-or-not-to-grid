using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroButton : MonoBehaviour
{
    GameObject core;
    // Start is called before the first frame update
    void Start()
    {
        core = GameObject.Find("Core");
        
    }
    void TaskOnClick()
    {
        //Output this to console when Button1 or Button3 is clicked
        Debug.Log("You have clicked the button!");
    }

    // Update is called once per frame
    public void OnButtonPress()
    {
        //Debug.Log("Button clicked ");
        Core coreScript = core.GetComponent<Core>();
        coreScript.selectedUnit = this.transform.root.gameObject;
        coreScript.unitSelected = true;
    }
}
