using Unity.VisualScripting;
using UnityEngine;

public class Skill
{
    private SkillData data;

    private float lastUseTime;

    // 생성자에서 SkillData를 받아 초기화
    public Skill(SkillData skillData)
    {
        data = skillData;
        lastUseTime = -999f; // 쿨타임 체크용
    }

    // 스킬 사용 가능 여부(쿨타임 확인)
    public bool CanUseSkill()
    {
        return Time.time >= lastUseTime + data.cooldown;
    }

    // 스킬 사용 로직
    public void UseSkill(Transform caster, Transform target)
    {
        if (!CanUseSkill()) return;

        lastUseTime = Time.time;

        // 예시: 타겟에게 데미지 주는 로직
        // (target에 Health 컴포넌트가 있다고 가정)
        // var health = target.GetComponent<Health>();
        // if (health != null)
        // {
        //     health.TakeDamage(data.damage);
        // }

        // 이펙트 소환
        if (data.effectPrefab != null)
        {   
            GameObject effect = Object.Instantiate(data.effectPrefab, caster.position, Quaternion.identity);
            effect.transform.SetParent(caster);
            effect.transform.position = caster.position;
            
            Object.Destroy(effect, 5f); // 몇 초 후 파괴
        }

        // 필요하면 사운드 재생, 상태이상 처리 등 추가
    }
}
