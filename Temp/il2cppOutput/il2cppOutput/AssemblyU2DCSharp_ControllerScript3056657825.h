#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// ControllerScript
struct ControllerScript_t3056657825;
// UnityEngine.GameObject
struct GameObject_t1756533147;
// UnityEngine.Material
struct Material_t193706927;
// UnityEngine.LineRenderer
struct LineRenderer_t849157671;
// UnityEngine.Transform
struct Transform_t3275118058;
// UnityEngine.Vector3[]
struct Vector3U5BU5D_t1172311765;
// UnityEngine.MeshCollider
struct MeshCollider_t2718867283;
// UnityEngine.Rigidbody
struct Rigidbody_t4233889191;
// UnityEngine.UI.Slider
struct Slider_t297367283;
// UnityEngine.Renderer
struct Renderer_t257310565;

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"
#include "UnityEngine_UnityEngine_Vector32243707580.h"
#include "UnityEngine_UnityEngine_Color2020392075.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// ControllerScript
struct  ControllerScript_t3056657825  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.GameObject ControllerScript::m_fakeStone
	GameObject_t1756533147 * ___m_fakeStone_3;
	// UnityEngine.Material ControllerScript::m_arrowMaterial
	Material_t193706927 * ___m_arrowMaterial_4;
	// UnityEngine.LineRenderer ControllerScript::m_arrow
	LineRenderer_t849157671 * ___m_arrow_5;
	// UnityEngine.Transform ControllerScript::m_arrowStartingPoint
	Transform_t3275118058 * ___m_arrowStartingPoint_6;
	// UnityEngine.Vector3[] ControllerScript::m_points
	Vector3U5BU5D_t1172311765* ___m_points_7;
	// UnityEngine.Vector3 ControllerScript::m_targetDir
	Vector3_t2243707580  ___m_targetDir_8;
	// UnityEngine.Vector3 ControllerScript::m_dir
	Vector3_t2243707580  ___m_dir_9;
	// UnityEngine.Vector3 ControllerScript::m_defaultStonePosition
	Vector3_t2243707580  ___m_defaultStonePosition_10;
	// UnityEngine.Vector3 ControllerScript::m_defaultStoneRotation
	Vector3_t2243707580  ___m_defaultStoneRotation_11;
	// UnityEngine.MeshCollider ControllerScript::m_collider
	MeshCollider_t2718867283 * ___m_collider_12;
	// UnityEngine.GameObject ControllerScript::m_brooms
	GameObject_t1756533147 * ___m_brooms_13;
	// UnityEngine.Rigidbody ControllerScript::m_rigidbody
	Rigidbody_t4233889191 * ___m_rigidbody_14;
	// System.Single ControllerScript::m_maxForce
	float ___m_maxForce_15;
	// System.Single ControllerScript::m_minForce
	float ___m_minForce_16;
	// System.Single ControllerScript::m_arrowRotationSpeed
	float ___m_arrowRotationSpeed_17;
	// System.Single ControllerScript::m_curlingDiraction
	float ___m_curlingDiraction_18;
	// System.Single ControllerScript::m_curlingForce
	float ___m_curlingForce_19;
	// System.Boolean ControllerScript::m_stoneClone
	bool ___m_stoneClone_20;
	// System.Boolean ControllerScript::m_doCurling
	bool ___m_doCurling_21;
	// UnityEngine.UI.Slider ControllerScript::m_curlingSlider
	Slider_t297367283 * ___m_curlingSlider_22;
	// UnityEngine.Color ControllerScript::m_belowAverageSpeed
	Color_t2020392075  ___m_belowAverageSpeed_23;
	// UnityEngine.Color ControllerScript::m_averageSpeed
	Color_t2020392075  ___m_averageSpeed_24;
	// UnityEngine.Color ControllerScript::m_aboveAverageSpeed
	Color_t2020392075  ___m_aboveAverageSpeed_25;
	// UnityEngine.Material ControllerScript::m_m1
	Material_t193706927 * ___m_m1_26;
	// UnityEngine.Material ControllerScript::m_m2
	Material_t193706927 * ___m_m2_27;
	// UnityEngine.Renderer ControllerScript::m_ren
	Renderer_t257310565 * ___m_ren_28;

