using UnityEngine;

public class ButtonObject : MonoBehaviour
{
    public Animator animator;

    public void LoadGame()
    {
        SceneLoader.Instance.LoadNewScene("FactoryBuild");
    }

    private void OnTriggerEnter(Collider other)
    {
        LoadGame();
        animator.SetTrigger("Click");
    }
}
