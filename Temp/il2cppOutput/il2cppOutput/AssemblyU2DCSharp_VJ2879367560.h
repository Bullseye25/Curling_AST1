#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// VJ
struct VJ_t2879367560;
// UnityEngine.UI.Image
struct Image_t2042527209;
// UnityEngine.Animator
struct Animator_t69676727;
// UnityEngine.GameObject
struct GameObject_t1756533147;

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"
#include "UnityEngine_UnityEngine_Vector32243707580.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// VJ
struct  VJ_t2879367560  : public MonoBehaviour_t1158329972
{
public:
	// System.Single VJ::m_sweepingForce
	float ___m_sweepingForce_3;
	// UnityEngine.UI.Image VJ::m_bgImg
	Image_t2042527209 * ___m_bgImg_4;
	// UnityEngine.UI.Image VJ::m_arrowImage
	Image_t2042527209 * ___m_arrowImage_5;
	// UnityEngine.Vector3 VJ::m_inputVector
	Vector3_t2243707580  ___m_inputVector_6;
	// System.Boolean VJ::m_takingTarget
	bool ___m_takingTarget_7;
	// UnityEngine.Animator VJ::m_broomAnimator
	Animator_t69676727 * ___m_broomAnimator_8;
	// UnityEngine.GameObject VJ::m_home
	GameObject_t1756533147 * ___m_home_9;
	// System.Single VJ::x
	float ___x_10;
	// System.Single VJ::y
	float ___y_11;
	// System.Single VJ::m_userInterface
	float ___m_userInterface_12;
	// System.Single VJ::m_arrowHeight
	float ___m_arrowHeight_13;

public:
	inline static int32_t get_offset_of_m_sweepingForce_3() { return static_cast<int32_t>(offsetof(VJ_t2879367560, ___m_sweepingForce_3)); }
	inline float get_m_sweepingForce_3() const { return ___m_sweepingForce_3; }
	inline float* get_address_of_m_sweepingForce_3() { return &___m_sweepingForce_3; }
	inline void set_m_sweepingForce_3(float value)
	{
		___m_sweepingForce_3 = value;
	}

	inline static int32_t get_offset_of_m_bgImg_4() { return static_cast<int32_t>(offsetof(VJ_t2879367560, ___m_bgImg_4)); }
	inline Image_t2042527209 * get_m_bgImg_4() const { return ___m_bgImg_4; }
	inline Image_t2042527209 ** get_address_of_m_bgImg_4() { return &___m_bgImg_4; }
	inline void set_m_bgImg_4(Image_t2042527209 * value)
	{
		___m_bgImg_4 = value;
		Il2CppCodeGenWriteBarrier(&___m_bgImg_4, value);
	}

	inline static int32_t get_offset_of_m_arrowImage_5() { return static_cast<int32_t>(offsetof(VJ_t2879367560, ___m_arrowImage_5)); }
	inline Image_t2042527209 * get_m_arrowImage_5() const { return ___m_arrowImage_5; }
	inline Image_t2042527209 ** get_address_of_m_arrowImage_5() { return &___m_arrowImage_5; }
	inline void set_m_arrowImage_5(Image_t2042527209 * value)
	{
		___m_arrowImage_5 = value;
		Il2CppCodeGenWriteBarrier(&___m_arrowImage_5, value);
	}

	inline static int32_t get_offset_of_m_inputVector_6() { return static_cast<int32_t>(offsetof(VJ_t2879367560, ___m_inputVector_6)); }
	inline Vector3_t2243707580  get_m_inputVector_6() const { return ___m_inputVector_6; }
	inline Vector3_t2243707580 * get_address_of_m_inputVector_6() { return &___m_inputVector_6; }
	inline void set_m_inputVector_6(Vector3_t2243707580  value)
	{
		___m_inputVector_6 = value;
	}

	inline static int32_t get_offset_of_m_takingTarget_7() { return static_cast<int32_t>(offsetof(VJ_t2879367560, ___m_takingTarget_7)); }
	inline bool get_m_takingTarget_7() const { return ___m_takingTarget_7; }
	inline bool* get_address_of_m_takingTarget_7() { return &___m_takingTarget_7; }
	inline void set_m_takingTarget_7(bool value)
	{
		___m_takingTarget_7 = value;
	}

	inline static int32_t get_offset_of_m_broomAnimator_8() { return static_cast<int32_t>(offsetof(VJ_t2879367560, ___m_broomAnimator_8)); }
	inline Animator_t69676727 * get_m_broomAnimator_8() const { return ___m_broomAnimator_8; }
	inline Animator_t69676727 ** get_address_of_m_broomAnimator_8() { return &___m_broomAnimator_8; }
	inline void set_m_broomAnimator_8(Animator_t69676727 * value)
	{
		___m_broomAnimator_8 = value;
		Il2CppCodeGenWriteBarrier(&___m_broomAnimator_8, value);
	}

	inline static int32_t get_offset_of_m_home_9() { return static_cast<int32_t>(offsetof(VJ_t2879367560, ___m_home_9)); }
	inline GameObject_t1756533147 * get_m_home_9() const { return ___m_home_9; }
	inline GameObject_t1756533147 ** get_address_of_m_home_9() { return &___m_home_9; }
	inline void set_m_home_9(GameObject_t1756533147 * value)
	{
		___m_home_9 = value;
		Il2CppCodeGenWriteBarrier(&___m_home_9, value);
	}

	inline static int32_t get_offset_of_x_10() { return static_cast<int32_t>(offsetof(VJ_t2879367560, ___x_10)); }
	inline float get_x_10() const { return ___x_10; }
	inline float* get_address_of_x_10() { return &___x_10; }
	inline void set_x_10(float value)
	{
		___x_10 = value;
	}

	inline static int32_t get_offset_of_y_11() { return static_cast<int32_t>(offsetof(VJ_t2879367560, ___y_11)); }
	inline float get_y_11() const { return ___y_11; }
	inline float* get_address_of_y_11() { return &___y_11; }
	inline void set_y_11(float value)
	{
		___y_11 = value;
	}

	inline static int32_t get_offset_of_m_userInterface_12() { return static_cast<int32_t>(offsetof(VJ_t2879367560, ___m_userInterface_12)); }
	inline float get_m_userInterface_12() const { return ___m_userInterface_12; }
	inline float* get_address_of_m_userInterface_12() { return &___m_userInterface_12; }
	inline void set_m_userInterface_12(float value)
	{
		___m_userInterface_12 = value;
	}

	inline static int32_t get_offset_of_m_arrowHeight_13() { return static_cast<int32_t>(offsetof(VJ_t2879367560, ___m_arrowHeight_13)); }
	inline float get_m_arrowHeight_13() const { return ___m_arrowHeight_13; }
	inline float* get_address_of_m_arrowHeight_13() { return &___m_arrowHeight_13; }
	inline void set_m_arrowHeight_13(float value)
	{
		___m_arrowHeight_13 = value;
	}
};

struct VJ_t2879367560_StaticFields
{
public:
	// VJ VJ::instance
	VJ_t2879367560 * ___instance_2;

public:
	inline static int32_t get_offset_of_instance_2() { return static_cast<int32_t>(offsetof(VJ_t2879367560_StaticFields, ___instance_2)); }
	inline VJ_t2879367560 * get_instance_2() const { return ___instance_2; }
	inline VJ_t2879367560 ** get_address_of_instance_2() { return &___instance_2; }
	inline void set_instance_2(VJ_t2879367560 * value)
	{
		___instance_2 = value;
		Il2CppCodeGenWriteBarrier(&___instance_2, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
