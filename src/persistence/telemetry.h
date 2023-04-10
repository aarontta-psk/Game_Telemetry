#ifndef TELEMETRY_H_
#define TELEMETRY_H_

#include <string>
#include <memory>

#include <macros.h>

class dll_export Telemetry {
public:
	virtual ~Telemetry() = default;

	static Telemetry* Instance();

	static void Init();
	static void Release();
	
	int trackEvent();

private:
	static std::unique_ptr<Telemetry> instance;

	Telemetry() = default;

	void setup();
	void close();
};
#endif // TELEMETRY_H_