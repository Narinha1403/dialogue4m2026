using UnityEngine;

public class MenuState : MonoBehaviour
{
    void Start()
    {
        GameManager.Instance.ChangeState(GameManager.GameState.MenuPrincipal);
    }
}