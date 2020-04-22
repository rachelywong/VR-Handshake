using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

// If we want to show controllers or not
public class ShowControllers : MonoBehaviour
{
    public bool showController = false;

    // Update is called once per frame
    void Update()
    {
        foreach (var hand in Player.instance.hands)
        {
            if(showController)
            {
                hand.ShowController();
                hand.SetSkeletonRangeOfMotion(Valve.VR.EVRSkeletalMotionRange.WithController); // hold the controller properly
            }
            else
            {
                hand.HideController();
                hand.SetSkeletonRangeOfMotion(Valve.VR.EVRSkeletalMotionRange.WithoutController);

            }
        }

    }
}
