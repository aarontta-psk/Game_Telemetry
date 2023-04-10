#include "event.h"

#include <chrono>

Event::Event()
{
	eventType = EventType::DEFAULT;
	sessionID = -1;
	eventID = -1;
	timestamp = -1;
}

Event::Event(EventType type, uint32_t sessID)
{
	eventType = type;
	sessionID = sessID;
	timestamp = time(nullptr);
	eventID = timestamp;
}