using System.Collections;
using System.Collections.Generic;
using PathCreation.Examples;
using UnityEngine;

public class BattleSystem8 : MonoBehaviour
{
    [SerializeField] Transform topPivot;
    [SerializeField] Transform bottomPivot;

    [SerializeField] Transform weapon;

    float weaponTimer;
    float weaponPosition;
    float weaponDestination;

    public AudioSwap audioSwap;
    public ShipBattleTrigger_8 sbt;
    public QuestGiverRebuildSkapning questGiverRebuildSkapning;
    public AudioControllScript audioControll;

    public GameObject LoseWindow;
    public GameObject LoseWindow2;
    public GameObject Collider;

    public QuestGiverIceMain questGiverMain;

    public Leviathan leviathan;
    public BoatController boatController;
    public GameObject enemyBoat;
    public QuestGoal questgoal;
    public Player goBattle;
    public GameObject collider;



    public float timerMultiplicator = 3f;

    float weaponSpeed;
    public float smoothMotion = 1f;


    [SerializeField] Transform bow;
    float bowPosition;
    public float bowSize = 0.1f;
    public float bowPower = 0.5f;
    float bowProgress;
    float bowPullVelocity;
    public float bowPullPower = 0.01f;
    public float bowGravityPower = 0.005f;
    public float bowProgressDegradationPower = 0.1f;

    [SerializeField] SpriteRenderer bowSpriteRenderer;

    [SerializeField] Transform progressBarContainer;

    bool pause = false;

    public float failTimer;
    public float failTimerRefresh;

    public AudioSource audioSource;

    public void Start()
    {
        Resize();
        
        audioSource.Stop();
    }

    
    private void Update()
    {

        if (pause) { return; }
        Weapon();
        Bow();
        ProgressCheck();
    }

    private void Resize()
    {
        Bounds b = bowSpriteRenderer.bounds;
        float ySize = b.size.y;
        Vector3 ls = bow.localScale;
        float distance = Vector3.Distance(topPivot.position, bottomPivot.position);
        ls.y = (distance / ySize * bowSize);
        bow.localScale = ls;
    }

    private void ProgressCheck()
    {
        Vector3 ls = progressBarContainer.localScale;
        ls.y = bowProgress;
        progressBarContainer.localScale = ls;

        float min = bowPosition - bowSize / 2f;
        float max = bowPosition + bowSize / 2f;

        if(min < weaponPosition && weaponPosition < max)
        {
            bowProgress += bowPower * Time.deltaTime;
        }

        else
        {
            bowProgress -= bowProgressDegradationPower * Time.deltaTime;

            failTimer -= Time.deltaTime;
            if(failTimer < 0f)
            {
                Lose();
            }
        }

        if(bowProgress >= 1f)
        {
            Win();
        }

        bowProgress = Mathf.Clamp(bowProgress, 0f, 1f);
    }

    void OnDisable()
    {
        Debug.Log("PrintOnDisable: script was disabled");
    }

    private void OnEnable()
    {
        failTimer = failTimerRefresh;
        Debug.Log("PrintOnEnable: script was enabled");
    }



    private void Lose()
    {
        if (questGiverRebuildSkapning.Upgrade2)
        {
            LoseWindow.SetActive(true);
            sbt.toggleOffImpact();
            this.gameObject.SetActive(false);
            Debug.Log("You Lose");
        }
        else
        {
            LoseWindow2.SetActive(true);
            sbt.toggleOffImpact();
            this.gameObject.SetActive(false);
            Debug.Log("You Lose");
        }

    }

    public void getaway()
    {
        audioControll.BattleLose();
        audioSwap.ReturnToDefault();
        sbt.toggleOffImpact();
        this.gameObject.SetActive(false);
        boatController.StartPlayer();
    }

    public void Win()
    {
        audioControll.Death();
        audioControll.BattleLose();
        questGiverMain.DeleteMarkerLeviathan();
        collider.SetActive(false);
        audioSource.Play();
        audioSwap.ReturnToDefault();
        this.gameObject.SetActive(false);
        boatController.StartPlayer();
        //destructible.DestroyBoat();
        sbt.toggleOffImpact();
        Collider.SetActive(false);
        //Destroy(enemyBoat);
        Debug.Log("You Win");
        questgoal.EnemyKilled();
        //goBattle.GoBattle();
        leviathan.enablegravity();
        leviathan.Death();

    }

    void Bow()
    {
        if (Input.GetMouseButton(0))
        {
            bowPullVelocity += bowPullPower * Time.deltaTime;
        }
        bowPullVelocity -= bowGravityPower * Time.deltaTime;

        bowPosition += bowPullVelocity;

        if (bowPosition - bowSize / 2 <= 0f && bowPullVelocity < 0f)
        {
            bowPullVelocity = 0f;
        }
        if (bowPosition + bowSize / 2 >= 1f && bowPullVelocity > 0f)
        {
            bowPullVelocity = 0f;
        }

        bowPosition = Mathf.Clamp(bowPosition, bowSize / 2, 1 - bowSize/2);
        bow.position = Vector3.Lerp(bottomPivot.position, topPivot.position, bowPosition);
    }
        void Weapon()
        {
        weaponTimer -= Time.deltaTime;
        if (weaponTimer < 0f)
        {
            weaponTimer = UnityEngine.Random.value * timerMultiplicator;

            weaponDestination = UnityEngine.Random.value;
        }

        weaponPosition = Mathf.SmoothDamp(weaponPosition, weaponDestination, ref weaponSpeed, smoothMotion);
        weapon.position = Vector3.Lerp(bottomPivot.position, topPivot.position, weaponPosition);

        }

}

