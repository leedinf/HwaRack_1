// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/PlayerController.h"
#include "HRPlayerController.generated.h"

// ���� ���� (Forward Declarations)
/**
 * �÷��̾� ��Ʈ�ѷ� Ŭ����
 */
UCLASS()
class HWARAK_API AHRPlayerController : public APlayerController
{
    GENERATED_BODY()

protected:
    // BeginPlay �Լ� �������̵�
    virtual void BeginPlay() override;

public:
    //UPROPERTY(VisibleAnywhere, BlueprintReadOnly, Category = "UI")

};