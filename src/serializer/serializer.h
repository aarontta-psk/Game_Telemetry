#ifndef SERIALIZER_H_
#define SERIALIZER_H_

#include <macros.h>

class Event;

class dll_export Serializer {
public:
	Serializer() = default;
	virtual ~Serializer() = default;

	virtual void serialize() = 0;
};
#endif // SERIALIZER_H_