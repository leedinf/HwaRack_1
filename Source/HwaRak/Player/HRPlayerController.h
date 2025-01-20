// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/PlayerController.h"
#include "HRPlayerController.generated.h"

// 전방 선언 (Forward Declarations)
/**
 * 플레이어 컨트롤러 클래스
 */
UCLASS()
class HWARAK_API AHRPlayerController : public APlayerController
{
    GENERATED_BODY()

protected:
    // BeginPlay 함수 오버라이드
    virtual void BeginPlay() override;

public:
    //UPROPERTY(VisibleAnywhere, BlueprintReadOnly, Category = "UI")

};