using UnityEngine;

public class Player
{
    #region singleton
    private static Player instance = null;
    public static Player Instance
    {
        get { return instance; }
    }
    #endregion

    public Vector3 playerPos;
}
