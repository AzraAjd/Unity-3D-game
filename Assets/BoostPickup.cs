using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.FPS.Gameplay
{
    public class BoostPickup : Pickup
    {
        public float BoostAmount;
        private PlayerCharacterController playerCtrl;
        protected override void OnPicked(PlayerCharacterController player)
        {
            playerCtrl = player.GetComponent<PlayerCharacterController>();
            playerCtrl.JumpForce = 7;
            GetComponent<MeshRenderer>().enabled = false;
            StartCoroutine("Timer");
        }

        IEnumerator Timer()
        {
            yield return new WaitForSeconds(5);
            Debug.Log("timer is up");
            playerCtrl.JumpForce = 5;
            Destroy(gameObject);
        }


    }
}
