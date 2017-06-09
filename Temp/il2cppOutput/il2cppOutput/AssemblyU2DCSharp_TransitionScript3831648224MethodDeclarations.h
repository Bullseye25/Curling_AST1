#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>
#include <assert.h>
#include <exception>

// TransitionScript
struct TransitionScript_t3831648224;
// UnityEngine.UI.Text
struct Text_t356221433;
// System.Collections.Generic.List`1<UnityEngine.UI.Text>
struct List_1_t4020309861;
// System.String
struct String_t;
// UnityEngine.GameObject
struct GameObject_t1756533147;

#include "codegen/il2cpp-codegen.h"
#include "UnityEngine_UI_UnityEngine_UI_Text356221433.h"
#include "mscorlib_System_String2029220233.h"
#include "UnityEngine_UnityEngine_GameObject1756533147.h"

// System.Void TransitionScript::.ctor()
extern "C"  void TransitionScript__ctor_m2309396619 (TransitionScript_t3831648224 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void TransitionScript::Awake()
extern "C"  void TransitionScript_Awake_m2938539840 (TransitionScript_t3831648224 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void TransitionScript::Start()
extern "C"  void TransitionScript_Start_m415359775 (TransitionScript_t3831648224 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void TransitionScript::ActiveController(System.Int32)
extern "C"  void TransitionScript_ActiveController_m3434208880 (TransitionScript_t3831648224 * __this, int32_t ___a_activationValue0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void TransitionScript::NextTurn()
extern "C"  void TransitionScript_NextTurn_m50136509 (TransitionScript_t3831648224 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void TransitionScript::RemoveOneUIStone()
extern "C"  void TransitionScript_RemoveOneUIStone_m1158949412 (TransitionScript_t3831648224 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void TransitionScript::TransitionDisabler()
extern "C"  void TransitionScript_TransitionDisabler_m903351914 (TransitionScript_t3831648224 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void TransitionScript::ResetTurn()
extern "C"  void TransitionScript_ResetTurn_m615012727 (TransitionScript_t3831648224 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void TransitionScript::ActivateStonsUI()
extern "C"  void TransitionScript_ActivateStonsUI_m2513891963 (TransitionScript_t3831648224 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void TransitionScript::CalculateScores()
extern "C"  void TransitionScript_CalculateScores_m2416028184 (TransitionScript_t3831648224 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void TransitionScript::DisplayScores(System.Int32,System.Int32)
extern "C"  void TransitionScript_DisplayScores_m1693596382 (TransitionScript_t3831648224 * __this, int32_t ___a_p10, int32_t ___a_p21, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void TransitionScript::DiclearFinalScore(System.Int32,System.Int32)
extern "C"  void TransitionScript_DiclearFinalScore_m1108089263 (TransitionScript_t3831648224 * __this, int32_t ___a_p10, int32_t ___a_p21, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void TransitionScript::SetScore(System.Int32,UnityEngine.UI.Text,System.Collections.Generic.List`1<UnityEngine.UI.Text>,System.Collections.Generic.List`1<UnityEngine.UI.Text>)
extern "C"  void TransitionScript_SetScore_m2345622626 (TransitionScript_t3831648224 * __this, int32_t ___a_playerScore0, Text_t356221433 * ___a_totalScoringTextDisplay1, List_1_t4020309861 * ___a_winnerEndScore2, List_1_t4020309861 * ___a_loserEndScore3, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void TransitionScript::SetWinningTitle(System.String)
extern "C"  void TransitionScript_SetWinningTitle_m860117353 (TransitionScript_t3831648224 * __this, String_t* ___a_playerID0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Int32 TransitionScript::ByDistance(UnityEngine.GameObject,UnityEngine.GameObject)
extern "C"  int32_t TransitionScript_ByDistance_m167968537 (TransitionScript_t3831648224 * __this, GameObject_t1756533147 * ___a0, GameObject_t1756533147 * ___b1, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void TransitionScript::GetClosestStones()
extern "C"  void TransitionScript_GetClosestStones_m3194770458 (TransitionScript_t3831648224 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void TransitionScript::MakeNewStone()
extern "C"  void TransitionScript_MakeNewStone_m450816750 (TransitionScript_t3831648224 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Boolean TransitionScript::IsOdd()
extern "C"  bool TransitionScript_IsOdd_m1926031652 (TransitionScript_t3831648224 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Collections.Generic.List`1<UnityEngine.UI.Text> TransitionScript::GetEndScoringTexts(System.String)
extern "C"  List_1_t4020309861 * TransitionScript_GetEndScoringTexts_m230065766 (TransitionScript_t3831648224 * __this, String_t* ___a_parentObject0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// UnityEngine.GameObject TransitionScript::GetScoringPanel()
extern "C"  GameObject_t1756533147 * TransitionScript_GetScoringPanel_m2670910945 (TransitionScript_t3831648224 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void TransitionScript::ActivateScoringPanel()
extern "C"  void TransitionScript_ActivateScoringPanel_m292552761 (TransitionScript_t3831648224 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Boolean TransitionScript::IsScoringPanelActive()
extern "C"  bool TransitionScript_IsScoringPanelActive_m3282487582 (TransitionScript_t3831648224 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void TransitionScript::ClearScoreBoard()
extern "C"  void TransitionScript_ClearScoreBoard_m1056866432 (TransitionScript_t3831648224 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void TransitionScript::ClearScoreBoards(UnityEngine.UI.Text,System.Collections.Generic.List`1<UnityEngine.UI.Text>)
extern "C"  void TransitionScript_ClearScoreBoards_m1361328481 (TransitionScript_t3831648224 * __this, Text_t356221433 * ___a_displayedScore0, List_1_t4020309861 * ___a_endScoreBoard1, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void TransitionScript::ScriptDisabler()
extern "C"  void TransitionScript_ScriptDisabler_m1576499010 (TransitionScript_t3831648224 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Int32 TransitionScript::GetTurn()
extern "C"  int32_t TransitionScript_GetTurn_m2350604126 (TransitionScript_t3831648224 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void TransitionScript::.cctor()
extern "C"  void TransitionScript__cctor_m128807514 (Il2CppObject * __this /* static, unused */, const MethodInfo* method) IL2CPP_METHOD_ATTR;
