<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:template match="/">
        <html>
            <body>
                <!-- Título de la página -->
                <h2 style="text-align:center">Listado de alumnos</h2>
                <!-- Tabla de alumnos -->
                <table border="1" cellpadding="5" cellspacing="0" style="width:40%; border-collapse:collapse; margin-left: 30%">
                    <tr bgcolor="grey">
                        <th style="text-align:center">Alumno</th>
                        <th style="text-align:center">Asignatura</th>
                        <th style="text-align:center">Nota</th>
                        <th style="text-align:center">Fecha</th>
                    </tr>
                    <!-- Iteración sobre cada alumno del archivo xml -->
                    <xsl:for-each select="alumnos/alumno">
                    <tr>
                        <td style="text-align:center"><xsl:value-of select="nombre"/></td>
                        <td style="text-align:center"><xsl:value-of select="asignatura"/></td>
                        <td style="text-align:center"><xsl:value-of select="nota"/></td>
                        <td style="text-align:center"><xsl:value-of select="fecha"/></td>
                    </tr>
                    </xsl:for-each>
                </table>
            </body>
        </html>
    </xsl:template>
</xsl:stylesheet>