using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeWeaponry : MonoBehaviour
{
    public BattleSystem7 Kraken;
    public BattleSystem8 Leviathan;

   public void WeakenKrakenn()
    {
        Kraken.timerMultiplicator = 1.7f;
        Kraken.smoothMotion = 2.0f;
        Kraken.bowPower = 0.18f;
        Kraken.bowGravityPower = 0.005f;
        Kraken.bowProgressDegradationPower = 0.2f;
        Kraken.failTimer = 7f;
        Kraken.failTimerRefresh = 7f;
    }
    
    public void WeakenLeviathan()
    {
        Leviathan.timerMultiplicator = 1.3f;
        Leviathan.smoothMotion = 1.5f;
        Leviathan.bowPower = 0.17f;
        Leviathan.bowGravityPower = 0.007f;
        Leviathan.bowProgressDegradationPower = 0.4f;
        Leviathan.failTimer = 5f;
        Leviathan.failTimerRefresh = 5f;
    }

    
}