public:
	inline static int32_t get_offset_of_m_fakeStone_3() { return static_cast<int32_t>(offsetof(ControllerScript_t3056657825, ___m_fakeStone_3)); }
	inline GameObject_t1756533147 * get_m_fakeStone_3() const { return ___m_fakeStone_3; }
	inline GameObject_t1756533147 ** get_address_of_m_fakeStone_3() { return &___m_fakeStone_3; }
	inline void set_m_fakeStone_3(GameObject_t1756533147 * value)
	{
		___m_fakeStone_3 = value;
		Il2CppCodeGenWriteBarrier(&___m_fakeStone_3, value);
	}

	inline static int32_t get_offset_of_m_arrowMaterial_4() { return static_cast<int32_t>(offsetof(ControllerScript_t3056657825, ___m_arrowMaterial_4)); }
	inline Material_t193706927 * get_m_arrowMaterial_4() const { return ___m_arrowMaterial_4; }
	inline Material_t193706927 ** get_address_of_m_arrowMaterial_4() { return &___m_arrowMaterial_4; }
	inline void set_m_arrowMaterial_4(Material_t193706927 * value)
	{
		___m_arrowMaterial_4 = value;
		Il2CppCodeGenWriteBarrier(&___m_arrowMaterial_4, value);
	}

	inline static int32_t get_offset_of_m_arrow_5() { return static_cast<int32_t>(offsetof(ControllerScript_t3056657825, ___m_arrow_5)); }
	inline LineRenderer_t849157671 * get_m_arrow_5() const { return ___m_arrow_5; }
	inline LineRenderer_t849157671 ** get_address_of_m_arrow_5() { return &___m_arrow_5; }
	inline void set_m_arrow_5(LineRenderer_t849157671 * value)
	{
		___m_arrow_5 = value;
		Il2CppCodeGenWriteBarrier(&___m_arrow_5, value);
	}

	inline static int32_t get_offset_of_m_arrowStartingPoint_6() { return static_cast<int32_t>(offsetof(ControllerScript_t3056657825, ___m_arrowStartingPoint_6)); }
	inline Transform_t3275118058 * get_m_arrowStartingPoint_6() const { return ___m_arrowStartingPoint_6; }
	inline Transform_t3275118058 ** get_address_of_m_arrowStartingPoint_6() { return &___m_arrowStartingPoint_6; }
	inline void set_m_arrowStartingPoint_6(Transform_t3275118058 * value)
	{
		___m_arrowStartingPoint_6 = value;
		Il2CppCodeGenWriteBarrier(&___m_arrowStartingPoint_6, value);
	}

	inline static int32_t get_offset_of_m_points_7() { return static_cast<int32_t>(offsetof(ControllerScript_t3056657825, ___m_points_7)); }
	inline Vector3U5BU5D_t1172311765* get_m_points_7() const { return ___m_points_7; }
	inline Vector3U5BU5D_t1172311765** get_address_of_m_points_7() { return &___m_points_7; }
	inline void set_m_points_7(Vector3U5BU5D_t1172311765* value)
	{
		___m_points_7 = value;
		Il2CppCodeGenWriteBarrier(&___m_points_7, value);
	}

	inline static int32_t get_offset_of_m_targetDir_8() { return static_cast<int32_t>(offsetof(ControllerScript_t3056657825, ___m_targetDir_8)); }
	inline Vector3_t2243707580  get_m_targetDir_8() const { return ___m_targetDir_8; }
	inline Vector3_t2243707580 * get_address_of_m_targetDir_8() { return &___m_targetDir_8; }
	inline void set_m_targetDir_8(Vector3_t2243707580  value)
	{
		___m_targetDir_8 = value;
	}

	inline static int32_t get_offset_of_m_dir_9() { return static_cast<int32_t>(offsetof(ControllerScript_t3056657825, ___m_dir_9)); }
	inline Vector3_t2243707580  get_m_dir_9() const { return ___m_dir_9; }
	inline Vector3_t2243707580 * get_address_of_m_dir_9() { return &___m_dir_9; }
	inline void set_m_dir_9(Vector3_t2243707580  value)
	{
		___m_dir_9 = value;
	}

	inline static int32_t get_offset_of_m_defaultStonePosition_10() { return static_cast<int32_t>(offsetof(ControllerScript_t3056657825, ___m_defaultStonePosition_10)); }
	inline Vector3_t2243707580  get_m_defaultStonePosition_10() const { return ___m_defaultStonePosition_10; }
	inline Vector3_t2243707580 * get_address_of_m_defaultStonePosition_10() { return &___m_defaultStonePosition_10; }
	inline void set_m_defaultStonePosition_10(Vector3_t2243707580  value)
	{
		___m_defaultStonePosition_10 = value;
	}

	inline static int32_t get_offset_of_m_defaultStoneRotation_11() { return static_cast<int32_t>(offsetof(ControllerScript_t3056657825, ___m_defaultStoneRotation_11)); }
	inline Vector3_t2243707580  get_m_defaultStoneRotation_11() const { return ___m_defaultStoneRotation_11; }
	inline Vector3_t2243707580 * get_address_of_m_defaultStoneRotation_11() { return &___m_defaultStoneRotation_11; }
	inline void set_m_defaultStoneRotation_11(Vector3_t2243707580  value)
	{
		___m_defaultStoneRotation_11 = value;
	}

	inline static int32_t get_offset_of_m_collider_12() { return static_cast<int32_t>(offsetof(ControllerScript_t3056657825, ___m_collider_12)); }
	inline MeshCollider_t2718867283 * get_m_collider_12() const { return ___m_collider_12; }
	inline MeshCollider_t2718867283 ** get_address_of_m_collider_12() { return &___m_collider_12; }
	inline void set_m_collider_12(MeshCollider_t2718867283 * value)
	{
		___m_collider_12 = value;
		Il2CppCodeGenWriteBarrier(&___m_collider_12, value);
	}

	inline static int32_t get_offset_of_m_brooms_13() { return static_cast<int32_t>(offsetof(ControllerScript_t3056657825, ___m_brooms_13)); }
	inline GameObject_t1756533147 * get_m_brooms_13() const { return ___m_brooms_13; }
	inline GameObject_t1756533147 ** get_address_of_m_brooms_13() { return &___m_brooms_13; }
	inline void set_m_brooms_13(GameObject_t1756533147 * value)
	{
		___m_brooms_13 = value;
		Il2CppCodeGenWriteBarrier(&___m_brooms_13, value);
	}

	inline static int32_t get_offset_of_m_rigidbody_14() { return static_cast<int32_t>(offsetof(ControllerScript_t3056657825, ___m_rigidbody_14)); }
	inline Rigidbody_t4233889191 * get_m_rigidbody_14() const { return ___m_rigidbody_14; }
	inline Rigidbody_t4233889191 ** get_address_of_m_rigidbody_14() { return &___m_rigidbody_14; }
	inline void set_m_rigidbody_14(Rigidbody_t4233889191 * value)
	{
		___m_rigidbody_14 = value;
		Il2CppCodeGenWriteBarrier(&___m_rigidbody_14, value);
	}

	inline static int32_t get_offset_of_m_maxForce_15() { return static_cast<int32_t>(offsetof(ControllerScript_t3056657825, ___m_maxForce_15)); }
	inline float get_m_maxForce_15() const { return ___m_maxForce_15; }
	inline float* get_address_of_m_maxForce_15() { return &___m_maxForce_15; }
	inline void set_m_maxForce_15(float value)
	{
		___m_maxForce_15 = value;
	}

	inline static int32_t get_offset_of_m_minForce_16() { return static_cast<int32_t>(offsetof(ControllerScript_t3056657825, ___m_minForce_16)); }
	inline float get_m_minForce_16() const { return ___m_minForce_16; }
	inline float* get_address_of_m_minForce_16() { return &___m_minForce_16; }
	inline void set_m_minForce_16(float value)
	{
		___m_minForce_16 = value;
	}

	inline static int32_t get_offset_of_m_arrowRotationSpeed_17() { return static_cast<int32_t>(offsetof(ControllerScript_t3056657825, ___m_arrowRotationSpeed_17)); }
	inline float get_m_arrowRotationSpeed_17() const { return ___m_arrowRotationSpeed_17; }
	inline float* get_address_of_m_arrowRotationSpeed_17() { return &___m_arrowRotationSpeed_17; }
	inline void set_m_arrowRotationSpeed_17(float value)
	{
		___m_arrowRotationSpeed_17 = value;
	}

	inline static int32_t get_offset_of_m_curlingDiraction_18() { return static_cast<int32_t>(offsetof(ControllerScript_t3056657825, ___m_curlingDiraction_18)); }
	inline float get_m_curlingDiraction_18() const { return ___m_curlingDiraction_18; }
	inline float* get_address_of_m_curlingDiraction_18() { return &___m_curlingDiraction_18; }
	inline void set_m_curlingDiraction_18(float value)
	{
		___m_curlingDiraction_18 = value;
	}

	inline static int32_t get_offset_of_m_curlingForce_19() { return static_cast<int32_t>(offsetof(ControllerScript_t3056657825, ___m_curlingForce_19)); }
	inline float get_m_curlingForce_19() const { return ___m_curlingForce_19; }
	inline float* get_address_of_m_curlingForce_19() { return &___m_curlingForce_19; }
	inline void set_m_curlingForce_19(float value)
	{
		___m_curlingForce_19 = value;
	}

	inline static int32_t get_offset_of_m_stoneClone_20() { return static_cast<int32_t>(offsetof(ControllerScript_t3056657825, ___m_stoneClone_20)); }
	inline bool get_m_stoneClone_20() const { return ___m_stoneClone_20; }
	inline bool* get_address_of_m_stoneClone_20() { return &___m_stoneClone_20; }
	inline void set_m_stoneClone_20(bool value)
	{
		___m_stoneClone_20 = value;
	}

	inline static int32_t get_offset_of_m_doCurling_21() { return static_cast<int32_t>(offsetof(ControllerScript_t3056657825, ___m_doCurling_21)); }
	inline bool get_m_doCurling_21() const { return ___m_doCurling_21; }
	inline bool* get_address_of_m_doCurling_21() { return &___m_doCurling_21; }
	inline void set_m_doCurling_21(bool value)
	{
		___m_doCurling_21 = value;
	}

	inline static int32_t get_offset_of_m_curlingSlider_22() { return static_cast<int32_t>(offsetof(ControllerScript_t3056657825, ___m_curlingSlider_22)); }
	inline Slider_t297367283 * get_m_curlingSlider_22() const { return ___m_curlingSlider_22; }
	inline Slider_t297367283 ** get_address_of_m_curlingSlider_22() { return &___m_curlingSlider_22; }
	inline void set_m_curlingSlider_22(Slider_t297367283 * value)
	{
		___m_curlingSlider_22 = value;
		Il2CppCodeGenWriteBarrier(&___m_curlingSlider_22, value);
	}

	inline static int32_t get_offset_of_m_belowAverageSpeed_23() { return static_cast<int32_t>(offsetof(ControllerScript_t3056657825, ___m_belowAverageSpeed_23)); }
	inline Color_t2020392075  get_m_belowAverageSpeed_23() const { return ___m_belowAverageSpeed_23; }
	inline Color_t2020392075 * get_address_of_m_belowAverageSpeed_23() { return &___m_belowAverageSpeed_23; }
	inline void set_m_belowAverageSpeed_23(Color_t2020392075  value)
	{
		___m_belowAverageSpeed_23 = value;
	}

	inline static int32_t get_offset_of_m_averageSpeed_24() { return static_cast<int32_t>(offsetof(ControllerScript_t3056657825, ___m_averageSpeed_24)); }
	inline Color_t2020392075  get_m_averageSpeed_24() const { return ___m_averageSpeed_24; }
	inline Color_t2020392075 * get_address_of_m_averageSpeed_24() { return &___m_averageSpeed_24; }
	inline void set_m_averageSpeed_24(Color_t2020392075  value)
	{
		___m_averageSpeed_24 = value;
	}

	inline static int32_t get_offset_of_m_aboveAverageSpeed_25() { return static_cast<int32_t>(offsetof(ControllerScript_t3056657825, ___m_aboveAverageSpeed_25)); }
	inline Color_t2020392075  get_m_aboveAverageSpeed_25() const { return ___m_aboveAverageSpeed_25; }
	inline Color_t2020392075 * get_address_of_m_aboveAverageSpeed_25() { return &___m_aboveAverageSpeed_25; }
	inline void set_m_aboveAverageSpeed_25(Color_t2020392075  value)
	{
		___m_aboveAverageSpeed_25 = value;
	}

	inline static int32_t get_offset_of_m_m1_26() { return static_cast<int32_t>(offsetof(ControllerScript_t3056657825, ___m_m1_26)); }
	inline Material_t193706927 * get_m_m1_26() const { return ___m_m1_26; }
	inline Material_t193706927 ** get_address_of_m_m1_26() { return &___m_m1_26; }
	inline void set_m_m1_26(Material_t193706927 * value)
	{
		___m_m1_26 = value;
		Il2CppCodeGenWriteBarrier(&___m_m1_26, value);
	}

	inline static int32_t get_offset_of_m_m2_27() { return static_cast<int32_t>(offsetof(ControllerScript_t3056657825, ___m_m2_27)); }
	inline Material_t193706927 * get_m_m2_27() const { return ___m_m2_27; }
	inline Material_t193706927 ** get_address_of_m_m2_27() { return &___m_m2_27; }
	inline void set_m_m2_27(Material_t193706927 * value)
	{
		___m_m2_27 = value;
		Il2CppCodeGenWriteBarrier(&___m_m2_27, value);
	}

	inline static int32_t get_offset_of_m_ren_28() { return static_cast<int32_t>(offsetof(ControllerScript_t3056657825, ___m_ren_28)); }
	inline Renderer_t257310565 * get_m_ren_28() const { return ___m_ren_28; }
	inline Renderer_t257310565 ** get_address_of_m_ren_28() { return &___m_ren_28; }
	inline void set_m_ren_28(Renderer_t257310565 * value)
	{
		___m_ren_28 = value;
		Il2CppCodeGenWriteBarrier(&___m_ren_28, value);
	}
};

struct ControllerScript_t3056657825_StaticFields
{
public:
	// ControllerScript ControllerScript::instance
	ControllerScript_t3056657825 * ___instance_2;

public:
	inline static int32_t get_offset_of_instance_2() { return static_cast<int32_t>(offsetof(ControllerScript_t3056657825_StaticFields, ___instance_2)); }
	inline ControllerScript_t3056657825 * get_instance_2() const { return ___instance_2; }
	inline ControllerScript_t3056657825 ** get_address_of_instance_2() { return &___instance_2; }
	inline void set_instance_2(ControllerScript_t3056657825 * value)
	{
		___instance_2 = value;
		Il2CppCodeGenWriteBarrier(&___instance_2, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
