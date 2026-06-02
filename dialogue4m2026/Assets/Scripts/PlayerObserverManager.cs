using System;

public static class PlayerObserverManager
{
    public static event Action<int> OnCoinCollected;

    public static void CollectCoin(int amount)
    {
        OnCoinCollected?.Invoke(amount);
    }
}