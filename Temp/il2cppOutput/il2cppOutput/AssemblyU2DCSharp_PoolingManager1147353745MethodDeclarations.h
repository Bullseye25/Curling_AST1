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

// PoolingManager
struct PoolingManager_t1147353745;
// System.Collections.Generic.List`1<UnityEngine.GameObject>
struct List_1_t1125654279;

#include "codegen/il2cpp-codegen.h"
#include "AssemblyU2DCSharp_Pool3771281794.h"
#include "UnityEngine_UnityEngine_Vector32243707580.h"

// System.Void PoolingManager::.ctor()
extern "C"  void PoolingManager__ctor_m2651383756 (PoolingManager_t1147353745 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void PoolingManager::Awake()
extern "C"  void PoolingManager_Awake_m2024893009 (PoolingManager_t1147353745 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Collections.Generic.List`1<UnityEngine.GameObject> PoolingManager::CreatePool(Pool,System.Int32)
extern "C"  List_1_t1125654279 * PoolingManager_CreatePool_m97764660 (PoolingManager_t1147353745 * __this, int32_t ___a_object0, int32_t ___a_amount1, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void PoolingManager::GetActiveObject(System.Collections.Generic.List`1<UnityEngine.GameObject>,UnityEngine.Vector3)
extern "C"  void PoolingManager_GetActiveObject_m998887964 (PoolingManager_t1147353745 * __this, List_1_t1125654279 * ___a_pool0, Vector3_t2243707580  ___a_objectPlacingPosition1, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void PoolingManager::Clear(System.Collections.Generic.List`1<UnityEngine.GameObject>)
extern "C"  void PoolingManager_Clear_m3837534303 (PoolingManager_t1147353745 * __this, List_1_t1125654279 * ___a_list0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void PoolingManager::.cctor()
extern "C"  void PoolingManager__cctor_m3205503403 (Il2CppObject * __this /* static, unused */, const MethodInfo* method) IL2CPP_METHOD_ATTR;
