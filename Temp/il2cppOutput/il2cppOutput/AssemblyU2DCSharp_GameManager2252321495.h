#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// GameManager
struct GameManager_t2252321495;
// System.Collections.Generic.List`1<UnityEngine.GameObject>
struct List_1_t1125654279;
// UnityEngine.GameObject
struct GameObject_t1756533147;
// UnityEngine.Sprite
struct Sprite_t309593783;

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// GameManager
struct  GameManager_t2252321495  : public MonoBehaviour_t1158329972
{
public:
	// System.Collections.Generic.List`1<UnityEngine.GameObject> GameManager::m_stones
	List_1_t1125654279 * ___m_stones_3;
	// UnityEngine.GameObject GameManager::m_transitionImage
	GameObject_t1756533147 * ___m_transitionImage_4;
	// UnityEngine.Sprite GameManager::m_sound
	Sprite_t309593783 * ___m_sound_5;
	// UnityEngine.Sprite GameManager::m_mute
	Sprite_t309593783 * ___m_mute_6;
	// UnityEngine.Sprite GameManager::m_pause
	Sprite_t309593783 * ___m_pause_7;
	// UnityEngine.Sprite GameManager::m_unpause
	Sprite_t309593783 * ___m_unpause_8;

public:
	inline static int32_t get_offset_of_m_stones_3() { return static_cast<int32_t>(offsetof(GameManager_t2252321495, ___m_stones_3)); }
	inline List_1_t1125654279 * get_m_stones_3() const { return ___m_stones_3; }
	inline List_1_t1125654279 ** get_address_of_m_stones_3() { return &___m_stones_3; }
	inline void set_m_stones_3(List_1_t1125654279 * value)
	{
		___m_stones_3 = value;
		Il2CppCodeGenWriteBarrier(&___m_stones_3, value);
	}

	inline static int32_t get_offset_of_m_transitionImage_4() { return static_cast<int32_t>(offsetof(GameManager_t2252321495, ___m_transitionImage_4)); }
	inline GameObject_t1756533147 * get_m_transitionImage_4() const { return ___m_transitionImage_4; }
	inline GameObject_t1756533147 ** get_address_of_m_transitionImage_4() { return &___m_transitionImage_4; }
	inline void set_m_transitionImage_4(GameObject_t1756533147 * value)
	{
		___m_transitionImage_4 = value;
		Il2CppCodeGenWriteBarrier(&___m_transitionImage_4, value);
	}

	inline static int32_t get_offset_of_m_sound_5() { return static_cast<int32_t>(offsetof(GameManager_t2252321495, ___m_sound_5)); }
	inline Sprite_t309593783 * get_m_sound_5() const { return ___m_sound_5; }
	inline Sprite_t309593783 ** get_address_of_m_sound_5() { return &___m_sound_5; }
	inline void set_m_sound_5(Sprite_t309593783 * value)
	{
		___m_sound_5 = value;
		Il2CppCodeGenWriteBarrier(&___m_sound_5, value);
	}

	inline static int32_t get_offset_of_m_mute_6() { return static_cast<int32_t>(offsetof(GameManager_t2252321495, ___m_mute_6)); }
	inline Sprite_t309593783 * get_m_mute_6() const { return ___m_mute_6; }
	inline Sprite_t309593783 ** get_address_of_m_mute_6() { return &___m_mute_6; }
	inline void set_m_mute_6(Sprite_t309593783 * value)
	{
		___m_mute_6 = value;
		Il2CppCodeGenWriteBarrier(&___m_mute_6, value);
	}

	inline static int32_t get_offset_of_m_pause_7() { return static_cast<int32_t>(offsetof(GameManager_t2252321495, ___m_pause_7)); }
	inline Sprite_t309593783 * get_m_pause_7() const { return ___m_pause_7; }
	inline Sprite_t309593783 ** get_address_of_m_pause_7() { return &___m_pause_7; }
	inline void set_m_pause_7(Sprite_t309593783 * value)
	{
		___m_pause_7 = value;
		Il2CppCodeGenWriteBarrier(&___m_pause_7, value);
	}

	inline static int32_t get_offset_of_m_unpause_8() { return static_cast<int32_t>(offsetof(GameManager_t2252321495, ___m_unpause_8)); }
	inline Sprite_t309593783 * get_m_unpause_8() const { return ___m_unpause_8; }
	inline Sprite_t309593783 ** get_address_of_m_unpause_8() { return &___m_unpause_8; }
	inline void set_m_unpause_8(Sprite_t309593783 * value)
	{
		___m_unpause_8 = value;
		Il2CppCodeGenWriteBarrier(&___m_unpause_8, value);
	}
};

struct GameManager_t2252321495_StaticFields
{
public:
	// GameManager GameManager::instance
	GameManager_t2252321495 * ___instance_2;

public:
	inline static int32_t get_offset_of_instance_2() { return static_cast<int32_t>(offsetof(GameManager_t2252321495_StaticFields, ___instance_2)); }
	inline GameManager_t2252321495 * get_instance_2() const { return ___instance_2; }
	inline GameManager_t2252321495 ** get_address_of_instance_2() { return &___instance_2; }
	inline void set_instance_2(GameManager_t2252321495 * value)
	{
		___instance_2 = value;
		Il2CppCodeGenWriteBarrier(&___instance_2, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
