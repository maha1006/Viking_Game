using System.Collections;
using System.Collections.Generic;
using PathCreation.Examples;
using UnityEngine;

public class BattleSystem2 : MonoBehaviour
{
    [SerializeField] Transform topPivot;
    [SerializeField] Transform bottomPivot;

    [SerializeField] Transform weapon;

    float weaponTimer;
    float weaponPosition;
    float weaponDestination;


    public BoatController boatController;
    public PathFollower pathFollower;
    public LootDrop lootDrop;

    public GameObject enemyBoat;
    public QuestGoal questgoal;
    public Player goBattle;



    [SerializeField] float timerMultiplicator = 3f;

    float weaponSpeed;
    [SerializeField] float smoothMotion = 1f;


    [SerializeField] Transform bow;
    float bowPosition;
    [SerializeField] float bowSize = 0.1f;
    [SerializeField] float bowPower = 0.5f;
    float bowProgress;
    float bowPullVelocity;
    [SerializeField] float bowPullPower = 0.01f;
    [SerializeField] float bowGravityPower = 0.005f;
    [SerializeField] float bowProgressDegradationPower = 0.1f;

    [SerializeField] SpriteRenderer bowSpriteRenderer;

    [SerializeField] Transform progressBarContainer;

    bool pause = false;

    [SerializeField] float failTimer = 10f;

    private void Start()
    {
        Resize();
        //failTimer = 10f;
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
        failTimer = 10f;
        Debug.Log("PrintOnEnable: script was enabled");
    }


    private void Lose()
    {
        this.gameObject.SetActive(false);
        boatController.StartPlayer();
        pathFollower.StartShip();
        Debug.Log("You Lose");
        //enabled = false;
    }

    public void Win()
    {
        this.gameObject.SetActive(false);
        boatController.StartPlayer();
        Destroy(enemyBoat);
        lootDrop.DropLoot();
        Debug.Log("You Win");
        questgoal.EnemyKilled();
        goBattle.GoBattle();
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
