using UnityEngine;

public class AnimationSFXTriggers : MonoBehaviour
{
    public void PlayAnimationSFX(int sfxToPlay)
    {
        AudioManager.Instance.PlaySFX(sfxToPlay);
    }
}
