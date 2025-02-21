using UnityEngine;

public class SkillManager : MonoBehaviour
{
    [SerializeField] private SkillData[] skillDataArray;   // 인스펙터에서 할당
    private Skill[] skills;
    private int skillIndex;
    public Transform target; // 공격 대상(예시)

    void Awake()
    {
        skillIndex = 0;
        // SkillData를 바탕으로 Skill 인스턴스화
        skills = new Skill[skillDataArray.Length];
        for (int i = 0; i < skillDataArray.Length; i++)
        {
            skills[i] = new Skill(skillDataArray[i]);
        }
    }

    void Update()
    {
        // 키 입력 예시 (1, 2, 3, ... 로 스킬 선택)
        if (Input.GetKeyDown(KeyCode.Q))
        {
            UseSkill(skillIndex);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            //스킬전환
            if(skillIndex + 1 < skills.Length){
                skillIndex ++;
            }
            else skillIndex = 0;
        }
        // etc...
    }

    public void UseSkill(int index)
    {
        if (index < 0 || index >= skills.Length) return;
        // if (target == null) return;

        skills[index].UseSkill(transform, target);
    }
}
