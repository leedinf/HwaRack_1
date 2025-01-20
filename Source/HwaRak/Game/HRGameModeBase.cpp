// Fill out your copyright notice in the Description page of Project Settings.


#include "HRGameModeBase.h"
#include "Player/HRPlayerController.h"

AHRGameModeBase::AHRGameModeBase()
{
	static ConstructorHelpers::FClassFinder<APawn> TopDownClassRef(TEXT("/Game/Character/BP_TopDownChar.BP_TopDownChar_C"));
	//static ConstructorHelpers::FClassFinder<UUserWidget> UIClassRef(TEXT("/Game/UI/UI_Main.UI_Main_C"));

	if(TopDownClassRef.Class) {
		UE_LOG(LogTemp, Log, TEXT("why yes but~"));

		DefaultPawnClass = TopDownClassRef.Class;
	}
	else {
		UE_LOG(LogTemp, Log, TEXT("why no~"));
	}
	//DefaultPawnClass

	//if (UIClassRef.Class) {
	//	//HUDClass = UIClassRef.Class;

	//}
	//else {
	//	UE_LOG(LogTemp, Log, TEXT("why no UI nn"));

	//}
	PlayerControllerClass = AHRPlayerController::StaticClass();//클래스 설정
}
