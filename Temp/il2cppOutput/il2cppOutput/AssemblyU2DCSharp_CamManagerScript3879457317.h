#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// CamManagerScript
struct CamManagerScript_t3879457317;
// UnityEngine.GameObject
struct GameObject_t1756533147;

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"
#include "UnityEngine_UnityEngine_Vector32243707580.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// CamManagerScript
struct  CamManagerScript_t3879457317  : public MonoBehaviour_t1158329972
{
public:
	// System.Single CamManagerScript::m_maxTopDown
	float ___m_maxTopDown_3;
	// UnityEngine.GameObject CamManagerScript::m_stone
	GameObject_t1756533147 * ___m_stone_4;
	// UnityEngine.Vector3 CamManagerScript::m_offset
	Vector3_t2243707580  ___m_offset_5;
	// UnityEngine.Vector3 CamManagerScript::m_endrotation
	Vector3_t2243707580  ___m_endrotation_6;
	// UnityEngine.Vector3 CamManagerScript::m_defaultCamPosition
	Vector3_t2243707580  ___m_defaultCamPosition_7;
	// UnityEngine.Vector3 CamManagerScript::m_defaultCamRotation
	Vector3_t2243707580  ___m_defaultCamRotation_8;
	// UnityEngine.Vector3 CamManagerScript::m_broomsStartingPosition
	Vector3_t2243707580  ___m_broomsStartingPosition_9;
	// UnityEngine.Vector3 CamManagerScript::m_broomsOffset
	Vector3_t2243707580  ___m_broomsOffset_10;

public:
	inline static int32_t get_offset_of_m_maxTopDown_3() { return static_cast<int32_t>(offsetof(CamManagerScript_t3879457317, ___m_maxTopDown_3)); }
	inline float get_m_maxTopDown_3() const { return ___m_maxTopDown_3; }
	inline float* get_address_of_m_maxTopDown_3() { return &___m_maxTopDown_3; }
	inline void set_m_maxTopDown_3(float value)
	{
		___m_maxTopDown_3 = value;
	}

	inline static int32_t get_offset_of_m_stone_4() { return static_cast<int32_t>(offsetof(CamManagerScript_t3879457317, ___m_stone_4)); }
	inline GameObject_t1756533147 * get_m_stone_4() const { return ___m_stone_4; }
	inline GameObject_t1756533147 ** get_address_of_m_stone_4() { return &___m_stone_4; }
	inline void set_m_stone_4(GameObject_t1756533147 * value)
	{
		___m_stone_4 = value;
		Il2CppCodeGenWriteBarrier(&___m_stone_4, value);
	}

	inline static int32_t get_offset_of_m_offset_5() { return static_cast<int32_t>(offsetof(CamManagerScript_t3879457317, ___m_offset_5)); }
	inline Vector3_t2243707580  get_m_offset_5() const { return ___m_offset_5; }
	inline Vector3_t2243707580 * get_address_of_m_offset_5() { return &___m_offset_5; }
	inline void set_m_offset_5(Vector3_t2243707580  value)
	{
		___m_offset_5 = value;
	}

	inline static int32_t get_offset_of_m_endrotation_6() { return static_cast<int32_t>(offsetof(CamManagerScript_t3879457317, ___m_endrotation_6)); }
	inline Vector3_t2243707580  get_m_endrotation_6() const { return ___m_endrotation_6; }
	inline Vector3_t2243707580 * get_address_of_m_endrotation_6() { return &___m_endrotation_6; }
	inline void set_m_endrotation_6(Vector3_t2243707580  value)
	{
		___m_endrotation_6 = value;
	}

	inline static int32_t get_offset_of_m_defaultCamPosition_7() { return static_cast<int32_t>(offsetof(CamManagerScript_t3879457317, ___m_defaultCamPosition_7)); }
	inline Vector3_t2243707580  get_m_defaultCamPosition_7() const { return ___m_defaultCamPosition_7; }
	inline Vector3_t2243707580 * get_address_of_m_defaultCamPosition_7() { return &___m_defaultCamPosition_7; }
	inline void set_m_defaultCamPosition_7(Vector3_t2243707580  value)
	{
		___m_defaultCamPosition_7 = value;
	}

	inline static int32_t get_offset_of_m_defaultCamRotation_8() { return static_cast<int32_t>(offsetof(CamManagerScript_t3879457317, ___m_defaultCamRotation_8)); }
	inline Vector3_t2243707580  get_m_defaultCamRotation_8() const { return ___m_defaultCamRotation_8; }
	inline Vector3_t2243707580 * get_address_of_m_defaultCamRotation_8() { return &___m_defaultCamRotation_8; }
	inline void set_m_defaultCamRotation_8(Vector3_t2243707580  value)
	{
		___m_defaultCamRotation_8 = value;
	}

	inline static int32_t get_offset_of_m_broomsStartingPosition_9() { return static_cast<int32_t>(offsetof(CamManagerScript_t3879457317, ___m_broomsStartingPosition_9)); }
	inline Vector3_t2243707580  get_m_broomsStartingPosition_9() const { return ___m_broomsStartingPosition_9; }
	inline Vector3_t2243707580 * get_address_of_m_broomsStartingPosition_9() { return &___m_broomsStartingPosition_9; }
	inline void set_m_broomsStartingPosition_9(Vector3_t2243707580  value)
	{
		___m_broomsStartingPosition_9 = value;
	}

	inline static int32_t get_offset_of_m_broomsOffset_10() { return static_cast<int32_t>(offsetof(CamManagerScript_t3879457317, ___m_broomsOffset_10)); }
	inline Vector3_t2243707580  get_m_broomsOffset_10() const { return ___m_broomsOffset_10; }
	inline Vector3_t2243707580 * get_address_of_m_broomsOffset_10() { return &___m_broomsOffset_10; }
	inline void set_m_broomsOffset_10(Vector3_t2243707580  value)
	{
		___m_broomsOffset_10 = value;
	}
};

struct CamManagerScript_t3879457317_StaticFields
{
public:
	// CamManagerScript CamManagerScript::instance
	CamManagerScript_t3879457317 * ___instance_2;

public:
	inline static int32_t get_offset_of_instance_2() { return static_cast<int32_t>(offsetof(CamManagerScript_t3879457317_StaticFields, ___instance_2)); }
	inline CamManagerScript_t3879457317 * get_instance_2() const { return ___instance_2; }
	inline CamManagerScript_t3879457317 ** get_address_of_instance_2() { return &___instance_2; }
	inline void set_instance_2(CamManagerScript_t3879457317 * value)
	{
		___instance_2 = value;
		Il2CppCodeGenWriteBarrier(&___instance_2, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
