#include "FontClass.h"
#include "TextureClass.h"
#include "../Resources/ResourceCache.h"
#include <sstream>
#include <vector>

const float FontClass::FontKerning = 3.0f;

FontClass::FontClass()
{
	m_pFont = 0;
	m_pTexture = 0;
}

FontClass::~FontClass()
{
	SAFE_DELETE(m_pTexture);

	SAFE_DELETE_ARRAY(m_pFont);
}

bool FontClass::Initialize(ID3D11Device* device, std::string fontFilename, std::string textureFilename)
{
	if (!LoadFontData(fontFilename.c_str()))
	{
		return false;
	}

	if (!LoadTexture(device, textureFilename.c_str()))
	{
		return false;
	}

	return true;
}

bool FontClass::LoadFontData(const char* filename)
{
	int i = 0;
	char temp;

	m_pFont = BE_NEW FontType[95];
	if (!m_pFont)
	{
		return false;
	}

	//Compile Pixel Shader
	Resource fontRes(filename);
	ResourceHandle* pFontResHandle = g_pApp->m_pResourceCache->GetHandle(&fontRes);

	std::stringstream ss(pFontResHandle->Buffer());
	std::string row;
	while (std::getline(ss, row))
	{
		std::stringstream subss(row);
		subss.get(temp);
		while (temp != ' ')
		{
			subss.get(temp);
		}
		subss.get(temp);
		while (temp != ' ')
		{
			subss.get(temp);
		}

		subss >> m_pFont[i].left;
		subss >> m_pFont[i].right;
		subss >> m_pFont[i].size;
		i++;
	}

	return true;
}

void FontClass::ReleaseFontData()
{
}

bool FontClass::LoadTexture(ID3D11Device* device, std::string filename)
{
	m_pTexture = BE_NEW TextureClass;
	if (!m_pTexture)
	{
		return false;
	}

	if (!m_pTexture->Initialize(device, filename))
	{
		return false;
	}

	return true;
}

ID3D11ShaderResourceView* FontClass::GetTexture()
{
	return m_pTexture->GetTexture();
}

void FontClass::BuildVertexArray(void* vertices, const char* text, float drawX, float drawY)
{
	VertexType* vertexPtr;
	int numLetters, index, i, letter;

	vertexPtr = static_cast<VertexType*> (vertices);

	numLetters = static_cast<int>(strlen(text));

	index = 0;

	for (i = 0; i < numLetters; i++)
	{
		letter = static_cast<int>(text[i]) - 32;

		if (letter == 0)
		{
			drawX = drawX + 3.0f;
		}
		else
		{
			vertexPtr[index].position = XMFLOAT3(drawX, drawY, 0.0f);
			vertexPtr[index].texture = XMFLOAT2(m_pFont[letter].left, 0.0f);
			index++;

			vertexPtr[index].position = XMFLOAT3(drawX + m_pFont[letter].size, drawY - 16, 0.0f);
			vertexPtr[index].texture = XMFLOAT2(m_pFont[letter].right, 1.0f);
			index++;

			vertexPtr[index].position = XMFLOAT3(drawX, drawY - 16, 0.0f);
			vertexPtr[index].texture = XMFLOAT2(m_pFont[letter].left, 1.0f);
			index++;

			vertexPtr[index].position = XMFLOAT3(drawX, drawY, 0.0f);
			vertexPtr[index].texture = XMFLOAT2(m_pFont[letter].left, 0.0f);
			index++;

			vertexPtr[index].position = XMFLOAT3(drawX + m_pFont[letter].size, drawY, 0.0f);
			vertexPtr[index].texture = XMFLOAT2(m_pFont[letter].right, 0.0f);
			index++;

			vertexPtr[index].position = XMFLOAT3(drawX + m_pFont[letter].size, drawY - 16, 0.0f);
			vertexPtr[index].texture = XMFLOAT2(m_pFont[letter].right, 1.0f);
			index++;

			drawX = drawX + m_pFont[letter].size + FontClass::FontKerning;
		}
	}
}