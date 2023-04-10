#ifndef EVENT_H_
#define EVENT_H_

#include <stdint.h>

#include <macros.h>

class dll_export Event {
public:
	enum class EventType : uint32_t { DEFAULT, NOT_DEFAULT };

	Event();
	Event(EventType type, uint32_t sessID);
	virtual ~Event() = default;

protected:
	EventType eventType;
	uint32_t sessionID;
	uint32_t eventID;
	uint64_t timestamp;
};
#endif // EVENT_H_