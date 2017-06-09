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

// AISkipBehavior
struct AISkipBehavior_t1696536959;
// System.Collections.IEnumerator
struct IEnumerator_t1466026749;
// UnityEngine.GameObject
struct GameObject_t1756533147;
// UnityEngine.Rigidbody
struct Rigidbody_t4233889191;
// UnityEngine.Collision
struct Collision_t2876846408;

#include "codegen/il2cpp-codegen.h"
#include "UnityEngine_UnityEngine_Vector32243707580.h"
#include "UnityEngine_UnityEngine_GameObject1756533147.h"
#include "UnityEngine_UnityEngine_Rigidbody4233889191.h"
#include "UnityEngine_UnityEngine_Collision2876846408.h"

// System.Void AISkipBehavior::.ctor()
extern "C"  void AISkipBehavior__ctor_m585585442 (AISkipBehavior_t1696536959 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void AISkipBehavior::Awake()
extern "C"  void AISkipBehavior_Awake_m1219058527 (AISkipBehavior_t1696536959 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void AISkipBehavior::Start()
extern "C"  void AISkipBehavior_Start_m3435032446 (AISkipBehavior_t1696536959 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void AISkipBehavior::OnEnable()
extern "C"  void AISkipBehavior_OnEnable_m3251223422 (AISkipBehavior_t1696536959 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void AISkipBehavior::Update()
extern "C"  void AISkipBehavior_Update_m170380267 (AISkipBehavior_t1696536959 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Collections.IEnumerator AISkipBehavior::Sweeping()
extern "C"  Il2CppObject * AISkipBehavior_Sweeping_m41085876 (AISkipBehavior_t1696536959 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void AISkipBehavior::PickBehavior()
extern "C"  void AISkipBehavior_PickBehavior_m365022939 (AISkipBehavior_t1696536959 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Collections.IEnumerator AISkipBehavior::BasicBehavior()
extern "C"  Il2CppObject * AISkipBehavior_BasicBehavior_m1712361514 (AISkipBehavior_t1696536959 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Vector3 AISkipBehavior::Force()
extern "C"  Vector3_t2243707580  AISkipBehavior_Force_m3711151337 (AISkipBehavior_t1696536959 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Collections.IEnumerator AISkipBehavior::CopyBehavior()
extern "C"  Il2CppObject * AISkipBehavior_CopyBehavior_m626611601 (AISkipBehavior_t1696536959 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Vector3 AISkipBehavior::AimAtTarget()
extern "C"  Vector3_t2243707580  AISkipBehavior_AimAtTarget_m1331079709 (AISkipBehavior_t1696536959 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Int32 AISkipBehavior::ByDistance(UnityEngine.GameObject,UnityEngine.GameObject)
extern "C"  int32_t AISkipBehavior_ByDistance_m2793237158 (AISkipBehavior_t1696536959 * __this, GameObject_t1756533147 * ___a0, GameObject_t1756533147 * ___b1, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Collections.IEnumerator AISkipBehavior::FreezeYaxis(UnityEngine.Rigidbody)
extern "C"  Il2CppObject * AISkipBehavior_FreezeYaxis_m2262885127 (AISkipBehavior_t1696536959 * __this, Rigidbody_t4233889191 * ___a_rigidbody0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void AISkipBehavior::OnCollisionEnter(UnityEngine.Collision)
extern "C"  void AISkipBehavior_OnCollisionEnter_m1604500112 (AISkipBehavior_t1696536959 * __this, Collision_t2876846408 * ___a_collision0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void AISkipBehavior::StopStone()
extern "C"  void AISkipBehavior_StopStone_m1591652873 (AISkipBehavior_t1696536959 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Boolean AISkipBehavior::IsStoneMoving()
extern "C"  bool AISkipBehavior_IsStoneMoving_m3290927547 (AISkipBehavior_t1696536959 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Boolean AISkipBehavior::IsFarFromGoal()
extern "C"  bool AISkipBehavior_IsFarFromGoal_m604795114 (AISkipBehavior_t1696536959 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void AISkipBehavior::.cctor()
extern "C"  void AISkipBehavior__cctor_m145869713 (Il2CppObject * __this /* static, unused */, const MethodInfo* method) IL2CPP_METHOD_ATTR;
