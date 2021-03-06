#pragma once

#include "ResourceCache.h"

class XmlResourceExtraData : public IResourceExtraData
{
	rapidxml::xml_document<> m_xmlDocument;
	char* m_pRawBuffer;

public:
	virtual void Shutdown();

	virtual std::string VToString() { return "XmlResourceExtraData"; }
	void ParseXml(char* pRawBuffer);
	rapidxml::xml_node<>* GetRoot(void);
};


//Loads xml files from resource Cache
class XmlResourceLoader : public IResourceLoader
{
public:

	virtual bool VUseRawFile() { return false; }
	virtual bool VDiscardRawBufferAfterLoad() { return false; }
	virtual unsigned int VGetLoadedResourceSize(char *rawBuffer, unsigned int rawSize) { return rawSize; }
	virtual bool VLoadResource(char *rawBuffer, unsigned int rawSize, ResourceHandle* handle);
	virtual std::vector<std::string> VGetPatterns() { return std::vector<std::string>({ "*.xml", "*.bmap" }); }
	virtual bool VAddNullZero() { return true; }

	static rapidxml::xml_node<>* LoadAndReturnRootXmlElement(const char* resourceString);
};