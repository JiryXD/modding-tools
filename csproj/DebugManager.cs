using UnityEngine;

public static class DebugManager
{

  private const string Prefix = "[Modding-Tools]";

  public static void PrintDebugMessage(string message)
  {
    Debug.Log(Prefix + " " + message);
  }

}