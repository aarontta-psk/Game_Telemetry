#include <macros.h>

#include <telemetry/telemetry.h>

extern "C" {
	dll_export void telemetry_initialization() {
		Telemetry::Init();
	}

	dll_export int telemetry_track_event() {
		return Telemetry::Instance()->trackEvent();
	}

	dll_export void telemetry_release() {
		Telemetry::Release();
	}
}