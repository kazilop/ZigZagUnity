using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class btnTurnScript : MonoBehaviour
{
    public charController cController;

    public void OnButtonPressed()
    {
        cController.Switch();
    }
}
