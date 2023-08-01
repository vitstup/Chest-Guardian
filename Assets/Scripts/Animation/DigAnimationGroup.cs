using Cainos.PixelArtPlatformer_VillageProps;
using System.Collections;
using UnityEngine;

public class DigAnimationGroup : AbstractAnimationGroup
{
    [SerializeField] private Animator animator;
    [SerializeField] private Chest chest;

    private bool isRunning;

    public override void RunAnimation()
    {
        StartCoroutine(Anim());
    }

    private IEnumerator Anim()
    {
        isRunning = true;

        animator.SetTrigger("Attack");

        float animationLength = animator.GetCurrentAnimatorStateInfo(0).length;
        yield return new WaitForSeconds(animationLength);

        chest.Open();

        isRunning = false;
    }

    public override void RunEndAnimation()
    {
        chest.Close();
    }

    public override bool IsRunning()
    {
        return isRunning;
    }
}