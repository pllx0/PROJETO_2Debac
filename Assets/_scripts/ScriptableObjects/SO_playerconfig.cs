using UnityEngine;

[CreateAssetMenu(fileName = "SO_playerconfig", menuName = "Scriptable Objects/SO_playerconfig")]
public class SO_playerconfig : ScriptableObject
{
    public float speed;
    public float runspeed;

    public string runbool = "running";
    public string sprintbool = "sprint";
    public string jumpbool = "jump";
    public string deathanimation = "Death";
    public Vector2 friction = new Vector2(.1f, 0);
}
