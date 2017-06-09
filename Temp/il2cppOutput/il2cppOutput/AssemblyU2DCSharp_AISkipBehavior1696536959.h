#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// AISkipBehavior
struct AISkipBehavior_t1696536959;
// UnityEngine.MeshCollider
struct MeshCollider_t2718867283;
// UnityEngine.GameObject
struct GameObject_t1756533147;
// UnityEngine.Rigidbody
struct Rigidbody_t4233889191;

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"
#include "AssemblyU2DCSharp_SkipBehavior448664699.h"
#include "UnityEngine_UnityEngine_Vector32243707580.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// AISkipBehavior
struct  AISkipBehavior_t1696536959  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.MeshCollider AISkipBehavior::m_collider
	MeshCollider_t2718867283 * ___m_collider_3;
	// UnityEngine.GameObject AISkipBehavior::m_brooms
	GameObject_t1756533147 * ___m_brooms_4;
	// UnityEngine.Rigidbody AISkipBehavior::m_rigidbody
	Rigidbody_t4233889191 * ___m_rigidbody_5;
	// SkipBehavior AISkipBehavior::m_skipBehavior
	int32_t ___m_skipBehavior_6;
	// System.Single AISkipBehavior::m_basicForce
	float ___m_basicForce_7;
	// System.Single AISkipBehavior::m_aIThinkingTime
	float ___m_aIThinkingTime_8;
	// System.Boolean AISkipBehavior::m_sweep
	bool ___m_sweep_9;
	// UnityEngine.Vector3 AISkipBehavior::m_housePosition
	Vector3_t2243707580  ___m_housePosition_10;

public:
	inline static int32_t get_offset_of_m_collider_3() { return static_cast<int32_t>(offsetof(AISkipBehavior_t1696536959, ___m_collider_3)); }
	inline MeshCollider_t2718867283 * get_m_collider_3() const { return ___m_collider_3; }
	inline MeshCollider_t2718867283 ** get_address_of_m_collider_3() { return &___m_collider_3; }
	inline void set_m_collider_3(MeshCollider_t2718867283 * value)
	{
		___m_collider_3 = value;
		Il2CppCodeGenWriteBarrier(&___m_collider_3, value);
	}

	inline static int32_t get_offset_of_m_brooms_4() { return static_cast<int32_t>(offsetof(AISkipBehavior_t1696536959, ___m_brooms_4)); }
	inline GameObject_t1756533147 * get_m_brooms_4() const { return ___m_brooms_4; }
	inline GameObject_t1756533147 ** get_address_of_m_brooms_4() { return &___m_brooms_4; }
	inline void set_m_brooms_4(GameObject_t1756533147 * value)
	{
		___m_brooms_4 = value;
		Il2CppCodeGenWriteBarrier(&___m_brooms_4, value);
	}

	inline static int32_t get_offset_of_m_rigidbody_5() { return static_cast<int32_t>(offsetof(AISkipBehavior_t1696536959, ___m_rigidbody_5)); }
	inline Rigidbody_t4233889191 * get_m_rigidbody_5() const { return ___m_rigidbody_5; }
	inline Rigidbody_t4233889191 ** get_address_of_m_rigidbody_5() { return &___m_rigidbody_5; }
	inline void set_m_rigidbody_5(Rigidbody_t4233889191 * value)
	{
		___m_rigidbody_5 = value;
		Il2CppCodeGenWriteBarrier(&___m_rigidbody_5, value);
	}

	inline static int32_t get_offset_of_m_skipBehavior_6() { return static_cast<int32_t>(offsetof(AISkipBehavior_t1696536959, ___m_skipBehavior_6)); }
	inline int32_t get_m_skipBehavior_6() const { return ___m_skipBehavior_6; }
	inline int32_t* get_address_of_m_skipBehavior_6() { return &___m_skipBehavior_6; }
	inline void set_m_skipBehavior_6(int32_t value)
	{
		___m_skipBehavior_6 = value;
	}

	inline static int32_t get_offset_of_m_basicForce_7() { return static_cast<int32_t>(offsetof(AISkipBehavior_t1696536959, ___m_basicForce_7)); }
	inline float get_m_basicForce_7() const { return ___m_basicForce_7; }
	inline float* get_address_of_m_basicForce_7() { return &___m_basicForce_7; }
	inline void set_m_basicForce_7(float value)
	{
		___m_basicForce_7 = value;
	}

	inline static int32_t get_offset_of_m_aIThinkingTime_8() { return static_cast<int32_t>(offsetof(AISkipBehavior_t1696536959, ___m_aIThinkingTime_8)); }
	inline float get_m_aIThinkingTime_8() const { return ___m_aIThinkingTime_8; }
	inline float* get_address_of_m_aIThinkingTime_8() { return &___m_aIThinkingTime_8; }
	inline void set_m_aIThinkingTime_8(float value)
	{
		___m_aIThinkingTime_8 = value;
	}

	inline static int32_t get_offset_of_m_sweep_9() { return static_cast<int32_t>(offsetof(AISkipBehavior_t1696536959, ___m_sweep_9)); }
	inline bool get_m_sweep_9() const { return ___m_sweep_9; }
	inline bool* get_address_of_m_sweep_9() { return &___m_sweep_9; }
	inline void set_m_sweep_9(bool value)
	{
		___m_sweep_9 = value;
	}

	inline static int32_t get_offset_of_m_housePosition_10() { return static_cast<int32_t>(offsetof(AISkipBehavior_t1696536959, ___m_housePosition_10)); }
	inline Vector3_t2243707580  get_m_housePosition_10() const { return ___m_housePosition_10; }
	inline Vector3_t2243707580 * get_address_of_m_housePosition_10() { return &___m_housePosition_10; }
	inline void set_m_housePosition_10(Vector3_t2243707580  value)
	{
		___m_housePosition_10 = value;
	}
};

struct AISkipBehavior_t1696536959_StaticFields
{
public:
	// AISkipBehavior AISkipBehavior::instance
	AISkipBehavior_t1696536959 * ___instance_2;

public:
	inline static int32_t get_offset_of_instance_2() { return static_cast<int32_t>(offsetof(AISkipBehavior_t1696536959_StaticFields, ___instance_2)); }
	inline AISkipBehavior_t1696536959 * get_instance_2() const { return ___instance_2; }
	inline AISkipBehavior_t1696536959 ** get_address_of_instance_2() { return &___instance_2; }
	inline void set_instance_2(AISkipBehavior_t1696536959 * value)
	{
		___instance_2 = value;
		Il2CppCodeGenWriteBarrier(&___instance_2, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
