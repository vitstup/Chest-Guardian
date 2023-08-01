using UnityEngine;

public abstract class AbstractAnimationGroup : MonoBehaviour
{
    public abstract void RunAnimation();

    public abstract void RunEndAnimation();

    public abstract bool IsRunning();
}