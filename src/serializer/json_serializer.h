#ifndef JSONSERIALIZER_H_
#define JSONSERIALIZER_H_

#include <string>
#include <memory>

#include <macros.h>
#include <serializer/serializer.h>

class dll_export JSONSerializer : Serializer {
public:
	JSONSerializer() = default;
	virtual ~JSONSerializer() = default;

	virtual void serialize(Event* event);
};
#endif // SERIALIZER_H_