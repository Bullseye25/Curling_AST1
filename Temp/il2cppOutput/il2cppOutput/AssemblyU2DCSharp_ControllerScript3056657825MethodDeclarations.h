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

// ControllerScript
struct ControllerScript_t3056657825;
// UnityEngine.Collision
struct Collision_t2876846408;
// UnityEngine.Collider
struct Collider_t3497673348;
// System.Collections.IEnumerator
struct IEnumerator_t1466026749;
// UnityEngine.Rigidbody
struct Rigidbody_t4233889191;

#include "codegen/il2cpp-codegen.h"
#include "UnityEngine_UnityEngine_Vector32243707580.h"
#include "UnityEngine_UnityEngine_Collision2876846408.h"
#include "UnityEngine_UnityEngine_Collider3497673348.h"
#include "UnityEngine_UnityEngine_Rigidbody4233889191.h"

// System.Void ControllerScript::.ctor()
extern "C"  void ControllerScript__ctor_m3487230474 (ControllerScript_t3056657825 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void ControllerScript::Awake()
extern "C"  void ControllerScript_Awake_m1078026509 (ControllerScript_t3056657825 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void ControllerScript::OnEnable()
extern "C"  void ControllerScript_OnEnable_m2685697442 (ControllerScript_t3056657825 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void ControllerScript::Update()
extern "C"  void ControllerScript_Update_m4101485537 (ControllerScript_t3056657825 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void ControllerScript::Controlls()
extern "C"  void ControllerScript_Controlls_m623383302 (ControllerScript_t3056657825 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void ControllerScript::CurlingBehavior()
extern "C"  void ControllerScript_CurlingBehavior_m3308732506 (ControllerScript_t3056657825 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void ControllerScript::CurlingController()
extern "C"  void ControllerScript_CurlingController_m2216543604 (ControllerScript_t3056657825 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void ControllerScript::Curling(System.Boolean)
extern "C"  void ControllerScript_Curling_m2517756455 (ControllerScript_t3056657825 * __this, bool ___a_activator0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void ControllerScript::ResetCurlingForce()
extern "C"  void ControllerScript_ResetCurlingForce_m2987983380 (ControllerScript_t3056657825 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void ControllerScript::ArrowController()
extern "C"  void ControllerScript_ArrowController_m3812570241 (ControllerScript_t3056657825 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Vector3 ControllerScript::VirtualPosition()
extern "C"  Vector3_t2243707580  ControllerScript_VirtualPosition_m1832022720 (ControllerScript_t3056657825 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void ControllerScript::Locomote()
extern "C"  void ControllerScript_Locomote_m85776648 (ControllerScript_t3056657825 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void ControllerScript::MoveStone()
extern "C"  void ControllerScript_MoveStone_m1213695040 (ControllerScript_t3056657825 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Vector3 ControllerScript::Force()
extern "C"  Vector3_t2243707580  ControllerScript_Force_m240728651 (ControllerScript_t3056657825 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void ControllerScript::NextTurn()
extern "C"  void ControllerScript_NextTurn_m2154219594 (ControllerScript_t3056657825 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Boolean ControllerScript::IsStoneMoving()
extern "C"  bool ControllerScript_IsStoneMoving_m3650573133 (ControllerScript_t3056657825 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Boolean ControllerScript::TargetingArrowActive()
extern "C"  bool ControllerScript_TargetingArrowActive_m285842660 (ControllerScript_t3056657825 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void ControllerScript::OnCollisionEnter(UnityEngine.Collision)
extern "C"  void ControllerScript_OnCollisionEnter_m1020335516 (ControllerScript_t3056657825 * __this, Collision_t2876846408 * ___a_collision0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void ControllerScript::StopStone()
extern "C"  void ControllerScript_StopStone_m1886176055 (ControllerScript_t3056657825 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void ControllerScript::OnTriggerEnter(UnityEngine.Collider)
extern "C"  void ControllerScript_OnTriggerEnter_m3957351654 (ControllerScript_t3056657825 * __this, Collider_t3497673348 * ___a_collider0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Collections.IEnumerator ControllerScript::FreezeYaxis(UnityEngine.Rigidbody)
extern "C"  Il2CppObject * ControllerScript_FreezeYaxis_m201546145 (ControllerScript_t3056657825 * __this, Rigidbody_t4233889191 * ___a_rigidbody0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void ControllerScript::ResetArrow()
extern "C"  void ControllerScript_ResetArrow_m3822421980 (ControllerScript_t3056657825 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void ControllerScript::UpdateArrowColor()
extern "C"  void ControllerScript_UpdateArrowColor_m2829902309 (ControllerScript_t3056657825 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void ControllerScript::ResetStoneProperties()
extern "C"  void ControllerScript_ResetStoneProperties_m2754029763 (ControllerScript_t3056657825 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void ControllerScript::ChangeMaterial()
extern "C"  void ControllerScript_ChangeMaterial_m682041561 (ControllerScript_t3056657825 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void ControllerScript::ArrowSize(System.Single)
extern "C"  void ControllerScript_ArrowSize_m556355457 (ControllerScript_t3056657825 * __this, float ___value0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void ControllerScript::.cctor()
extern "C"  void ControllerScript__cctor_m4281571835 (Il2CppObject * __this /* static, unused */, const MethodInfo* method) IL2CPP_METHOD_ATTR;
