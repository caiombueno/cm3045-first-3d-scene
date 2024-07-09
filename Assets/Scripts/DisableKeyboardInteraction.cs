using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableKeyboardInteraction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.EventSystems.EventSystem.current.sendNavigationEvents = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
