#include "telemetry.h"

std::unique_ptr<Telemetry> Telemetry::instance = nullptr;

void Telemetry::Init()
{
	instance.reset(new Telemetry());

}

Telemetry* Telemetry::Instance()
{
	return instance.get();
}

void Telemetry::Release()
{
	instance.reset(nullptr);

}

int Telemetry::trackEvent()
{
	return 68;
}

void Telemetry::setup()
{
}

void Telemetry::close()
{
}