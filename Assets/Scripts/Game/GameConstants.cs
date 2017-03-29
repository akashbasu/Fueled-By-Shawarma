using UnityEngine;
using System;
public class GameConstants : MonoBehaviour
{
    public float delta;
    public float minSwipeThreashold;

    private static GameConstants gameConstants;

    public static GameConstants instance
    {
        get
        {
            if (!gameConstants)
            {
                gameConstants = FindObjectOfType<GameConstants>();
                if (!gameConstants)
                {
                   Debug.LogError("There needs to be one active GameConstants script on a GameObject in your scene.");
                }
                else
                {
                    gameConstants.InitDynamicGameConstants();
                }
            }

            return gameConstants;
        }
    }

    void InitDynamicGameConstants()
    {
        throw new NotImplementedException();
    }
}
