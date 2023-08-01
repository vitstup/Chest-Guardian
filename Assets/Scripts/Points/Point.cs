using UnityEngine;
using DG.Tweening;

public class Point : MonoBehaviour
{
    [SerializeField, Range(0.1f, 5f)] private float animationTime;
    [SerializeField] private float jumpHeight;

    public void InitializePoint(Vector3 position, Vector3 targetPosition)
    {
        transform.localScale = Vector3.one;

        transform.position = position;

        Sequence sequence = DOTween.Sequence();

        // Random Fallong
        Vector3 randomPosition = position + Random.insideUnitSphere * jumpHeight;
        sequence.Append(transform.DOMove(randomPosition, animationTime / 2).SetEase(Ease.OutQuad));

        // Rising Up
        Vector3 jumpPosition = randomPosition + Vector3.up * jumpHeight;
        sequence.Append(transform.DOMove(jumpPosition, animationTime / 4).SetEase(Ease.OutQuad));

        // Falling Again
        sequence.Append(transform.DOMove(randomPosition, animationTime / 4).SetEase(Ease.InQuad));

        // Flying and Scaling
        sequence.Append(transform.DOMove(targetPosition, animationTime).SetEase(Ease.Linear));
        sequence.Join(transform.DOScale(new Vector3(0.2f, 0.2f, 0.2f), animationTime));

        // End of Animation
        sequence.OnComplete(() => TargetReached());
    }

    public void TargetReached()
    {
        gameObject.SetActive(false);
    }
}