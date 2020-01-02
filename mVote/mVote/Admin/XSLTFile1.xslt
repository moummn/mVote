<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="xml" indent="yes"/>

    <xsl:template match="data">
        <xsl:copy>
            <xsl:apply-templates select="dataitem"/>
        </xsl:copy>
    </xsl:template>
    <xsl:template match="dataitem">
      <dataitem>
        <xsl:attribute name="项目ID">
          <xsl:value-of select="id"/>
        </xsl:attribute>
        <xsl:attribute name="创建日期">
          <xsl:value-of select="addtime"/>
        </xsl:attribute>
        <xsl:attribute name="项目名称">
          <xsl:value-of select="vname"/>
        </xsl:attribute>
      </dataitem>
        
    </xsl:template>
</xsl:stylesheet>
