// Fill out your copyright notice in the Description page of Project Settings.


#include "HRGameModeBase.h"
#include "Player/HRPlayerController.h"

AHRGameModeBase::AHRGameModeBase()
{
	static ConstructorHelpers::FClassFinder<APawn> TopDownClassRef(TEXT("/Game/TopDown/Blueprints/BP_TopDownCharacter.BP_TopDownCharacter"));//_C�� Ŭ���� ����
	if(TopDownClassRef.Class) {
		UE_LOG(LogTemp, Log, TEXT("why yes but~"));

		DefaultPawnClass = TopDownClassRef.Class;
	}
	else {
		UE_LOG(LogTemp, Log, TEXT("why no~"));
	}
	//DefaultPawnClass
	
	PlayerControllerClass = AHRPlayerController::StaticClass();//Ŭ���� ����
}
