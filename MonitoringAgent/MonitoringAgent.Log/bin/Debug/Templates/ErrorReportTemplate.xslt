<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl" xmlns:dt="urn:schemas-microsoft-com:datatypes">
  <xsl:template match="/">
    <html>
      <body>
        <h1><xsl:value-of select="ErrorLogModel/LogName"/></h1>
        <table>
          <tr>
            <td>
              Date
            </td>
            <td>
              Message
            </td>
          </tr>
          <xsl:for-each select="ErrorLogModel/ErrorModels/ErrorModel">
            <tr style="vertical-align: top;">
              <td style="border-top: 1px solid black;  border-left: 1px solid black">
                <xsl:value-of select="Date"/>
              </td>
              <td style="border-top: 1px solid black;">
                <xsl:value-of select="Message"/>
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>
