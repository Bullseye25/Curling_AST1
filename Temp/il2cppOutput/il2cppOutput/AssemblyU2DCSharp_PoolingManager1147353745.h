#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.GameObject[]
struct GameObjectU5BU5D_t3057952154;
// PoolingManager
struct PoolingManager_t1147353745;

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// PoolingManager
struct  PoolingManager_t1147353745  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.GameObject[] PoolingManager::m_pooledObject
	GameObjectU5BU5D_t3057952154* ___m_pooledObject_2;

public:
	inline static int32_t get_offset_of_m_pooledObject_2() { return static_cast<int32_t>(offsetof(PoolingManager_t1147353745, ___m_pooledObject_2)); }
	inline GameObjectU5BU5D_t3057952154* get_m_pooledObject_2() const { return ___m_pooledObject_2; }
	inline GameObjectU5BU5D_t3057952154** get_address_of_m_pooledObject_2() { return &___m_pooledObject_2; }
	inline void set_m_pooledObject_2(GameObjectU5BU5D_t3057952154* value)
	{
		___m_pooledObject_2 = value;
		Il2CppCodeGenWriteBarrier(&___m_pooledObject_2, value);
	}
};

struct PoolingManager_t1147353745_StaticFields
{
public:
	// PoolingManager PoolingManager::instance
	PoolingManager_t1147353745 * ___instance_3;

public:
	inline static int32_t get_offset_of_instance_3() { return static_cast<int32_t>(offsetof(PoolingManager_t1147353745_StaticFields, ___instance_3)); }
	inline PoolingManager_t1147353745 * get_instance_3() const { return ___instance_3; }
	inline PoolingManager_t1147353745 ** get_address_of_instance_3() { return &___instance_3; }
	inline void set_instance_3(PoolingManager_t1147353745 * value)
	{
		___instance_3 = value;
		Il2CppCodeGenWriteBarrier(&___instance_3, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
