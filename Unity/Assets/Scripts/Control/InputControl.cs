using UnityEngine;
using System.Collections;

/*
 * This class describes how to handle inputs.
 * All user inputs should controlled here unless:
 *  - input is controlled by UI
 * 
 * Strongly recommend use Update Message in here,
 *  because LateUpdate can be called more than once in a frame.
 */
public class InputControl : MonoBehaviour
{
    // Update is called once per frame
    void Update ()
    {
        // handles mouse controlled environment
        if (Input.GetMouseButtonDown (0)) {
            OnPress (Input.mousePosition);
        }
        
        if (Input.GetMouseButtonUp (0)) {
            OnUp (Input.mousePosition);
        }
        
        if (Input.GetMouseButton (0)) {
            OnPressing (Input.mousePosition);
        }
        
        // handles mobile touch environment
        switch (Input.touchCount) {
            // One finger touch
            case 1:
                Touch t = Input.GetTouch (0);
                if (t.phase.Equals (TouchPhase.Began)) {
                    OnPress (t.position);
                }
                if (t.phase.Equals (TouchPhase.Ended)) {
                    OnUp (t.position);
                }
                if (t.phase.Equals (TouchPhase.Stationary) ||
                    t.phase.Equals (TouchPhase.Moved)) {
                    OnPressing (t.position);
                }
                break;
                
                // Two fingers touch
            case 2:
                break;
                
                // More than two fingers touch
            default:
                break;
        }
    }
    
    protected virtual void OnPress (Vector3 pos)
    {
    }
    
    protected virtual void OnUp (Vector3 pos)
    {
    }
    
    protected virtual void OnPressing (Vector3 pos)
    {
    }
}
