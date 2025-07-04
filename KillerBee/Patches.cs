﻿using GorillaNetworking;
using HarmonyLib;
using Photon.Pun;
using UnityEngine;

namespace KillerDoug
{
    [HarmonyPatch(typeof(AngryBeeSwarm), "LateUpdate")]
    public class BeePatches
    {
        public static void Postfix(AngryBeeSwarm __instance)
        {
            if (__instance.currentState == AngryBeeSwarm.ChaseState.Grabbing && __instance.targetPlayer.UserId == PhotonNetwork.LocalPlayer.UserId)
            {
                Application.Quit();
            }
        }
    }
}
