#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.Rigidbody
struct Rigidbody_t4233889191;

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// CollisionSystem
struct  CollisionSystem_t2425677897  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.Rigidbody CollisionSystem::m_rigidbody
	Rigidbody_t4233889191 * ___m_rigidbody_2;

public:
	inline static int32_t get_offset_of_m_rigidbody_2() { return static_cast<int32_t>(offsetof(CollisionSystem_t2425677897, ___m_rigidbody_2)); }
	inline Rigidbody_t4233889191 * get_m_rigidbody_2() const { return ___m_rigidbody_2; }
	inline Rigidbody_t4233889191 ** get_address_of_m_rigidbody_2() { return &___m_rigidbody_2; }
	inline void set_m_rigidbody_2(Rigidbody_t4233889191 * value)
	{
		___m_rigidbody_2 = value;
		Il2CppCodeGenWriteBarrier(&___m_rigidbody_2, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
