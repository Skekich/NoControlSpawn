using System;

public class EventHandler
{
    internal static event Action OnInvokeCollider;
    internal static event Action<int> OnInvokeScore;
    internal static event Action OnInvokeTimeOut;
    public static void InvokeCollide()
    {
        OnInvokeCollider?.Invoke();
    }

    public static void InvokeScore(int score)
    {
        OnInvokeScore?.Invoke(score);
    }

    public static void InvokeTimeOut()
    {
        OnInvokeTimeOut?.Invoke();
    }
}
