using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameStartCoundownUI : MonoBehaviour
{
   [SerializeField] private TextMeshProUGUI countdownText;

    private const string NUMBER_POPUP = "NumberPopup";

    private Animator animator;

    private int previousCountdownNumber;

   private void Start()
    {
        KitchenGameManager.Instance.OnStateChanged += KitchenGameManager_OnStateChanged;
        animator = GetComponent<Animator>();
        Hide();
    }

   private void KitchenGameManager_OnStateChanged(object sender, System.EventArgs e)
   {
        if(KitchenGameManager.Instance.IsCountdownToStartActive())
        {
            Show();
        }
        else
        {
            Hide();
        }
   }

   private void Show()
   {
     gameObject.SetActive(true);
   }

   private void Hide()
   {
    gameObject.SetActive(false);
   }

    private void Update()
    {
        int countdownNumber = Mathf.CeilToInt(KitchenGameManager.Instance.GetCountdownToStartTimer());
        countdownText.text = countdownNumber.ToString();

        if (previousCountdownNumber != countdownNumber)
        {
            previousCountdownNumber = countdownNumber;
            animator.SetTrigger(NUMBER_POPUP);
            SoundManager.Instance.PlayCountdownSound();
        }
    }
}
