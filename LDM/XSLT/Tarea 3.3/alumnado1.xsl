<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:template match="/">
        <html>
            <body>
                <!-- Título de la página -->
                <h2 style="text-align:center">Datos académicos</h2>
                <!-- Tabla de alumnos -->
                <table border="1" cellpadding="5" cellspacing="0" style="width:40%; border-collapse:collapse; margin-left: 30%">
                    <tr bgcolor="grey">
                        <th style="text-align:center">Alumno</th>
                        <th style="text-align:center">Asignatura</th>
                        <th style="text-align:center">Nota</th>
                        <th style="text-align:center">FechaNota</th>
                    </tr>
                    <!-- Iteración sobre los datos academicos de cada alumno del archivo alumando.xml-->
                     <xsl:for-each select="alumnado/alumno">
                         <xsl:sort select="nombre" /> <!-- Ordenar a los alumnos alfabéticamente-->
                         <xsl:for-each select="asignaturas/asignatura"> <!-- Iteración sobre las asignaturas de cada alumnado, por si hay más de una asignatura -->
                            <tr>
                                <td style="text-align:center"><xsl:value-of select="../../nombre"/></td>
                                <td style="text-align:center"><xsl:value-of select="nombre_asig"/></td>
                                <td style="text-align:center"><xsl:value-of select="nota"/></td>
                                <td style="text-align:center"><xsl:value-of select="fecha_nota"/></td>
                            </tr>
                        </xsl:for-each>
                     </xsl:for-each>
                </table>
            </body>
        </html>
    </xsl:template>
</xsl:stylesheet>