using UnityEngine;

public class GameplayState : MonoBehaviour
{
    void Start()
    {
        GameManager.Instance.ChangeState(GameManager.GameState.Gameplay);
    }
}
