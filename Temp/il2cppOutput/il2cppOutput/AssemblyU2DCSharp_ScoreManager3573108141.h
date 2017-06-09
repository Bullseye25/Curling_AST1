#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// ScoreManager
struct ScoreManager_t3573108141;
// UnityEngine.UI.Text
struct Text_t356221433;
// System.Collections.Generic.List`1<UnityEngine.GameObject>
struct List_1_t1125654279;

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// ScoreManager
struct  ScoreManager_t3573108141  : public MonoBehaviour_t1158329972
{
public:
	// System.Single ScoreManager::m_radiusSize
	float ___m_radiusSize_3;
	// UnityEngine.UI.Text ScoreManager::m_p1Score
	Text_t356221433 * ___m_p1Score_4;
	// UnityEngine.UI.Text ScoreManager::m_p2Score
	Text_t356221433 * ___m_p2Score_5;
	// System.Collections.Generic.List`1<UnityEngine.GameObject> ScoreManager::list
	List_1_t1125654279 * ___list_6;

public:
	inline static int32_t get_offset_of_m_radiusSize_3() { return static_cast<int32_t>(offsetof(ScoreManager_t3573108141, ___m_radiusSize_3)); }
	inline float get_m_radiusSize_3() const { return ___m_radiusSize_3; }
	inline float* get_address_of_m_radiusSize_3() { return &___m_radiusSize_3; }
	inline void set_m_radiusSize_3(float value)
	{
		___m_radiusSize_3 = value;
	}

	inline static int32_t get_offset_of_m_p1Score_4() { return static_cast<int32_t>(offsetof(ScoreManager_t3573108141, ___m_p1Score_4)); }
	inline Text_t356221433 * get_m_p1Score_4() const { return ___m_p1Score_4; }
	inline Text_t356221433 ** get_address_of_m_p1Score_4() { return &___m_p1Score_4; }
	inline void set_m_p1Score_4(Text_t356221433 * value)
	{
		___m_p1Score_4 = value;
		Il2CppCodeGenWriteBarrier(&___m_p1Score_4, value);
	}

	inline static int32_t get_offset_of_m_p2Score_5() { return static_cast<int32_t>(offsetof(ScoreManager_t3573108141, ___m_p2Score_5)); }
	inline Text_t356221433 * get_m_p2Score_5() const { return ___m_p2Score_5; }
	inline Text_t356221433 ** get_address_of_m_p2Score_5() { return &___m_p2Score_5; }
	inline void set_m_p2Score_5(Text_t356221433 * value)
	{
		___m_p2Score_5 = value;
		Il2CppCodeGenWriteBarrier(&___m_p2Score_5, value);
	}

	inline static int32_t get_offset_of_list_6() { return static_cast<int32_t>(offsetof(ScoreManager_t3573108141, ___list_6)); }
	inline List_1_t1125654279 * get_list_6() const { return ___list_6; }
	inline List_1_t1125654279 ** get_address_of_list_6() { return &___list_6; }
	inline void set_list_6(List_1_t1125654279 * value)
	{
		___list_6 = value;
		Il2CppCodeGenWriteBarrier(&___list_6, value);
	}
};

struct ScoreManager_t3573108141_StaticFields
{
public:
	// ScoreManager ScoreManager::instance
	ScoreManager_t3573108141 * ___instance_2;

public:
	inline static int32_t get_offset_of_instance_2() { return static_cast<int32_t>(offsetof(ScoreManager_t3573108141_StaticFields, ___instance_2)); }
	inline ScoreManager_t3573108141 * get_instance_2() const { return ___instance_2; }
	inline ScoreManager_t3573108141 ** get_address_of_instance_2() { return &___instance_2; }
	inline void set_instance_2(ScoreManager_t3573108141 * value)
	{
		___instance_2 = value;
		Il2CppCodeGenWriteBarrier(&___instance_2, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
